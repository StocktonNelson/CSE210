public class Activities
{
    private int _time; // this time would be use by the user and not effect count down.

    private static int _logCount; //count how many time the user has use any activies 
    
    public void CloseMessage(string activityName)
    {
        // TODO
        Console.WriteLine($"you did this {activityName} activty for {_time} secondes");
        _logCount++;
        Console.WriteLine($"you have done {_logCount} activies for this session so far");
    }
    
    // I did this so i can override the openMessage that we can have diffrent messages for each class with same method name.
    public virtual void OpenMessage()
    {
        // TODO
        Console.WriteLine($"Welcome to the Activity");
    }
    
    //* my idea for this use it for basic count down but not use for breathing becaseu it would make it to complex to understand. like begin or ending of the activity.
    public void Countdown(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        string[] spinnerStrings = { "|", "/", "-", "\\" };
        int i = 0;
        DateTime currentTime = DateTime.Now;
        
        while (currentTime < endTime)
        {
            Console.Write(spinnerStrings[i % 4]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
            i++;
        }
    }

    public void setTime(int time) {
        _time = time;
    }

    public int getTime() {
        return _time;
    }
}