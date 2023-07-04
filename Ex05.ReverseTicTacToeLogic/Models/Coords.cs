namespace Ex05.ReverseTicTacToeLogic.Models
{
    public readonly struct Coords
    {
        public int X { get; }
        public int Y { get; }

        public Coords(int i_X, int i_Y)
        {
            X = i_X;
            Y = i_Y;
        }
    }
}