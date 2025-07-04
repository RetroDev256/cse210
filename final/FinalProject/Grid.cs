// Class representing the playing field of the game
public class Grid
{
    private List<Cell> _cells;

    public Grid(Coordinate dim)
    {
        // Every cell is initially empty
        _cells = new List<Cell>();
        for (int i = 0; i < dim.Area(); i += 1)
            _cells.Add(new EmptyCell());

        // Add in the walls
        int height = dim.GetY();
        int width = dim.GetX();

        for (int y = 0; y < height; y += 1)
        {
            _cells[y * width] = new WallCell();
            _cells[(y + 1) * width - 1] = new WallCell();
        }

        for (int x = 0; x < width; x += 1)
        {
            _cells[x] = new WallCell();
            _cells[x + (height - 1) * width] = new WallCell();
        }

        // Place some food
        PlaceFood();
    }

    public Cell GetCell(Coordinate pos, int width)
    {
        int index = pos.Flat(width);
        return _cells[index];
    }

    public void SetCell(Coordinate pos, int width, Cell cell)
    {
        int index = pos.Flat(width);
        _cells[index] = cell;
    }

    public void UpdateCells()
    {
        for (int i = 0; i < _cells.Count; i += 1)
            _cells[i] = _cells[i].Update();
    }

    // Rasterizes the grid according to what each cell would display
    public string Format(int width)
    {
        string result = "";
        for (int i = 0; i < _cells.Count; i += 1)
        {
            if (i % width == 0)
                result += '\n';
            result += _cells[i].Symbol();
        }
        // Skip the first '\n'
        return result.Substring(1);
    }

    // Places food in the grid - returns false if it cannot do so.
    public bool PlaceFood()
    {
        // Count the empty cells to ensure that we *can* place food
        int empty_count = 0;
        foreach (Cell c in _cells)
            if (c is EmptyCell)
                empty_count += 1;

        if (empty_count == 0) return false;

        // Select a new place to put our food
        Random prng = new Random();
        int offset = prng.Next(empty_count);
        int index = 0;

        while (true)
        {
            // We are guaranteed to not index out of bounds here because we
            // have ensured that offset will place us within the distribution
            // of empty cells within our grid.
            if (_cells[index] is EmptyCell)
            {
                if (offset == 0)
                    break;
                offset -= 1;
            }
            index += 1;
        }

        // Place the food at the selected index
        _cells[index] = new FoodCell();
        return true;
    }
}