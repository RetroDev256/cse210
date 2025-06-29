using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void AddGoal(Goal g)
    {
        _goals.Add(g);
    }

    public void RecordGoal(int index)
    {
        _score += _goals[index].RecordEvent();
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your goals include:");
        for (int i = 0; i < _goals.Count; i += 1)
        {
            char mark = _goals[i].Completed() ? '#' : ' ';
            string status = _goals[i].GetStatus();
            Console.WriteLine($"{i + 1}. [{mark}] {status}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void Save(string filename)
    {
        string content = $"{_score}\n";
        content += $"{_goals.Count}\n";
        foreach (Goal goal in _goals)
        {
            content += goal.AsString();
        }
        File.WriteAllText(filename, content);
    }

    public void Load(string filename)
    {
        StreamReader reader = new StreamReader(filename);

        _score = int.Parse(reader.ReadLine());
        int goal_count = int.Parse(reader.ReadLine());

        _goals = [];
        for (int i = 0; i < goal_count; i += 1)
        {
            // These types all encode the following lines
            string type = reader.ReadLine();
            string name = reader.ReadLine();
            string desc = reader.ReadLine();
            int points = int.Parse(reader.ReadLine());

            // Some types encode more trailing information:
            switch (type)
            {
                case "SIMPLE":
                    bool s_completed = bool.Parse(reader.ReadLine());
                    _goals.Add(new SimpleGoal(name, desc, points, s_completed));
                    break;

                case "ETERNAL":
                    _goals.Add(new EternalGoal(name, desc, points));
                    break;

                case "CHECKLIST":
                    int count = int.Parse(reader.ReadLine());
                    int c_completed = int.Parse(reader.ReadLine());
                    int bonus = int.Parse(reader.ReadLine());
                    _goals.Add(new CheckListGoal(name, desc, points, count, c_completed, bonus));
                    break;
            }
        }

        reader.Close();
    }
}