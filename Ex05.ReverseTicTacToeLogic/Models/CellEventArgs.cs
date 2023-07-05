using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.ReverseTicTacToeLogic.Models
{
    public class CellEventArgs: EventArgs
    {
        public string Marker { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
