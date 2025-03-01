using System.Diagnostics.CodeAnalysis;

public class Listing : Activities
{
    private List<string> _prompts;

    private int responseCount;

    Random rand = new Random();

    public Listing()
    {
        _prompts = new List<string>
        {
            "List all the things you are grateful for.",
            "List all the people who have positively impacted your life.",
            "List all the achievements you are proud of.",
            "List all the skills you have acquired.",
            "List all the places you want to visit."
        };
    }
    public override void OpenMessage()
    {
        // TODO
        Console.WriteLine("Welcome to the Listing Activity.\n");

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many thing s as you can in a certain area.\n");

    }

    public void DisplayResponses()
    {
        // TODO

    }

    public void StartActivity()
    {
        // TODO
        Console.Write("How long, in seconds, would you like for your session?");
        base.setTime(int.Parse(Console.ReadLine()));

        Console.Clear();

        Console.WriteLine("Get Ready...");
        base.Countdown(5);

        Console.WriteLine($"\n--- {_prompts[rand.Next(_prompts.Count)]} ---\n");

        for (int i = 5; i > 0; i--)
        {
            Console.Write($"\rYou may start in...{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine(); // here for spacing

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.getTime());

        //Todo make loop of two question

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            responseCount++;
        }
        Console.WriteLine();

        Console.WriteLine($"Well Done!! You have write {responseCount} response.");
        base.Countdown(5);

        base.CloseMessage("Reflection");

    }
}