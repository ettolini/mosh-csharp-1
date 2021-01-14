using System;

namespace DateTimeBro // DateTime Objects are immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(1999, 3, 24); // Gets given date, the hour is set to default (00:00:00)
            var now = DateTime.Now; // Gets the current time (when executed)
            var today = DateTime.Today; // Gets the current time, but only the date, hours are set to default
            var tomorrow = now.AddDays(1); // Adds a day, so it displays tomorrow's date at the current hour
            var yesterday = now.AddDays(-1); // Subtracts a day, so it displays yesterday's date at the current hour

            System.Console.WriteLine("Hour: " + now.Hour);
            System.Console.WriteLine("Day of the week: " + now.DayOfWeek);

            System.Console.WriteLine(now);
            // For example: 23/5/2015 14:46:19
            System.Console.WriteLine(now.ToLongDateString());
            // For example: Saturday, 23 May 2015
            System.Console.WriteLine(now.ToShortDateString());
            // For example: 23/05/2015
            System.Console.WriteLine(now.ToLongTimeString());
            // For example: 14:46:19 PM
            System.Console.WriteLine(now.ToShortTimeString());
            // For example: 14:46 PM
            System.Console.WriteLine(now.ToString("yyyy-MM-dd"));
            // For example: 2015-05-23
            // There are multiple ToString DateTime Specifiers, you can look them up on Google
        }
    }
}
