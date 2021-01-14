using System;
using System.Collections.Generic;

namespace UniqueNumbersList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                System.Console.WriteLine("Please, enter a number. Or type 'Quit' to exit.");
                var input = Console.ReadLine();
                if (input == "Quit")
                    break;
                
                var number = Convert.ToInt32(input);
                numbers.Add(number);
            }

            System.Console.WriteLine("The following is a list of the unique numbers that were entered...");
            var uniqueNumbers = new List<int>();
            for (var i = 0; i < numbers.Count; i++)
            {
                var n = numbers[i];
                if (uniqueNumbers.IndexOf(n) == -1)
                {
                    uniqueNumbers.Add(n);
                    System.Console.Write(n + " ");
                }
            }
        }
    }
}
