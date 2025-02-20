using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        MathAssigment math = new MathAssigment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetHomeworkList());

        WritingAssigment writing = new WritingAssigment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetWritingInformation());
    }
}