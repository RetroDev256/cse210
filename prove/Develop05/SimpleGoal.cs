public class SimpleGoal : Goal
{
    // Marks if the goal has finished
    private bool _completed;

    public SimpleGoal(string name, string description, int points, bool completed)
    : base(name, description, points)
    {
        _completed = completed;
    }

    // Marks a goal as having one event completed
    public override int RecordEvent()
    {
        // You can not complete this goal more than once.
        if (Completed()) return 0;

        _completed = true;
        return _points;
    }

    // Checks whether the overall goal is finished
    public override bool Completed()
    {
        return _completed;
    }

    // Returns a string representing the status of the goal
    public override string GetStatus()
    {
        return $"{_name} - {_description}";
    }

    // Serializes the goal to a string
    public override string AsString()
    {
        return $"SIMPLE\n{base.AsString()}{_completed}\n";
    }
}