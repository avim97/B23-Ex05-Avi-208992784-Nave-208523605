using System.Windows.Forms;
using Ex05.ReverseTicTacToeUI.DTOs;
using Ex05.ReverseTicTacToeUI.Forms;

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
                var gameStateDto = createGameInitialStateDTO();
                m_FormGame = new FormGame();
                m_FormGame.InitializeFormGame(gameStateDto);
                m_FormGame.ShowDialog();
                m_FormGame.Dispose();
            }

            r_FormGameSettings.Dispose();
        }

        private GameStateDTO createGameInitialStateDTO()
        {
            string firstPlayerName = r_FormGameSettings.FirstPlayerName;
            string secondPlayerName = r_FormGameSettings.SecondPlayerName;
            const string k_FirstPlayerMarker = "X";
            const string k_SecondPlayerMarker = "O";
            var isAiMatch = r_FormGameSettings.IsAiMatch;
            var boardSize = r_FormGameSettings.BoardSize;

            GameStateDTO initialGameState = new GameStateDTO
            {
                FirstPlayerName = firstPlayerName,
                SecondPlayerName = secondPlayerName,
                IsAiMatch = isAiMatch,
                BoardSize = boardSize,
                FirstPlayerMarker = k_FirstPlayerMarker,
                SecondPlayerMarker = k_SecondPlayerMarker
            };

            return initialGameState;
        }
    }
}