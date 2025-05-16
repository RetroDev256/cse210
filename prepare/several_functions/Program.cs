class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int fav_number = PromptUserNumber();
        int square_num = SquareNumber(fav_number);
        DisplayResult(username, square_num);
    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        while (true)
        {
            string? input = Console.ReadLine();
            if (input != null)
                if (input.Length != 0)
                    return input;
            Console.Write("Invalid input. Try again: ");
        }
    }

    // Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int parsed))
                return parsed;
            Console.Write("Invalid input. Try again: ");
        }
    }

    // Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int input)
    {
        return input * input;
    }

    // Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string username, int square_num)
    {
        Console.WriteLine($"{username}, the square of your number is {square_num}");
    }
}

