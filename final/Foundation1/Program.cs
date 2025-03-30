using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

                List<Comment> comments1 = new List<Comment>
        {
            new Comment("user123", "Great explanation of the topic!"),
            new Comment("techEnthusiast", "I learned so much from this video"),
            new Comment("newViewer", "First time watching your content, definitely subscribing"),
            new Comment("codeMaster", "Could you make a follow-up video on advanced techniques?")
        };

        // Create comments for second video
        List<Comment> comments2 = new List<Comment>
        {
            new Comment("musicFan42", "The sound quality is amazing!"),
            new Comment("videoEditor", "What software did you use for the editing?"),
            new Comment("casual_viewer", "Watching this for the third time, still awesome"),
            new Comment("techGuru", "Have you considered covering the latest update?")
        };

        // Create comments for third video
        List<Comment> comments3 = new List<Comment>
        {
            new Comment("gamingPro", "This tutorial saved me hours of frustration"),
            new Comment("newLearner", "Could you explain the middle section again?"),
            new Comment("longTimeFan", "Been following since your first video, great progress!"),
            new Comment("industryExpert", "Very accurate information, well researched")
        };

        // Create comments for fourth video
        List<Comment> comments4 = new List<Comment>
        {
            new Comment("dailyWatcher", "I wait for your videos every week!"),
            new Comment("curious_mind", "How long did it take you to master this skill?"),
            new Comment("student101", "Using this for my school project, thanks!"),
            new Comment("professionalDev", "Your explanations are always so clear and concise")
        };

        // Create four video objects
        Video video1 = new Video("TechTutorials", "Beginner's Guide to Programming", 600, comments1);
        Video video2 = new Video("MusicProduction", "Mixing and Mastering Basics", 720, comments2);
        Video video3 = new Video("GameDevAcademy", "Unity Engine Fundamentals", 900, comments3);
        Video video4 = new Video("DesignMasters", "UI/UX Principles for Apps", 540, comments4);

        // Create a list of videos
        List<Video> videos = new List<Video>{ video1, video2, video3, video4};

        // Display information for each video
        Console.WriteLine("YouTube Video Information:\n");
        foreach (Video video in videos)
        {
            video.GetVideoInfo();
            Console.WriteLine("\n--------------------------------------------------\n");
        }
    }
}