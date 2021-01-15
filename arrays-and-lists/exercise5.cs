using System;
using System.Collections.Generic;

namespace FiveSortedNumbersYey
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            var smallest = new int[3] { 99, 99, 99 };

            while (true)
            {
                System.Console.WriteLine("Please, enter a list of comma separated numbers.");
                var input = Console.ReadLine();
                var numbers = input.Split(',');

                for (var i = 0; i < numbers.Length; i++)
                {
                    var n = Convert.ToInt32(numbers[i]);
                    numberList.Add(n);
                }

                if (numberList.Count < 5)
                    System.Console.WriteLine("Invalid list. You'll be asked to try again.");
                else
                    break;
            }

            for (var i = 0; i < numberList.Count; i++)
            {
                for (var s = 0; s < smallest.Length; s++)
                {
                    if (numberList[i] < smallest[s])
                    {
                        smallest[s] = numberList[i];
                        break;
                    }
                }
            }

            System.Console.WriteLine("The following are the 3 smallest numbers in the entered list...");
            foreach (var s in smallest)
                System.Console.WriteLine(s + " ");
        }
    }
}
