using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var mysteriousNumber = random.Next(1, 10);
            // System.Console.WriteLine(mysteriousNumber); This was to check if it was working 
            var tries = 4;
            var guessed = false;

            System.Console.WriteLine("Guess the mysterious number, it's between 1 and 10...");
            var input = Console.ReadLine();

            while (tries > 0 && !guessed)
            {
                tries--;
                if (Convert.ToInt32(input) == mysteriousNumber)
                    guessed = true;
                else
                    if (tries > 0)
                        input = Console.ReadLine();
            }

            if (guessed)
                System.Console.WriteLine("You won!");
            else
                System.Console.WriteLine("You lost!");
        }
    }
}