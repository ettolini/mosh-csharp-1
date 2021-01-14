using System;
using System.Collections.Generic;

namespace FiveSortedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("You're going to be asked to enter 5 different numbers.");
            var numbers = new int[5];

            for (var i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Please, enter a number.");
                var input = Console.ReadLine();
                var number = Convert.ToInt32(input);
                if (Array.IndexOf(numbers, number) == -1)
                    numbers[i] = number;
                else
                {
                    System.Console.WriteLine("You have entered a repeated number.");
                    i--;
                    continue;
                }
            }

            Array.Sort(numbers);
            System.Console.WriteLine("The following is a sorted list of the entered numbers...");
            foreach (var n in numbers)
                System.Console.Write(n + " ");
        }
    }
}
