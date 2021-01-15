using System;
using System.IO;
using System.Text;

namespace Esescicisouno
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ettor\OneDrive\Escritorio\secret.txt";
            string text = File.ReadAllText(path);
            
            System.Console.WriteLine(WordCounter(text));
        }

        public static int WordCounter(string text)
        {
            int total = 0;
            string[] words = text.Split(' ');
            
            foreach (var word in words)
                total++;
            return total;
        }
    }
}