using System;

namespace Ex05.ReverseTicTacToeLogic.Models
{
    public struct Cell
    {
        public event Action<int, int, string> ValueChanged;
        public Coords Coords { get; set; }
        private eCellMarker m_Marker;

        public eCellMarker Marker
        {
            get => m_Marker;
            set
            {
                m_Marker = value;
                if (m_Marker != eCellMarker.None)
                {
                    OnValueChanged();
                }
            }
        }

        private void OnValueChanged()
        {
            var x = Coords.X;
            var y = Coords.Y;

            ValueChanged?.Invoke(x, y, Marker.ToString());
        }
    }
}