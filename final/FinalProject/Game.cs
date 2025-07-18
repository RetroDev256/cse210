// The class representing the game as a whole -
// excluding the splash screen or high score screen.
public class Game
{
    private Snake _snake;
    private Grid _cells;
    private Coordinate _dim;

    public Game(Coordinate dim)
    {
        _dim = dim;
        _cells = new Grid(dim);
        _snake = new Snake(dim);
        Console.Clear();
    }

    // Run the game as a whole - return the achieved score
    public int Run()
    {
        bool alive = true;

        while (alive)
        {
            _snake.Move();
            _cells.UpdateCells();
            Coordinate pos = _snake.GetPos();

            switch (_cells.GetCell(pos, _dim.GetX()))
            {
                // We grow if we run into food
                case FoodCell:
                    _snake.Grow();
                    if (!_cells.PlaceFood())
                        alive = false;
                    break;

                // Both WallCell and SnakeCell mean that we have crashed
                case WallCell:
                case SnakeCell:
                    alive = false;
                    break;
            }

            // Place the head of the snake on the grid
            SnakeCell snakeHead = new SnakeCell(_snake.GetLength());
            _cells.SetCell(pos, _dim.GetX(), snakeHead);

            Render();

            // This *can* be changed to be different depending on the snake's
            // direction - to help deal with console characters not being a
            // perfect 1:1 apsect ratio. In reality, I won't change it, because
            // terminal character aspect ratios aren't standardized, there's no
            // cross-platform way to get this information, and from testing it
            // out myself, the gameplay is really weird this way, even if
            // technically the game moves at the same rate in all 4 directions.
            Thread.Sleep(100);
        }

        return _snake.GetLength();
    }

    private void Render()
    {
        int score = _snake.GetLength();
        string map = _cells.Format(_dim.GetX());
        string time = DateTime.Now.ToString("HH:mm:ss");
        Console.SetCursorPosition(0, 0);
        Console.WriteLine($"Snake Game - Time: {time} - Score: {score}\n{map}");
    }

}