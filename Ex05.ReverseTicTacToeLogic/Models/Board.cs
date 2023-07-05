using System;

namespace Ex05.ReverseTicTacToeLogic.Models
{
    public class Board
    {
        public event Action AfterReinitialize;
        public event Action<CellEventArgs> AfterCellMarked;
        public int Width { get; }
        public int Height { get; }
        internal Cell[,] Cells { get; set; }
        public int MarkedCells { get; set; }

        public Board(int i_Size)
        {
            Width = i_Size;
            Height = i_Size;
            Cells = new Cell[Width, Height];
            assignCellsCoords();
            MarkedCells = 0;
        }

        private void assignCellsCoords()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Cells[i, j].Coords = new Coords(i, j);
                    Cells[i, j].Marked += cell_Marked;
                }
            }
        }

        private void cell_Marked(CellEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Marker))
            {
                MarkedCells++;
            }

            OnAfterCellMarker(e);
        }

        public void ReInitialize()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Cells[i, j].Marker = eCellMarker.None;
                }
            }

            MarkedCells = 0;
            OnAfterReinitialize();
        }

        protected virtual void OnAfterReinitialize()
        {
            AfterReinitialize?.Invoke();
        }

        protected virtual void OnAfterCellMarker(CellEventArgs e)
        {
            AfterCellMarked?.Invoke(e);
        }
    }
}