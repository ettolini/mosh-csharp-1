using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter the width of an image.");
            var input = Console.ReadLine();
            var width = Convert.ToDouble(input);

            System.Console.WriteLine("Please, enter the height of the same image.");
            input = Console.ReadLine();
            var height = Convert.ToDouble(input);

            if (width < height)
                System.Console.WriteLine("The image is a portrait, right?");
            else
                System.Console.WriteLine("This is an image of a landscape, is it not?");
        }
    }
}
