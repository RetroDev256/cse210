// A class abstracting coordinates, mapping between flat-indexed
// arrays, which is how I am storing cells in the grid.

public class Coordinate
{
    private int _x;
    private int _y;

    public Coordinate(int x, int y)
    {
        _x = x;
        _y = y;
    }

    // Convert to a flat index
    public int Flat(int width)
    {
        return _x + _y * width;
    }

    public int GetX()
    {
        return _x;
    }

    public int GetY()
    {
        return _y;
    }

    public int Area()
    {
        return _x * _y;
    }

    // Shift by a cardinal direction
    public void Move(Direction dir)
    {
        switch (dir)
        {
            case Direction.Left:
                _x -= 1;
                break;
            case Direction.Right:
                _x += 1;
                break;
            case Direction.Up:
                _y -= 1;
                break;
            case Direction.Down:
                _y += 1;
                break;
        }
    }
}