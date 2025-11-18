using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry(date, randomPrompt, response);

                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry Saved!");

                    break;

                case "2":
                    myJournal.DisplayAll();

                    break;

                case "3":
                    Console.Write("What is the filename (e.g., journal.txt)? ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);

                    break;

                case "4":
                    Console.Write("What is the filename (e.g., journal.txt)? ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);

                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");

                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    
                    break;
            }
        }
    }
}