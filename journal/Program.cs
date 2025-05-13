// This "class" runs the UI

class Program
{
    public static void Main()
    {
        Journal journal = new Journal();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a journal entry");
            Console.WriteLine("2. List the current entries");
            Console.WriteLine("3. Load journal entries from a file");
            Console.WriteLine("4. Save journal entries to a file");
            Console.WriteLine("5. Exit the program");

            string selection = Console.ReadLine()!;
            switch (selection)
            {
                case "1":
                    Console.WriteLine("\nWhat is the date for the entry?");
                    string date = Console.ReadLine()!;
                    string question = Picker.GetRandom();
                    Console.WriteLine(question);
                    string answer = Console.ReadLine()!;
                    Entry entry = new Entry(date, question, answer);
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry saved.\n");
                    break;

                case "2":
                    Console.WriteLine("\nHere are the current journal entries:");
                    string entries = journal.GetEntries();
                    Console.WriteLine(entries);
                    break;

                case "3":
                    Console.Write("\nEnter the path to load from: ");
                    string load_path = Console.ReadLine()!;
                    journal.LoadEntries(load_path);
                    Console.WriteLine("Journal Loaded.\n");
                    break;

                case "4":
                    Console.Write("\nEnter the path to save to: ");
                    string save_path = Console.ReadLine()!;
                    journal.SaveEntries(save_path);
                    Console.WriteLine("Journal Saved.\n");
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid input. Please try again.\n");
                    break;
            }
        }
    }
}