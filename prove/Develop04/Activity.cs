class Activity
{
    private string _name;
    private string _description;
    protected int _duration { get; private set; }

    protected Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    protected void StartMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} activity.\n\n{_description}\n");
        CountDown("Get ready...", 5);
        Console.WriteLine();
    }

    protected void EndMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.\n");
    }

    // Repeat a message and the duration as it counts down
    protected static void CountDown(string message, int duration)
    {
        while (duration > 0)
        {
            Console.Write($"\r{message} {duration} ");

            // Exceeding requirements
            string symbols = "\\|/-";
            for (int i = 0; i < 8; i += 1)
            {
                Console.Write(symbols[i % 4]);
                Delay(125);
                Console.Write("\b");
            }
            Console.Write(" ");

            duration -= 1;
        }
        Console.WriteLine($"\r{message}  ");
    }

    // Block the execution of the current thread by duration_ms milliseconds
    private static void Delay(int duration_ms)
    {
        // Thread.Sleep takes milliseconds
        Thread.Sleep(duration_ms);
    }
}