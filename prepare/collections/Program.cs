class Program
{
    static void Main(string[] args)
    {
        List<int> number_list = new List<int>();

        // Append numbers until the user enters 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            int number = readInt();
            if (number == 0) break;
            number_list.Add(number);
        }

        int sum = number_list.Sum();
        Console.WriteLine($"The sum is: {sum}");

        float avg = (float)sum / number_list.Count();
        Console.WriteLine($"The average is: {avg}");

        int max = number_list.Max();
        Console.WriteLine($"The largest number is: {max}");

        // Stretch challenge #1
        int min_positive = number_list.Where(x => x > 0).Min();
        Console.WriteLine($"The smallest positive integer is: {min_positive}");

        // Stretch challenge #2
        number_list.Sort();
        Console.Write($"The sorted list is: [");
        for (int i = 0; i < number_list.Count(); i += 1)
        {
            Console.Write(number_list[i]);
            if (i + 1 < number_list.Count())
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    // Query the user for an integer, repeating on invalid input
    static int readInt()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int parsed))
            {
                return parsed;
            }
            Console.Write("Invalid input. Try again: ");
        }
    }
}

