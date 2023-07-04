namespace Ex05.ReverseTicTacToeLogic.Models
{
    public class Board
    {
        public int Width { get; }
        public int Height { get; }
        public Cell[,] Cells { get; set; }
        public int MarkedCells { get; set; }
        public Board(int i_Size)
        {
            Width = i_Size;
            Height = i_Size;
            Cells = new Cell[Width, Height];
            setCellsCoords();
            MarkedCells = 0;
        }

        private void setCellsCoords()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Cells[i, j].Coords = new Coords(i, j);
                }
            }
        }
    }
}
