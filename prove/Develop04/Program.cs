using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Menu input
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            // Quit the program
            if (option == "4") break;

            // Report invalid input
            if (option != "1" && option != "2" && option != "3")
            {
                Console.WriteLine("Invalid Option. Try again.");
                continue;
            }

            // Input duration
            Console.Write("Enter the activity duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());

            // Run each activity
            switch (option)
            {
                case "1":
                    Breathing breathing = new Breathing(duration);
                    breathing.RunBreathing();
                    break;
                case "2":
                    Reflecting reflecting = new Reflecting(duration);
                    reflecting.RunReflecting();
                    break;
                case "3":
                    Listing listing = new Listing(duration);
                    listing.RunListing();
                    break;
                default:
                    // We check beforehand that this won't ever be reached
                    throw new UnreachableException();
            }
        }
    }
}