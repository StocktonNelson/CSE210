using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        string class_pass = "";
        string class_grade = "";
        Console.Write("what is your grade in this class? ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            class_pass = "true";
            class_grade = "A";
        }

        else if (grade >= 80)
        {
            class_pass = "true";
            class_grade = "B";
        }

        else if (grade >= 70)
        {
            class_pass = "true";
            class_grade = "C";
        }

        else if (grade >= 60)
        {
            class_pass = "false";
            class_grade = "D";
        }

        else
        {
            class_pass = "false";
            class_grade = "F";
        }

        if (class_pass == "true")
        {
            Console.WriteLine("You pass the class with a(n) " + class_grade);
        }

        else
        {
            Console.WriteLine("You failed the class with a(n) " + class_grade);
        }

    }
}