using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
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
    }
}