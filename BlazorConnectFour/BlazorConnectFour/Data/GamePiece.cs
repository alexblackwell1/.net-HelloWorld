namespace BlazorConnectFour.Data
{
    public class GamePiece
    {
        public PieceColor Color { get; set; }

        public GamePiece(PieceColor color)
        {
            Color = color;
        }
    }
}
