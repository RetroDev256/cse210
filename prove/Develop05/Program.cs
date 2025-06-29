using System;

class Program
{
    static void Main(string[] args)
    {
        string main_menu = "Menu Options:\n"
            + "    1. Create New Goal\n"
            + "    2. List Goals\n"
            + "    3. Save Goals\n"
            + "    4. Load Goals\n"
            + "    5. Record Event\n"
            + "    6. Quit\n"
            + "Select an option: ";

        GoalManager manager = new GoalManager();

        bool is_looping = true;
        while (is_looping)
        {
            manager.DisplayScore();
            Console.Write(main_menu);
            switch (Console.ReadLine())
            {
                case "1":
                    CreateNewGoal(manager);
                    break;

                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    Console.Write("Enter a filename: ");
                    manager.Save(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter a filename: ");
                    manager.Load(Console.ReadLine());
                    break;

                case "5":
                    manager.DisplayGoals();
                    Console.Write("Select a goal to record: ");
                    // We display the goals with 1-based indexes
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoal(index);
                    break;

                case "6":
                    is_looping = false;
                    break;
            }
            Console.WriteLine();
        }
    }

    static void CreateNewGoal(GoalManager manager)
    {
        string creation_menu = "The types of Goals are:\n"
            + "    1. Simple Goal\n"
            + "    2. Eternal Goal\n"
            + "    3. Checklist Goal\n"
            + "    4. Negative Goal\n"
            + "Select an option: ";

        Console.Write(creation_menu);
        string type = Console.ReadLine();

        // Each goal needs to know these things
        Console.Write("Enter the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description of your goal: ");
        string desc = Console.ReadLine();
        Console.Write("Enter the number of points for each goal event: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                SimpleGoal s_goal = new SimpleGoal(name, desc, points, false);
                manager.AddGoal(s_goal);
                break;

            case "2":
                EternalGoal e_goal = new EternalGoal(name, desc, points);
                manager.AddGoal(e_goal);
                break;

            case "3":
                // The checklist goal requires more information than the other goals
                Console.Write("Enter the number of events for this goal: ");
                int count = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus you want for finishing the goal: ");
                int bonus = int.Parse(Console.ReadLine());

                CheckListGoal c_goal = new CheckListGoal(name, desc, points, count, 0, bonus);
                manager.AddGoal(c_goal);
                break;

            case "4":
                NegativeGoal n_goal = new NegativeGoal(name, desc, points);
                manager.AddGoal(n_goal);
                break;
        }
    }
}