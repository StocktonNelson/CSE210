using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            string choice;
            string prompt;
            string response;
            string filename;

            Console.WriteLine("\nPlease select one of the following choices"); // split from last loop make it look better
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load with Current Prompts (not sorted)");
            Console.WriteLine("6. Quit");

            Console.Write("What do you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("");
                response = Console.ReadLine();
                journal.AddEntry(prompt, response, DateTime.Today);
                
            }

            else if (choice == "2")
            {
                journal.DisplayEntries();
            }

            else if (choice == "3")
            {
                Console.Write("Enter file Name: ");
                filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (choice == "4")
            {
                Console.Write("Enter file Name: ");
                filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (choice == "5")
            {
                Console.Write("Enter file Name: ");
                filename = Console.ReadLine();
                journal.LoadFromFileAndKeepEntries(filename);
            }

            else if (choice == "6")
            {
                Console.WriteLine("Quitting the program.");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}