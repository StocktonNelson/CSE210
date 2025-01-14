using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "";
        int fav_number = 0;
        int squared_num = 0;

        Console.WriteLine("Hello Prep5 World!");

        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return name = Console.ReadLine();
        }

        int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return fav_number =  int.Parse(Console.ReadLine());
        }

        int SquareNumber()
        {
            return squared_num = fav_number * fav_number;
        }

        void DisplayResult()
        {
            Console.WriteLine( name + ", the square of your number is " + squared_num);
        }

        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        SquareNumber();
        DisplayResult();
    }
}