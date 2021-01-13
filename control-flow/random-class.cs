using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();  // We declare the Random Object
            const int randomLength = 10;    // We declare a constant to manage our iterations' loops

            // 10 random integer numbers from 1 to 10

            for (var i = 0; i < randomLength; i++)
                System.Console.WriteLine(random.Next(1, randomLength));

            // 10 random lower-case characters from the alphabet

            var buffer = new char[randomLength]; // Array of characters.
            for (var i = 0; i < randomLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));   // If we add a number to a char, it returns an ASCII value.
                                                                // Another letter from the alphabet, in this case. Since there are 26 of them.
            var password = new string(buffer);  // If we send an array of chars to the String Constructor, we get a String made of those chars.
            System.Console.WriteLine(password);
        }
    }
}
