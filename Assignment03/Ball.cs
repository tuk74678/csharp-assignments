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
    
    // Sets size to 0
    public void Pop() => Size = 0;

    // increases throw count if not popped
    public void Throw()
    {
        if (Size > 0)
            _throwCount++;
    }

    // returns throw count
    public int GetThrowCount() => _throwCount;
}
