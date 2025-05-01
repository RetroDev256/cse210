class Program
{
    static void Main(string[] args)
    {
        List<int> integers = new List<int>();

        for (int i = 0; i < 100; i += 1) {
            integers.Add(i);
        }

        int count = integers.Count();
        Console.WriteLine($"There are {count} items in the list.");

        int total = integers.Sum();
        Console.WriteLine($"Sum: {total} (using .Sum() method)");

        total = 0;
        foreach (int elem in integers) {
            total += elem;
        }
        Console.WriteLine($"Sum: {total} (using a foreach loop)");

        float average = (float)total / (float)count;
        Console.WriteLine($"Average: {average}");
    }
}