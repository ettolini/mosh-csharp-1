using System;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter a number between 1 to 10.");
            var input = Console.ReadLine(); // ReadLine allows the user to input data
            var number = Convert.ToInt32(input); // Everything inputted is received as a string, and, in this case, we need an int

            if (number >= 1 && number <= 10)
                System.Console.WriteLine("Valid.");
            else
                System.Console.WriteLine("Invalid.");
        }
    }
}
