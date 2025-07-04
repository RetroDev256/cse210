// Class representing everything about the snake - it's position, it's length,
// the current direction it is facing, with methods to update it's direction
// by reading standard input, etc.

public class Snake
{
    private int _length;
    private Coordinate _pos;
    private Direction _dir;

    public Snake(Coordinate dim)
    {
        _length = 5;
        _pos = new Coordinate(dim.GetX() / 3, dim.GetY() / 2);
        _dir = Direction.Right;
    }

    // Check for user input, and update the direction we are facing if the new
    // direction does not request that we face exactly backwards. This is to
    // prevent colliding with ourselves by moving directly backwards. After we
    // check for user input (and change the direction of the snake), move the
    // snake to the new direction.
    public void Move()
    {
        // Don't want to block on user input, but do continue to process inputs
        // while we haven't read a valid arrow key direction from terminal IO.
        // This allows the user to rapidly press keys, building up a queue of
        // inputs, yet does not block if they were to enter useless text.
        while (Console.KeyAvailable)
        {
            // According to C# spec, the intercept: true is similar to IOCTL
            // disabling of TERMIOS echo, meaning that the keypress won't be
            // echoed to the terminal when it is typed by the user.
            switch (Console.ReadKey(intercept: true).Key)
            {
                case ConsoleKey.LeftArrow:
                    if (_dir != Direction.Right) _dir = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    if (_dir != Direction.Left) _dir = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    if (_dir != Direction.Down) _dir = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    if (_dir != Direction.Up) _dir = Direction.Down;
                    break;
                default:
                    continue;
            }
            break;
        }

        _pos.Move(_dir);
    }

    // This function is called by the Game class, to determine if the Snake
    // hits a wall, intercepts food, or collides with itself.
    public Coordinate GetPos()
    {
        return _pos;
    }

    // This function is called to get the achieved score
    public int GetLength()
    {
        return _length;
    }

    // This function is called whenever the snake intercepts food
    public void Grow()
    {
        _length += 3;
    }
}