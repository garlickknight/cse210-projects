using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage?");
        string user_grade = Console.ReadLine();
        int grade = int.Parse(user_grade);
        string letter_grade = "";
        if (grade >= 90)
        {
            letter_grade="A";
        }
        else if (grade >= 80)
        {
            letter_grade="B";
        }
        else if (grade >=70)
        {
            letter_grade="C";
        }
        else if (grade >= 60)
        {
            letter_grade="D";
            
        }
        else
        {
            letter_grade="F";
            
        }
        if (grade >=70)
        {
            Console.WriteLine("CONGRATS! You Passed!");
        }
        else
        {
            Console.WriteLine("Im Sorry! You Failed :( Better luck next time! With some more work i'm sure you will be able to pass next time!)");
        }
        Console.WriteLine($"your grade was: {letter_grade}");

    }
}