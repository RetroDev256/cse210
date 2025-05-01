class Program
{
    static void Main(string[] args)
    {
        List<int> integers = new List<int>();

        for (int i = 0; i < 10; i += 1) {
            integers.Add(i);
        }

        foreach (int i in integers) {
            Console.WriteLine($"Integer: {i}");
        }
    }
}