using System;

namespace Ex05.ReverseTicTacToeLogic.Models
{
    public struct Cell
    {
        public event Action<CellEventArgs> Marked;

        private eCellMarker m_Marker;
        public Coords Coords { get; set; }
        public eCellMarker Marker
        {
            get => m_Marker;
            set
            {
                m_Marker = value;
                if (m_Marker != eCellMarker.None)
                {
                    OnMarked();
                }
            }
        }

        private void OnMarked()
        {
            var eventArgs = new CellEventArgs()
            {
                X = Coords.X,
                Y = Coords.Y,
                Marker = this.m_Marker.Equals(eCellMarker.None) ? string.Empty : this.m_Marker.ToString()
            };

            Marked?.Invoke(eventArgs);
        }
    }
}