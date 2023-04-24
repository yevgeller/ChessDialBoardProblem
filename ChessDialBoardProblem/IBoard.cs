namespace ChessOnPhoneBoard
{
    public interface IBoard
    {
        int MaxX { get; set; }
        int MaxY { get; set; }
        List<Coordinate> Exceptions { get; set; }
    }
}