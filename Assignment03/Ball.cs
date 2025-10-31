namespace Assignment03;

public class Ball
{
    public int Size { get; private set; }
    public Color Color { get; private set; }
    private int _throwCount;
    
    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
        _throwCount = 0;
    }
}