using System;
using System.Text; // Don't forget to add this one when using StringBuilders...

namespace StringoBuildoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World"); // It's not necessary to send an argument, but if you do, those will be your new
                                                            // stringbuilder's characters
            builder // These methods return a StringBuilder Object, which allows us to chain them...
                .Append('-', 10)                          // Adds the given character, a given number of times, at the end of the string  
                .AppendLine()                             // Adds a line to the string
                .Append("Header")                         // Adds the given string
                .Replace('-', '+')                        // Replaces the first element (if found in the string) for the second one
                .Remove(0, 11)                            // Removes characters starting from the given index (0), a given number of times (11)
                .Insert(0, new string("I'm here!"));      // Inserts, starting from the given index, the given string/character

            // These methods for manipulating string are more efficient than those of regular strings, since they don't create a duplicate
            // of the original string when they're used

            System.Console.WriteLine(builder[0]);   // You can access a StringBuilder's character too!
        }
    }
}
