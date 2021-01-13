using System;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var number1 = Convert.ToInt32(input);
            input = Console.ReadLine();
            var number2 = Convert.ToInt32(input);

            if (number1 > number2)
                System.Console.WriteLine(number1);
            else
                System.Console.WriteLine(number2);
        }
    }
}
