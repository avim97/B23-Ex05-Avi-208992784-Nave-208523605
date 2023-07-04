namespace Ex05.ReverseTicTacToeLogic.Models
{
    public class Player
    {
        public string Name { get; }
        public eCellMarker Marker { get; }
        public int Score { get; set; }
        public ePlayerType PlayerType { get; }

        public Player(string i_Name, eCellMarker i_Marker, ePlayerType i_PlayerType)
        {
            Name = i_Name;
            Marker = i_Marker;
            PlayerType = i_PlayerType;
            Score  = 0;
        }
    }
}
