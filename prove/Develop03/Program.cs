using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference reference = new Reference("3 Nephi", 21, 1, 2);
        Scripture scripture = new Scripture(reference, "And verily I say unto you, I give unto you a sign, that ye may know the time when these things shall be about to take place—that I shall gather in, from their long dispersion, my people, O house of Israel, and shall establish again among them my Zion; And behold, this is the thing which I will give unto you for a sign—for verily I say unto you that when these things which I declare unto you, and which I shall declare unto you hereafter of myself, and by the power of the Holy Ghost which shall be given unto you of the Father, shall be made known unto the Gentiles that they may know concerning this people who are a remnant of the house of Jacob, and concerning this my people who shall be scattered by them;");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine($"{reference.GetFormattedReference()} {scripture.GetRenderedText()}");
            Console.WriteLine("\nPress Enter to continue, \"show\" to show, or type 'quit' to exit:");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "show")
            {
                scripture.Show();
                continue;
            }
            else if (input.ToLower() == "quit")
            {
                break;
            }
                
            scripture.HideWords();
        }
    }
}