using System;

namespace Ex05.ReverseTicTacToeLogic.Models
{
    [Flags]
    public enum eGameStatuses
    {
        Running = 1,
        Quit = 2,
        Finished = 4,
    }
}