using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        // This code creates the file name in order to store the journal prompts to a file later in the program
        string fileName = "journal";
        // This code is there to read all of the lines in the journal file
        string journalEntry = "";
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
            DateTime currentDate = DateTime.Now;
            // string dateDisplay = currentDate.ToShortDateString();
            if (choice == 1)
            {
                Random prompt = new Random();
                int index = prompt.Next(journalPrompt._questions.Count);
                Console.WriteLine($"{journalPrompt._questions[index]}");
                journalEntry = Console.ReadLine();
            }
            else if (choice == 2)
            {
                // the brackets allow us to access the individual character that make up a string. 
                Console.WriteLine($"What is the name of the file you would like to load?");
                fileName = Console.ReadLine();
                // string[] lines = System.IO.File.ReadAllLines(fileName);
                // foreach (string line in lines)
                // {
                //     string[] parts = line.Split(",");
                //     string firstName = parts[0];
                //     string lastName = parts[1];
                // }
                // Console.WriteLine($"{lines}");
            }
            else if (choice == 3)
            { 
                Console.WriteLine("What is your file name?");
                fileName = Console.ReadLine();
                if (File.Exists(fileName))
                {
                    using(StreamWriter journal = File.AppendText(fileName))
                {
                    journal.WriteLine($"{currentDate.ToString("D")}:3 {journalEntry}");
                }
                }
                else
                {
                    using(StreamWriter entry = new StreamWriter(fileName));
                    using(StreamWriter journal = File.AppendText(fileName))
                {
                    journal.WriteLine($"{currentDate.ToString("D")}: {journalEntry}");
                }
                }
            }
            else if (choice == 4)
            {
                 
            }
        } while (choice <= 4);

    }
}