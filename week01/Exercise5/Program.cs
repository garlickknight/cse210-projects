using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine("Welcome to the program!");
        Console.WriteLine("What is your name?");
        string namePrompt = Console.ReadLine();
        Console.WriteLine("What is your favorite number?");
        string numberPrompt = Console.ReadLine();
        int number = int.Parse(numberPrompt);
        int numberSquared = SquareNumber(number);
        Console.WriteLine($"Hey {namePrompt}! Your number squared is {numberSquared}");
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }
}

