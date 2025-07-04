// A polymorphic instance of the base class Cell - 
// This represents a section of the snake body
public class SnakeCell : Cell
{

    // The number of cells which remain at this point in the snake's body -
    // this integer determines how long the cell should remain before it
    // becomes an EmptyCell.
    private int _remainingLength;

    public SnakeCell(int snakeLength)
    {
        _remainingLength = snakeLength;
    }

    public override Cell Update()
    {
        // The snake is always moving forward, so the remaining length of the
        // snake at any one cell is always decreasing.
        _remainingLength -= 1;

        // The snake remains so as long as the remaining length is not zero
        if (_remainingLength == 0)
        {
            return new EmptyCell();
        }

        return this;
    }

    public override char Symbol()
    {
        // Alternate the character we use for the snake body
        string pattern = "eSnak";
        return pattern[_remainingLength % pattern.Count()];
    }
}