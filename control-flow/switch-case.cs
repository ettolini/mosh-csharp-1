using System;
namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Summer;

            switch (season)
            {   // Placing them next to each other means they share the same block of actions
                case Season.Spring:
                case Season.Summer:
                    System.Console.WriteLine("I dunno, it's not THAT hot.");
                    break;
                // This will only happen for Winter
                case Season.Winter:
                    System.Console.WriteLine("Yo, I'm freezing. I'm sooo gonna get sick...");
                    break;
                // This would happen for everything besides Spring, Summer and Winter (only Autumn, in this case)
                default:
                    System.Console.WriteLine("I guess this is cool.");
                    break;
            }
        }
    }
    enum Seasons
    {
        Summer,
        Autumn,
        Winter,
        Spring
    }
}