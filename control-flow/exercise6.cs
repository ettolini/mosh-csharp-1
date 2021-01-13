using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            System.Console.WriteLine("Please, enter a number.");
            var input = Console.ReadLine();

            while (input != "ok")
            {
                sum += Convert.ToInt32(input);
                System.Console.WriteLine("Please, enter a number.");
                input = Console.ReadLine();
            }
            System.Console.WriteLine(sum);
        }
    }
}
