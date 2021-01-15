using System;

namespace demoEnglish
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter an ENGLISH word...");
            string input = Console.ReadLine().ToLower();    // That way upper-cases aren't excluded
            
            System.Console.WriteLine("The amount of vowels that you entered was: " + TotalVowels(input));
        }

        public static int TotalVowels(string input)
        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            int total = 0;

            if (String.IsNullOrWhiteSpace(input))
                return total;
            foreach (var i in input)
            {
                if (Array.IndexOf(vowels, i) != -1)
                    total++;
            }

            return total;
        }
    }
}
