using System.Diagnostics;

class Listing : Activity
{
    private static List<String> _prompts = new List<String>([
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    ]);

    public Listing(int duration) : base("listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration) { }

    public void RunListing()
    {
        StartMessage();
        Random rng = new Random();

        string prompt = _prompts[rng.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        CountDown("Think about this...", 5);
        Console.WriteLine($"Enter your answers here; you have {_duration} seconds:\n");

        Stopwatch timer = new Stopwatch();
        timer.Start();

        int count = 0;
        while (true)
        {
            string input = Console.ReadLine();

            double seconds = timer.Elapsed.TotalSeconds;
            if (seconds > (double)_duration)
            {
                Console.WriteLine($"\nTimes up! You entered {count} items.");
                break;
            }

            count += 1;
        }

        EndMessage();
    }
}