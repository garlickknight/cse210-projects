using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbersList = new List<int>();
        int number = 0;
        string numberPrompt = "";
        do
        {
            Console.WriteLine("Enter Number  (0 to quit):");
            numberPrompt = Console.ReadLine();
            number = int.Parse(numberPrompt);
            if (number != 0)
            {
                numbersList.Add(number);
            }
        }while (number != 0);
        float sum = numbersList.Sum();
        float count = numbersList.Count();
        float average = sum / count;
        float largest = numbersList.Max();
        Console.WriteLine($"The sum of the list is: {sum}");
        Console.WriteLine($"The average of the the list is: {average}");
        Console.WriteLine($"The largest number in the list is: {largest}");
    

    }
}
