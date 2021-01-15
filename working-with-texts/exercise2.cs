using System;

namespace demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter a list of numbers separated by a hyphen.");
            string input = Console.ReadLine();   

            System.Console.WriteLine(SearchDuplicate(input));
        }

        public static string SearchDuplicate(string input)
        {
            if (!String.IsNullOrWhiteSpace(input))
            {
                string[] list = input.Split('-');
                Array.Sort(list);
                for (int i = 1; i < list.Length; i++)
                {
                    if (list[i] == list[i - 1])
                        return "Duplicate";
                }
                return "Nothing found.";
            }
            return "Nothing was entered.";
        }
    }
}
