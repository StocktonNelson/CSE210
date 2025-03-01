public class Reflection : Activities
{
    private List<string> _prompts;
    private List<string> _questions;

    Random rand = new Random();

    public Reflection()
    {
        _prompts = new List<string>
        {
            "Think of a time when you felt truly at peace.",
            "Recall a moment when you accomplished something significant.",
            "Remember a time when you helped someone in need."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel during this experience?",
            "What did you learn from this experience?",
            "How can you apply what you learned to your daily life?"
        };
    }
    
    public override void OpenMessage()
    {
        // TODO
        Console.WriteLine("Welcome to the Reflection Activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        
    }
    public string RandomQuestion()
    {
        return _questions[rand.Next(_questions.Count)];
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

        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.getTime());

        Console.Clear();

        //Todo make loop of two question

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"{RandomQuestion()}");
            base.Countdown(base.getTime()/2);
            Console.WriteLine();
        }

        Console.WriteLine("Well Done!!");
        base.Countdown(5);

        base.CloseMessage("Reflection");
    }

}