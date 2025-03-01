public class Breathing : Activities
{
    
    public override void OpenMessage()
    {
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        
    }

    public void StartActivity()
    {
        Console.Write("How long, in seconds, would you like for your session?");
        base.setTime(int.Parse(Console.ReadLine()));

        Console.Clear();

        Console.WriteLine("Get Ready...");
        base.Countdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.getTime());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(); // here for spacing

            // we loop the it and add a second delay to make user think it took a second.
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"\rBreathe in... {i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();

            for (int i = 5; i > 0; i--)
            {
                Console.Write($"\rBreathe out... {i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        base.Countdown(5);

        base.CloseMessage("Breathing");
    }
}