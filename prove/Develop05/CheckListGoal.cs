public class CheckListGoal : Goal
{
    // The number of times this goal must be marked to be "completed"
    private int _eventCount;
    // The number of times this goal has had a recorded event
    private int _completed;
    // An additional bonus for completing all the events
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int count, int completed, int bonus)
    : base(name, description, points)
    {
        _eventCount = count;
        _completed = completed;
        _bonus = bonus;
    }

    // Marks a goal as having one event completed
    public override int RecordEvent()
    {
        // You can not complete this goal more than once.
        if (Completed()) return 0;

        _completed += 1;
        int earned = _points;

        if (Completed()) earned += _bonus;

        return earned;
    }

    // Checks whether the overall goal is finished
    public override bool Completed()
    {
        return _completed == _eventCount;
    }

    // Returns a string representing the status of the goal
    public override string GetStatus()
    {
        return $"{_name} - {_description} - Completed {_completed}/{_eventCount}";
    }

    // Serializes the goal to a string
    public override string AsString()
    {
        return $"CHECKLIST\n{base.AsString()}{_eventCount}\n{_completed}\n{_bonus}\n";
    }
}