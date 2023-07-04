using System;
using System.Drawing;
using System.Windows.Forms;
using Ex05.ReverseTicTacToeLogic.Infrastructure;
using Ex05.ReverseTicTacToeUI.Models;

namespace Ex05.ReverseTicTacToeUI
{
    public partial class FormGame : Form
    {
        private readonly GameEngine r_GameEngine;
        private readonly GameSettingsDto r_GameSettings;

        public FormGame(GameSettingsDto gameSettings)
        {
            r_GameEngine = new GameEngine();
            r_GameSettings = gameSettings;
            InitializeComponent();
            configureFormLayoutSettings();
        }

        private void configureFormLayoutSettings()
        {
            setGameOverviewData();
            setBoardLayout(r_GameSettings.BoardSize);
            setFormLayout();
        }

        public void InitializeGameSession()
        {
            var boardSize = r_GameSettings.BoardSize;
            var firstPlayerName = r_GameSettings.FirstPlayerName;
            var secondPlayerName = r_GameSettings.SecondPlayerName;
            var isAiMatch = r_GameSettings.IsAiMatch;

            r_GameEngine.InitializeBoard(boardSize);
            r_GameEngine.SetGamePlayers(firstPlayerName, secondPlayerName, isAiMatch);
        }

        private void setGameOverviewData()
        {
            const string k_PlayerMarkerFormat = "Marker: {0}";
            const string k_PlayerScoreFormat = "Score: {0}";
            const int k_InitialScore = 0;

            labelFirstPlayerName.Text = r_GameSettings.FirstPlayerName;
            labelFirstPlayerMarker.Text = string.Format(k_PlayerMarkerFormat, r_GameSettings.FirstPlayerMarker);
            labelFirstPlayerScore.Text = string.Format(k_PlayerScoreFormat, k_InitialScore);

            labelSecondPlayerName.Text = r_GameSettings.SecondPlayerName;
            labelSecondPlayerMarker.Text = string.Format(k_PlayerMarkerFormat, r_GameSettings.SecondPlayerMarker);
            labelSecondPlayerScore.Text = string.Format(k_PlayerScoreFormat, k_InitialScore);
        }

        private void setBoardLayout(int i_BoardSize)
        {
            tableLayoutPanelBoard.ColumnCount = i_BoardSize;
            tableLayoutPanelBoard.RowCount = i_BoardSize;
            tableLayoutPanelBoard.Size = new Size(60 * i_BoardSize, 60 * i_BoardSize);
        }

        private void setFormLayout()
        {
            groupBoxGameOverview.Size = new Size(742, 156);
            var formWidth = Math.Max(tableLayoutPanelBoard.Width, groupBoxGameOverview.Width) + 20 * 2;
            var formHeight = tableLayoutPanelBoard.Height + groupBoxGameOverview.Height + 20 * 3 + 15;

            ClientSize = new Size(formWidth, formHeight);
            tableLayoutPanelBoard.Location = new Point((Width - tableLayoutPanelBoard.Width) / 2, 20);
            groupBoxGameOverview.Location =
                new Point((Width - groupBoxGameOverview.Width) / 2, tableLayoutPanelBoard.Bottom + 15);
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            var boardSize = r_GameSettings.BoardSize;
            const int k_ButtonCellSize = 60;

            for (var i = 0; i < boardSize; i++)
            {
                for (var j = 0; j < boardSize; j++)
                {
                    var buttonCell = new Button();
                    buttonCell.Size = new Size(k_ButtonCellSize, k_ButtonCellSize);
                    tableLayoutPanelBoard.Controls.Add(buttonCell, j, i);
                    buttonCell.Click += buttonCell_Click;
                    r_GameEngine.Board.Cells[i, j].ValueChanged += boardCell_ValueChanged;
                }

                tableLayoutPanelBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, k_ButtonCellSize));
                tableLayoutPanelBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, k_ButtonCellSize));
            }
        }

        private void buttonCell_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
        }

        private void boardCell_ValueChanged(int i_X, int i_Y, string i_NewCellValue)
        {
            var changedButton = tableLayoutPanelBoard.GetControlFromPosition(i_Y, i_X) as Button;

            changedButton.Text = i_NewCellValue;
            changedButton.Enabled = false;
        }

        private void labelSecondPlayerTurnIndicator_Click(object sender, EventArgs e)
        {
        }

        private void labelFirstPlayerTurnIndicator_Click(object sender, EventArgs e)
        {
        }

        private void labelFirstPlayerCurrentTurn_Click(object sender, EventArgs e)
        {
        }
    }
}