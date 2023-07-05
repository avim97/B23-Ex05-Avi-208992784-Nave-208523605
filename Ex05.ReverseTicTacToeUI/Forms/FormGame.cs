using System;
using System.Drawing;
using System.Windows.Forms;
using Ex05.ReverseTicTacToeLogic.Infrastructure;
using Ex05.ReverseTicTacToeLogic.Models;
using Ex05.ReverseTicTacToeUI.DTOs;
using Ex05.ReverseTicTacToeUI.Repositories;

namespace Ex05.ReverseTicTacToeUI.Forms
{
    public partial class FormGame : Form
    {
        private readonly GameEngine r_GameEngine;
        private GameStateDTO m_GameState;

        public FormGame()
        {
            r_GameEngine = new GameEngine();
            m_GameState = new GameStateDTO();
        }

        public void InitializeFormGame(GameStateDTO initialGameState)
        {
            m_GameState = initialGameState;
            InitializeComponent();
            configureFormLayoutSettings();
            initializeGameSession();
        }

        private void configureFormLayoutSettings()
        {
            updateGameOverview();
            setBoardLayout(m_GameState.BoardSize);
            setFormLayout();
        }

        private void initializeGameSession()
        {
            var boardSize = m_GameState.BoardSize;
            var firstPlayerName = m_GameState.FirstPlayerName;
            var secondPlayerName = m_GameState.SecondPlayerName;
            var isAiMatch = m_GameState.IsAiMatch;

            r_GameEngine.InitializeBoard(boardSize);
            r_GameEngine.SetGamePlayers(firstPlayerName, secondPlayerName, isAiMatch);
            r_GameEngine.Board.AfterReinitialize += board_ReInitialize;
            r_GameEngine.TurnSwitching += gameEngine_TurnSwitching;
            r_GameEngine.AfterScoresUpdate += gameEngine_AfterScoresUpdate;
        }

        private void updateGameOverview()
        {
            const string k_PlayerOverviewFormat = @"{0}  Marker:{1} Score:{2}";

            labelFirstPlayerOverview.Text = string.Format(k_PlayerOverviewFormat, m_GameState.FirstPlayerName,
                m_GameState.FirstPlayerMarker, m_GameState.FirstPlayerScore);
            labelSecondPlayerOverview.Text = string.Format(k_PlayerOverviewFormat, m_GameState.SecondPlayerName,
                m_GameState.SecondPlayerMarker, m_GameState.SecondPlayerScore);
        }

        private void setBoardLayout(int i_BoardSize)
        {
            const int k_ButtonSize = 60;

            tableLayoutPanelBoard.ColumnCount = i_BoardSize;
            tableLayoutPanelBoard.RowCount = i_BoardSize;
            tableLayoutPanelBoard.Size = new Size(k_ButtonSize * i_BoardSize, k_ButtonSize * i_BoardSize);
        }

        private void setFormLayout()
        {
            int formWidth = Math.Max(tableLayoutPanelBoard.Width, groupBoxGameOverview.Width) + 20 * 2;
            int formHeight = tableLayoutPanelBoard.Height + groupBoxGameOverview.Height + 20 * 3 + 15;

            ClientSize = new Size(formWidth, formHeight);
            tableLayoutPanelBoard.Location = new Point((Width - tableLayoutPanelBoard.Width) / 2, 20);
            groupBoxGameOverview.Location =
                new Point((Width - groupBoxGameOverview.Width) / 2, tableLayoutPanelBoard.Bottom + 30);
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            int boardSize = m_GameState.BoardSize;
            const int k_ButtonCellSize = 60;

            for (var i = 0; i < boardSize; i++)
            {
                for (var j = 0; j < boardSize; j++)
                {
                    var buttonCell = new Button
                    {
                        Size = new Size(k_ButtonCellSize, k_ButtonCellSize)
                    };

                    tableLayoutPanelBoard.Controls.Add(buttonCell, j, i);
                    buttonCell.Click += buttonCell_Click;
                    r_GameEngine.Board.AfterCellMarked += board_AfterCellMarked;
                }

                tableLayoutPanelBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, k_ButtonCellSize));
                tableLayoutPanelBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, k_ButtonCellSize));
            }
        }

        private void buttonCell_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            int xCoord = tableLayoutPanelBoard.GetCellPosition(clickedButton).Row;
            int yCoord = tableLayoutPanelBoard.GetCellPosition(clickedButton).Column;
            Coords buttonCoords = new Coords(xCoord, yCoord);

            r_GameEngine.ExecutePlayerMove(buttonCoords);
            eMoveResult lastMoveResult = handleMoveResult(buttonCoords);

            if (lastMoveResult.Equals(eMoveResult.NoEffect) && m_GameState.IsAiMatch)
            {
                r_GameEngine.ExecuteComputerMove(out Coords chosenCellCoords);
                handleMoveResult(chosenCellCoords);
            }
        }

        private void board_AfterCellMarked(CellEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            string marker = e.Marker;
            var buttonCell = tableLayoutPanelBoard.GetControlFromPosition(y, x);

            if (buttonCell is Button changedButton)
            {
                var buttonBackColor = marker.Equals(m_GameState.FirstPlayerMarker)
                    ? Color.Gold
                    : Color.Aquamarine;

                changedButton.Text = marker;
                changedButton.BackColor = buttonBackColor;
                changedButton.Enabled = false;
            }
        }

        private void board_ReInitialize()
        {
            foreach (Button button in tableLayoutPanelBoard.Controls)
            {
                button.Text = string.Empty;
                button.BackColor = Color.Transparent;
                button.Enabled = true;
            }
        }

        private eMoveResult handleMoveResult(Coords i_MarkedCellCoords)
        {
            var moveResult = r_GameEngine.GetMoveExecutionResult(i_MarkedCellCoords);
            var replayDialogResult = DialogResult.None;

            if (moveResult == eMoveResult.Lose)
            {
                var winningPlayerName = r_GameEngine.CurrentPlayerName;
                var winMessageToDisplay = UserMessagesRepo.GenerateWinMessage(winningPlayerName);
                replayDialogResult = displayGameResultMessage(winMessageToDisplay);
            }
            else if (moveResult == eMoveResult.Tie)
            {
                string tieMessageToDisplay = UserMessagesRepo.GenerateTieMessage();
                replayDialogResult = displayGameResultMessage(tieMessageToDisplay);
            }

            if (moveResult != eMoveResult.NoEffect)
            {
                if (replayDialogResult.Equals(DialogResult.Yes))
                {
                    r_GameEngine.ResetGameSession();
                }
                else
                {
                    Close();
                }
            }

            return moveResult;
        }

        private void gameEngine_TurnSwitching()
        {
            if (!m_GameState.IsAiMatch)
            {
                labelFirstPlayerTurnIndicator.Visible = !labelFirstPlayerTurnIndicator.Visible;
                labelSecondPlayerTurnIndicator.Visible = !labelSecondPlayerTurnIndicator.Visible;
            }
        }

        private void gameEngine_AfterScoresUpdate(PlayersEventArgs e)
        {
            m_GameState.FirstPlayerScore = e.FirstPlayerScore;
            m_GameState.SecondPlayerScore = e.SecondPlayerScore;
            updateGameOverview();
        }

        private DialogResult displayGameResultMessage(string i_MessageToDisplay)
        {
            const string k_EndGameMsgBoxCaption = "Game Finish";
            DialogResult replayDialogResult =
                MessageBox.Show(i_MessageToDisplay, k_EndGameMsgBoxCaption, MessageBoxButtons.YesNo);

            return replayDialogResult;
        }
    }
}