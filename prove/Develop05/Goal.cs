public abstract class Goal
{   
    // The name of the goal
    protected string _name;

    // The description of the goal
    protected string _description;

    // The number of points for finishing the goal
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Marks a goal as having one event completed
    public abstract int RecordEvent();

    // Checks whether the overall goal is finished
    public abstract bool Completed();

    // Returns a string representing the status of the goal
    public abstract string GetStatus();

    // Serializes the goal to a string
    public virtual string AsString()
    {
        return $"{_name}\n{_description}\n{_points}\n";
    }
}