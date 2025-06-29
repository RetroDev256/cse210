// Exceeding the requirements - a goal to track bad habits,
// subtracting from your score each time you have an event

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
    : base(name, description, points) { }

    // Marks a goal as having one event completed
    public override int RecordEvent()
    {
        return -_points;
    }

    // Checks whether the overall goal is finished (it never is)
    public override bool Completed()
    {
        return false;
    }

    // Returns a string representing the status of the goal
    public override string GetStatus()
    {
        return $"{_name} - {_description}";
    }

    // Serializes the goal to a string
    public override string AsString()
    {
        return $"NEGATIVE\n{base.AsString()}";
    }
}