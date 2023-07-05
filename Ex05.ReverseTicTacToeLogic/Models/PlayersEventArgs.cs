using System;

namespace Ex05.ReverseTicTacToeLogic.Models
{
    public class PlayersEventArgs : EventArgs
    {
        public int FirstPlayerScore { get; set; }
        public int SecondPlayerScore { get; set; }
    }
}
