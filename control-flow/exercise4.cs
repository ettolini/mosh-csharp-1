using System;

namespace democionPapa
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter the speed limit.");
            var input = Console.ReadLine();
            var speedLimit = Convert.ToDouble(input);

            System.Console.WriteLine("Please, enter the speed of a car.");
            input = Console.ReadLine();
            var carSpeed = Convert.ToDouble(input);

            if (carSpeed < speedLimit)
                System.Console.WriteLine("Ok.");
            else
            {
                var kmAbove = carSpeed - speedLimit;
                var demeritPoints = kmAbove / 5;

                if (demeritPoints > 12)
                    System.Console.WriteLine("License Suspended.");
            }

            System.Console.WriteLine("Fin.");
        }
    }
}
