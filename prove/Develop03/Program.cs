class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.RenderString()}\n");
            Console.WriteLine("Press enter to continue, type 'quit' to finish, 'new' for new scripture:");
            scripture.HideMore();

            string input = Console.ReadLine();
            if (input == "quit") break;
            if (input == "new") scripture = new Scripture();
        }
    }
}