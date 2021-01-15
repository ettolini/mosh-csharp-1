using System;

namespace demo52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            System.Console.WriteLine(TimeValidation(input));
            
        }

        public static string TimeValidation(string input)
        {
            if (!String.IsNullOrWhiteSpace(input))
            {
                var components = input.Split(':');
                if (components.Length == 2)
                {
                    try
                    {
                        var hour = Convert.ToInt32(components[0]);
                        var minute = Convert.ToInt32(components[1]);

                        if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                            return "Ok.";
                    }
                    catch (Exception)
                    {
                        return "Invalid Time.";
                    }
                }
            }
            return "Invalid Time.";
        }
    }
}
