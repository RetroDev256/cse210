class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int grade;

        while (true)
        {
            string input = Console.ReadLine() ?? "0";

            try
            {
                grade = int.Parse(input);
                if (grade >= 0 && grade <= 100)
                {
                    break;
                }
            }
            catch { }

            Console.Write("Invalid input. Try again: ");
        }


        char letter;

        if (grade >= 90)
        {
            letter = 'A';
        }
        else if (grade >= 80)
        {
            letter = 'B';
        }
        else if (grade >= 70)
        {
            letter = 'C';
        }
        else if (grade >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"You have a {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("You passed! Great job.");
        }
        else
        {
            Console.WriteLine("You failed! Try harder next time.");
        }
    }
}