// A polymorphic instance of the base class Cell - 
// This represents some food the snake can consume
public class FoodCell : Cell
{
    public override Cell Update()
    {
        // Food never spoils
        return this;
    }

    public override char Symbol()
    {
        return '+';
    }
}