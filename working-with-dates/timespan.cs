using System;

namespace TimeSpanmyman
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            var timeSpan = new TimeSpan(1, 2, 3); // Hours, minutes, seconds
            // If you wanted to create a TimeSpan with only hours, you could do either...
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1); // But this is more readable, this can be done with more than just hours

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            System.Console.WriteLine("Duration: " + duration); // 00:02:00 000000 -> The last 0s represent miliseconds

            // Properties
            System.Console.WriteLine("Minutes: " + timeSpan.Minutes); // Returns the mins specified in the TimeSpan
            System.Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // Returns the total TimeSpan measured in mins

            // Add
            System.Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // Adds 8 mins to timeSpan's TimeSpan
            System.Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2))); // Subtracts 2 mins from timeSpan's TimeSpan

            // Parse
            System.Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03")); // Returns a TimeSpan Object with the value sent as a string 
        }
    }
}
