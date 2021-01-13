using System;

namespace DemoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            String lastName = "Hamedani"; // Declarating string using the String Class (needs System to be imported)
            var fullName = string.Format("My name is {0} {1}", firstName, lastName);
            
            var myNames = new string[4] {"Ettore", "José", "Bortolin", "Gómez"};
            var myFullName = string.Join(" ", myNames); 
        
            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            var text2 = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            // Remember to keep identation as you would like it to show up in console!!
        }
    }
}