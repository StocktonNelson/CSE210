using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World! :O");
        int sum_number = 0;
        int average_number = 0;
        int largest_number = int.MinValue;
        int smallest_number = int.MaxValue;
        int gussed_number = 0;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        while (true)
        {
            Console.Write("Enter number: ");
            gussed_number = int.Parse(Console.ReadLine());
            if (gussed_number == 0)
            {
                break;
            }
            else
            {
                numbers.Add(gussed_number);
            }

        }

        for (int i = 0; i < numbers.Count; i++)
        {
            sum_number += numbers[i];

            if (numbers[i] > largest_number)
            {
                largest_number = numbers[i];
            }

            if (numbers[i] > 0 && smallest_number > numbers[i])
            {
                smallest_number = numbers[i];
            }


        }
        average_number = sum_number / numbers.Count;

        Console.WriteLine("The sum is: " + sum_number);
        Console.WriteLine("The average is: " + average_number);
        Console.WriteLine("The largest number is: " + largest_number);
        Console.WriteLine("The smallest positive number is: " + smallest_number);
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}