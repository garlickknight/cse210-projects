
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Resumes
{
    public string memberName = "";

    public List<Job> _jobsList = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{memberName}");
        Console.WriteLine("Jobs:");

        foreach ( Job job in _jobsList)
        {
            job.Display();
        }
    }
}