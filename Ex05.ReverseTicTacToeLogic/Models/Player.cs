using System;

namespace Ex05.ReverseTicTacToeLogic.Models
{
    public class Player
    {
        public Player(string i_Name, eCellMarker i_Marker, ePlayerType i_Type)
        {
            Name = i_Name;
            Marker = i_Marker;
            Type = i_Type;
            Score = 0;
        }

        public int Score { get; set; }
        public string Name { get; }
        public eCellMarker Marker { get; }
        public ePlayerType Type { get; }
    }
}