namespace Ex05.ReverseTicTacToeUI.Models
{
    public class GameSettingsDto
    {
        public string FirstPlayerName { get; set; }
        public string SecondPlayerName { get; set; }
        public string FirstPlayerMarker { get; set; }
        public string SecondPlayerMarker { get; set; }
        public bool IsAiMatch { get; set; }
        public int BoardSize { get; set; }
    }
}