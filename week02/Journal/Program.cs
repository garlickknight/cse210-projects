using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        journalPrompt journalPrompt = new journalPrompt();
        journalPrompt._questions.Add("How did you see the hand of God today?");
        journalPrompt._questions.Add("What was the highlight of your day?");
        journalPrompt._questions.Add("What was your most meaninful interaction?");
        journalPrompt._questions.Add("What was your strongest mood? Why did you feel this way?");
        journalPrompt._questions.Add("What was worth remembering today?");
        Console.WriteLine($"{journalPrompt._questions[0]}");
        int choice = 0;
        do
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display Journal entry");
            Console.WriteLine("3.Save entry to a file");
            Console.WriteLine("4.load the Journal");
            Console.WriteLine("5.Quit");
            string userPrompt = Console.ReadLine();
            choice = int.Parse(userPrompt); 
            if (choice = 1)
            {
                var random = new random();
                in index = random.Next(journalPrompt.Count)
                console.WriteLine($"{journalPrompt}")
            }
        } while (choice <= 4);

    }
}