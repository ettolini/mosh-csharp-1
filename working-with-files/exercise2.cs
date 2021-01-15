using System;
using System.IO;
using System.Text;

namespace Esescicisdos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ettor\OneDrive\Escritorio\secret.txt";
            string text = File.ReadAllText(path);
            
            System.Console.WriteLine("This is the longest word inside the text file: " + LongestWord(text));
        }

        public static string LongestWord(string text)
        {
            string[] words = text.Split(' ');
            string longest = words[0];
            
            foreach (var word in words)
            {
                if (longest.Length < word.Length)
                    longest = word;
            }

            return longest;
        }
    }
}
