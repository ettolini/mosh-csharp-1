using System;

namespace primitives
{
    class Program
    {
        static void Main(string[] args)
        {
            // The curly braces {} are placeholders, awaiting to receive its arguments
            // The 0 represents the first argument sent to the Console.WriteLine (next to the placeholders), and 1 represents the second
            // The MinValue Method returns the data type's lowest possible value, and MaxValue returns the greatest one
            System.Console.WriteLine("The byte data type ranges from {0} to {1}", byte.MinValue, byte.MaxValue);
            System.Console.WriteLine("The float data type ranges from {0} to {1}", float.MinValue, float.MaxValue);
        }
    }
}
