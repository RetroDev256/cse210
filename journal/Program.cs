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
                    Console.WriteLine("What is the date for the entry?");
                    string date = Console.ReadLine()!;
                    string question = Picker.getRandom();
                    Console.WriteLine(question);
                    string answer = Console.ReadLine()!;
                    Entry entry = new Entry(date, question, answer);
                    journal.addEntry(entry);
                    Console.WriteLine("Entry saved.");
                    break;

                case "2":
                    Console.WriteLine("Here are the current journal entries:");
                    string entries = journal.getEntries();
                    Console.WriteLine(entries);
                    break;

                case "3":
                    Console.Write("Enter the path to load from: ");
                    string load_path = Console.ReadLine()!;
                    journal.loadEntries(load_path);
                    Console.WriteLine("Journal Loaded.");
                    break;

                case "4":
                    Console.Write("Enter the path to save to: ");
                    string save_path = Console.ReadLine()!;
                    journal.saveEntries(save_path);
                    Console.WriteLine("Journal Saved.");
                    break;

                case "5":
                    running = false;
                    break;
            }
        }
    }
}