using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>();

        //* let just say i got goofy writing the date. I dont think im getting grade on accurty dates, I hope.
        Activity run = new Running("Nov -1 1745", 120, 50);
        Activity cycle = new Cycling("3月 13日 2025年", 133, 12);
        Activity swim = new Swimming("01000001 01110000 01110010 01101001 01101100 00100000 00110100 00100000 00110010 00110000 00110010 00110101", 5, 44);

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        foreach(Activity activity in activities){
            Console.WriteLine(activity.Getsummery());
        }
    }
}