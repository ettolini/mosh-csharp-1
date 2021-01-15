using System;

namespace DemoStringsLingis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trimming a string

            var fullName = "Mosh Hamedani ";    // Notice the ' ' at the end of the string
            System.Console.WriteLine("Trim: '{0}'", fullName.Trim());   // The Trim Method takes care of that, it returns "Mosh Hamedani"
            System.Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());  // "MOSH HAMEDANI"

            // Getting individual names out a fullName string (not the best)

            var index = fullName.IndexOf(' ');  // index now holds the index number where the first ' ' is located in the fullName string
            var firstName = fullName.Substring(0, index);   // Since that ' ' separates the first name from the last name, we can get the first
                                                            // name using the Substring Method from the beginning of the string up to that point
            var lastName = fullName.Substring(index + 1);   // And we can get the last name by getting every character from the index next to
                                                            // the saved one up to the end of the string
            System.Console.WriteLine("FirstName: " + firstName);
            System.Console.WriteLine("LastName: " + lastName);

            // A better way to get the same results

            var names = fullName.Split(' ');    // We could use the Split Method to obtain an array of substrings, separating them based on ' '
            System.Console.WriteLine("FirstName: " + names[0]); // "Mosh"
            System.Console.WriteLine("LastName: " + names[1]);  // "Hamedani"

            // Replacing substrings in a string

            System.Console.WriteLine(fullName.Replace("Mosh", "Moshfegh")); // "Moshfegh Hamedani "
            
            // Checking whether the input is valid or not

            if (String.IsNullOrEmpty(" ".Trim()))       // The IsNullOrEmpty Method only works with null or empty string values
                System.Console.WriteLine("Invalid.");   // You could make it work with white-spaces by trimming the string aswell
            if (String.IsNullOrWhiteSpace(" "))         // To fix that, the IsNullOrWhiteSpace Method was created
                System.Console.WriteLine("Invalid.");   // This method works with those three previously mentioned cases, all by itself
        
            // Converting strings into numbers, and vice versa

            var str = "25";
            var age = Convert.ToByte(str);  // Converts it to byte because we don't need that much numbers to store a person's age
            
            float price = 29.95f;
            price.ToString("C0");   // Turns the float number into a string, with the currency format, but getting rid of the decimals
                                    // It rounds the result, so instead of getting $29, we get $30
        }
    }
}
