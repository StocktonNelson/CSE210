using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        int magic_number;
        bool gussed = false;
        int user_number;
        int gussed_count = 0;

        Console.Write("What is the magic number? ");
        magic_number = int.Parse(Console.ReadLine());
        

        while (!gussed)
        {
            Console.Write("What is your guess? ");
            user_number = int.Parse(Console.ReadLine());

            if (user_number == magic_number)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine("It took you " + gussed_count);
                Console.Write("Want to play again? ");
                if (Console.ReadLine() == "yes")
                {
                    Console.Write("What is the magic number? ");
                    magic_number = int.Parse(Console.ReadLine());
                    gussed_count = 0;
                    continue;
                }
                gussed = true;
            }
            else if (user_number < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (user_number > magic_number)
            {
                Console.WriteLine("Lower");
            }

            gussed_count++;
        }
        Console.WriteLine("Goodbye!");
    }
}