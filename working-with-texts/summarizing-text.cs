using System;
using System.Collections.Generic;

namespace SumarrixingTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long text.";
            var summary = SummarizeText(sentence, 25);
            System.Console.WriteLine(summary);
        }

        // SummarizeText is declared as static so it can be used inside Program, because it's also declared as static
        // The assigned value to maxLength's parameter is so it has a default value, in case no parameter is given by the user
        static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                return String.Join(' ', summaryWords) + "...";
        }
    }
}
