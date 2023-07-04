using System.Windows.Forms;
using Ex05.ReverseTicTacToeUI.Models;

namespace Ex05.ReverseTicTacToeUI.Controllers
{
    public class FormsController
    {
        private readonly FormGameSettings r_FormGameSettings;
        private FormGame m_FormGame;

        public FormsController()
        {
            r_FormGameSettings = new FormGameSettings();
        }

        public void Start()
        {
            r_FormGameSettings.ShowDialog();
            if (r_FormGameSettings.DialogResult.Equals(DialogResult.Yes))
            {
                createGameSettingsDto(out var gameSettingsDto);
                m_FormGame = new FormGame(gameSettingsDto);
                m_FormGame.InitializeGameSession();
                m_FormGame.ShowDialog();
                m_FormGame.Dispose();
            }

            r_FormGameSettings.Dispose();
        }

        private void createGameSettingsDto(out GameSettingsDto o_GameSettings)
        {
            var firstPlayerName = r_FormGameSettings.FirstPlayerName;
            var secondPlayerName = r_FormGameSettings.SecondPlayerName;
            var isAiMatch = r_FormGameSettings.IsAiMatch;
            var boardSize = r_FormGameSettings.BoardSize;
            const string k_FirstPlayerMarker = "X", k_SecondPlayerMarker = "O";

            o_GameSettings = new GameSettingsDto
            {
                FirstPlayerName = firstPlayerName,
                SecondPlayerName = secondPlayerName,
                IsAiMatch = isAiMatch,
                BoardSize = boardSize,
                FirstPlayerMarker = k_FirstPlayerMarker,
                SecondPlayerMarker = k_SecondPlayerMarker
            };
        }
    }
}