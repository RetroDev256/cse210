// A polymorphic instance of the base class Cell - 
// This represents an empty space that anything can inhabit
public class EmptyCell : Cell
{
    public EmptyCell() { }

    public override Cell Update()
    {
        return this;
    }

    public override char Symbol()
    {
        return ' ';
    }
}