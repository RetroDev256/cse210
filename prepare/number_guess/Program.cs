class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();

        // Play games as long as the user desires
        while (true)
        {
            // Uniform int in range [1, 100]
            int target = 1 + rng.Next(100);

            Console.WriteLine("Guess a number from 1 to 100!\n");

            // Stretch Challenge #1
            int guesses = 0;

            // Loop until the user guesses the number
            while (true)
            {
                guesses += 1;

                Console.Write("What is your guess? ");
                int guess = readInt();

                if (guess > target)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < target)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guesses} guesses!");
                    break;
                }
            }

            // Exit when the user desires - Stretch challenge #2
            Console.Write("\nDo you wish to play again? ([Y]es/[N]o): ");
            if (!readBool()) break;
            Console.WriteLine();
        }
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

    // Query the user for a boolean yes/no, repeating on invalid input
    static bool readBool()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (input != null)
            {
                switch (input.ToLower())
                {
                    case "yes":
                    case "y":
                        return true;
                    case "no":
                    case "n":
                        return false;
                }
            }
            Console.Write("Invalid input. Try again: ");
        }
    }
}

