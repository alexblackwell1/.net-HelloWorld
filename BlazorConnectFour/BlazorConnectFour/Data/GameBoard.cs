using BlazorConnectFour.Data;

namespace BlazorConnectFour.Data
{
    public class GameBoard
    {
        public int Width { get; } = 7;
        public int Height { get; } = 6;
        public GamePiece[,] Board;

        public GameBoard()
        {
            // set like this for memory speed
            Board = new GamePiece[Width,Height];

            // init all piecies to empty
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Board[i, j] = new GamePiece(PieceColor.Blank);
                }
            }
        }

        public void Restart()
        {
            // reset all piecies to empty
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Board[i, j].Color = PieceColor.Blank;
                }
            }
        }
    }
}
