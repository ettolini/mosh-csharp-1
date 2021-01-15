using System;
using System.Text;

namespace ImSoProud
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter a few words.");
            string input = Console.ReadLine();

            System.Console.WriteLine(PascalCase(input));
        }

        public static StringBuilder PascalCase(string input)
        {
            string[] words = input.ToLower().Split(' ');
            var newWords = new StringBuilder();

            foreach (string word in words)
            {
                var index = newWords.Length;
                newWords.Append(word + ' ');
                newWords[index] = Char.ToUpper(word[0]);
            }

            return newWords;
        }
    }
}
