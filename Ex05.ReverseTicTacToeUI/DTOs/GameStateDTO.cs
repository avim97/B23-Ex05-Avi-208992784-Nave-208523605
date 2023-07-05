namespace Ex05.ReverseTicTacToeUI.DTOs
{
    public class GameStateDTO
    {
        public string FirstPlayerName { get; set; }
        public string FirstPlayerMarker { get; set; }
        public int FirstPlayerScore { get; set; }
        public string SecondPlayerName { get; set; }
        public string SecondPlayerMarker { get; set; }
        public int SecondPlayerScore { get; set; }
        public bool IsAiMatch { get; set; }
        public int BoardSize { get; set; }
    }
}