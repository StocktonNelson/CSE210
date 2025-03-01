using System;

class Program
{
    static void Main(string[] args)
    {
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Listing");
        Console.WriteLine("3. Reflection");
        Console.WriteLine("4. Quit");
        Console.Write("Enter your choice: ");
        
        string choice = Console.ReadLine();

        switch (choice)
        {
        case "1":
            Breathing breathing = new Breathing();
            breathing.OpenMessage();
            breathing.StartActivity();
            break;
        case "2":
            Listing listing = new Listing();
            listing.OpenMessage();
            listing.StartActivity();
            break;
        case "3":
            Reflection reflection = new Reflection();
            reflection.OpenMessage();
            reflection.StartActivity();
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
        }

        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }
    }
}