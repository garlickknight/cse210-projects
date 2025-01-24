using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.WriteLine("");
        // This is creating the first Job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        // This is creating a second job 
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Programmer";
        job2._startYear = 2022;
        job2._endYear = 2024;
        // This is the resueme 
        Resumes resume = new Resumes();
        resume._jobsList.Add(job1);
        resume._jobsList.Add(job2);
        resume.memberName = "Joseph Garlick";
        resume.Display();
    }
}