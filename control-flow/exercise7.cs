using System;

namespace demo54252
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter a number.");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            var factorial = number;

            while (number > 1)
            {
                number--;
                factorial *= number;
            }

            System.Console.WriteLine("This is the entered number's factorial: " + factorial);
        }
    }
}
