using System;
using System.Drawing;
using System.Linq;
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
            setGameOverviewData();
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
            r_GameEngine.Board.Reinitialized += Board_Reinitialization;
            r_GameEngine.Players.First().ScoreChange += firstPlayer_ScoreChanged;
            r_GameEngine.Players.First().Played += firstPlayer_Played;
            r_GameEngine.Players.Last().ScoreChange += secondPlayer_ScoreChanged;
            r_GameEngine.Players.Last().Played += secondPlayer_Played;

        }

        private void setGameOverviewData()
        {
            const string k_PlayerOverviewFormat = @"{0}  Marker: {1} Score: {2}";

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
            var boardSize = m_GameState.BoardSize;
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
                    r_GameEngine.Board.Cells[i, j].ValueChanged += BoardCell_ValueChanged;
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
            handleMoveResult(buttonCoords);
            if (r_GameEngine.CurrentPlayerType.Equals(ePlayerType.Computer))
            {
                r_GameEngine.ExecuteComputerMove(out Coords chosenCellCoords);
                handleMoveResult(chosenCellCoords);
            }
        }

        private void BoardCell_ValueChanged(int i_X, int i_Y, string i_NewCellMarker)
        {
            var button = tableLayoutPanelBoard.GetControlFromPosition(i_Y, i_X);

            if (button is Button changedButton)
            {
                var buttonBackColor = i_NewCellMarker.Equals(m_GameState.FirstPlayerMarker)
                    ? Color.Gold
                    : Color.Aquamarine;

                changedButton.Text = i_NewCellMarker;
                changedButton.BackColor = buttonBackColor;
                changedButton.Enabled = false;
            }
        }

        private void Board_Reinitialization()
        {
            foreach (Button button in tableLayoutPanelBoard.Controls)
            {
                button.Text = string.Empty;
                button.Enabled = true;
            }
        }

        private void handleMoveResult(Coords i_MarkedCellCoords)
        {
            var moveResult = r_GameEngine.CheckPlayerMoveExecutionResult(i_MarkedCellCoords);
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

            if (replayDialogResult != DialogResult.None)
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
        }

        private void firstPlayer_ScoreChanged(int i_Score)
        {
            m_GameState.FirstPlayerScore = i_Score;
            setGameOverviewData();
        }

        private void firstPlayer_Played()
        {
            if (!m_GameState.IsAiMatch)
            {
                labelFirstPlayerTurnIndicator.Visible = false;
                labelSecondPlayerTurnIndicator.Visible = true;
            }
        }

        private void secondPlayer_ScoreChanged(int i_Score)
        {
            m_GameState.SecondPlayerScore = i_Score;
            setGameOverviewData();
        }

        private void secondPlayer_Played()
        {
            labelSecondPlayerTurnIndicator.Visible = false;
            labelFirstPlayerTurnIndicator.Visible = true;
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