using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        List<Job> jobs = new List<Job>();
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";

        job1._company = "Microsoft";

        job1._startYear = 2019;

        job1._endYear = 2022;

        Job job2 = new Job();

        job2._jobTitle = "Manager";

        job2._company = "Apple";

        job2._startYear = 2022;

        job2._endYear = 2023;

        Resume resume1 = new Resume();

        resume1._name = "Stockton";

        jobs.Add(job1);
        jobs.Add(job2);

        resume1._jobs = jobs;

        resume1.Display();
    }
}