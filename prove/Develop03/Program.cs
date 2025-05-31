class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        while (true)
        {
            Console.WriteLine($"{scripture.RenderString()}\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            if (Console.ReadLine() == "quit") break;
            scripture.HideMore();
        }
    }
}