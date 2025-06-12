class Reflecting : Activity
{
    private static List<String> _prompts = new List<String>([
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    ]);
    private static List<String> _questions = new List<String>([
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    ]);

    public Reflecting(int duration) : base("reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration) { }

    public void RunReflecting()
    {
        StartMessage();

        Random rng = new Random();

        int delay = _duration;
        while (delay > 0)
        {
            string prompt = _prompts[rng.Next(_prompts.Count)];
            string question = _questions[rng.Next(_questions.Count)];

            Console.WriteLine(prompt);
            CountDown(question, 5);
            Console.WriteLine();
            
            delay -= 5;
        }

        EndMessage();
    }
}