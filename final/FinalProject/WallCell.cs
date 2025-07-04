// A polymorphic instance of the base class Cell - 
// This represents the wall bounding the playing field
public class WallCell : Cell
{
    public override Cell Update()
    {
        // Do nothing, we are a wall
        return this;
    }

    public override char Symbol()
    {
        return '#';
    }
}