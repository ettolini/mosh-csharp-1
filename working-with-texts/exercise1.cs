using System;
using System.Text;

namespace ConsecoctTo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter a list of numbers separated by a hyphen.");
            var input = Console.ReadLine();   
            var list = input.Split('-');
            var numbers = new StringBuilder();

            foreach (var l in list)
            {
                numbers.Append(l);
            }

            if (numbers[0] + 1 == numbers[1])
                System.Console.WriteLine(IncreasingPatron(numbers)); 
            else
                if (numbers[0] - 1 == numbers[1])
                    System.Console.WriteLine(DecreasingPatron(numbers)); 
            else
                System.Console.WriteLine("Not consecutive.");
        }

        static string IncreasingPatron(StringBuilder numbers)
        {
            for (var i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] + 1 != numbers[i + 1])
                    return "Not consecutive.";
            }
            return "Consecutive";
        }
        static string DecreasingPatron(StringBuilder numbers)
        {
            for (var i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] - 1 != numbers[i + 1])
                    return "Not consecutive.";
            }
            return "Consecutive";
        }
    }
}
