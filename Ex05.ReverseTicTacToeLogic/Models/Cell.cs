using System;

namespace Ex05.ReverseTicTacToeLogic.Models
{
    public struct Cell
    {
        public event Action<int,int,string> ValueChanged;
        public Coords Coords { get; set; }

        public eCellMarker Marker
        {
            get => Marker;
            set
            {
                Marker = value;
                OnValueChanged();
            }

        }

        private void OnValueChanged()
        {
            int xCoord = this.Coords.X;
            int yCoord = this.Coords.Y;

            ValueChanged?.Invoke(xCoord, yCoord, Marker.ToString());
        }
    }
}
