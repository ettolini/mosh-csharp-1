using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input)) // Empty string = true ; Otherwise = false
                    break; // Terminates the while loop

                System.Console.WriteLine("@Echo: " + input);
            }

            while (true)
            {
                System.Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine("@Echo: " + input);
                    continue;   // When it hits this instruction, instead of going to the next one, it goes back to the iteration
                }               // if (false) -> WriteLine -> continue -> while (instead of break)

                break;
            }
        }
    }
}