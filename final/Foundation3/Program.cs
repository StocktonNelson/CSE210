<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;

>>>>>>> 5277a171350f88043046bed27dcf6721aae17511
class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        List<Event> events = new List<Event>();

        Event lectuer = new Lectuer("Ted talk", "a speech about why java is better then c#", "6月 29日 2026年", "9pm", "525 S Center St Rexburg, ID 83460", "Stockton S. Nelson", 220);
        Event outdoor = new Outdoor("Anti-Arson", "An outdoor event to spread awareness of wild fire", "29 de junio de 2026", "21:00", "-77.87445298630027, -34.63252714246088", "A bit chilly weather with 1% of snow");
        Event Reception = new Reception("Wedding", "I think someone is getting married but don't know", "29 Juni 2026", "00:00", "-53.09904765395786, 73.48369330340786", new List<string> { "byui@byui.com", "urMom@yahoo.com", "qwertyuiopasdfghjklzxcvbnm@wiki.org" });

        events.Add(lectuer);
        events.Add(outdoor);
        events.Add(Reception);

        //* event is a keyword so i added "_"
        foreach(Event _event in events){
            Console.WriteLine("-----------------short------------");
            _event.GetShortInfo();
            Console.WriteLine("---------------standerd-------------");
            _event.GetStanderedInfo();
            Console.WriteLine("--------------------long----------------");
            _event.GetLongInfo();
        }
=======
        // Create a Lecture event
        Lectuer techTalk = new Lectuer(
            "Modern AI Applications", 
            "Learn about the latest developments in artificial intelligence", 
            "April 15, 2025", 
            "18:00", 
            "123 Tech Boulevard, Silicon Valley, CA", 
            "Dr. Jane Smith", 
            150);

        // Create a Reception event
        List<string> rsvpList = new List<string>() {
            "john.doe@example.com",
            "jane.smith@example.com",
            "robert.jones@example.com"
        };
        Reception networkingEvent = new Reception(
            "Industry Networking Mixer", 
            "Connect with professionals in your field", 
            "May 10, 2025", 
            "19:30", 
            "Grand Hotel, 456 Main Street, New York, NY", 
            rsvpList);

        // Create an Outdoor event
        Outdoor communityPicnic = new Outdoor(
            "Community Summer Picnic", 
            "Join us for food, games, and fun for the whole family", 
            "June 5, 2025", 
            "12:00", 
            "Central Park, 789 Park Avenue, Chicago, IL", 
            "Sunny with a high of 78°F");

        // Display information for all events
        Console.WriteLine("=== LECTURE EVENT ===");
        Console.WriteLine("\n--- Standard Details ---");
        techTalk.GetStanderedInfo();
        Console.WriteLine("\n--- Full Details ---");
        techTalk.GetLongInfo();
        Console.WriteLine("\n--- Short Description ---");
        techTalk.GetShortInfo();

        Console.WriteLine("\n\n=== RECEPTION EVENT ===");
        Console.WriteLine("\n--- Standard Details ---");
        networkingEvent.GetStanderedInfo();
        Console.WriteLine("\n--- Full Details ---");
        networkingEvent.GetLongInfo();
        Console.WriteLine("\n--- Short Description ---");
        networkingEvent.GetShortInfo();

        Console.WriteLine("\n\n=== OUTDOOR EVENT ===");
        Console.WriteLine("\n--- Standard Details ---");
        communityPicnic.GetStanderedInfo();
        Console.WriteLine("\n--- Full Details ---");
        communityPicnic.GetLongInfo();
        Console.WriteLine("\n--- Short Description ---");
        communityPicnic.GetShortInfo();
>>>>>>> 5277a171350f88043046bed27dcf6721aae17511
    }
}