using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("");
        // Console.WriteLine("What is the magic number?");
        // string magic_number_prompt = Console.ReadLine();
        // int magic_number = int.Parse(magic_number_prompt);
        Random randomNumber = new Random ();
        int magic_number = randomNumber.Next(0,100);
        Console.WriteLine("What do you believe the magic number is?");
        string guess_prompt = Console.ReadLine();
        int guess = int.Parse(guess_prompt);
        while (guess != magic_number)
        {
            if (guess > magic_number)
            {
                Console.Write("Your guess was greater than the magic number :()");
                Console.WriteLine("");
                Console.WriteLine("Please guess again:");
                guess_prompt = Console.ReadLine();
                guess = int.Parse(guess_prompt);
                
            }
            else if  (guess < magic_number)
            {
                Console.Write("Your guess was less than the magic number :()");
                Console.WriteLine("");
                Console.WriteLine("Please guess again:");
                guess_prompt = Console.ReadLine();
                guess = int.Parse(guess_prompt);
            }
        }
        if (guess == magic_number)
        {
            Console.WriteLine("Great! You did it. That is the magic number :)");
        }


    }
}