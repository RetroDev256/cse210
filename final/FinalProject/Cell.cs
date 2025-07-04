// Base abstract class for each cell in our grid
// Each cell can be updated (each time step) and
// has a particular symbol which it represents.

public abstract class Cell
{
    // Change the state of the cell forward by one time step. The return value
    // is an OOP hack to allow a class to change it's type. The calling
    // function must honor this and change the cell to the returned value.
    public abstract Cell Update();

    // Return the character representing the cell
    public abstract char Symbol();
}