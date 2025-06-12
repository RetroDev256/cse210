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
        EndMessage();
        // TODO
    }
}