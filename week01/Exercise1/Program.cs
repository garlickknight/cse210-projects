using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("");
        Console.Write("What is your first name?");
        string first_name = Console.ReadLine();
        Console.Write("What is your Last name?");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}