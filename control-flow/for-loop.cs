using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    System.Console.WriteLine(i); // 2, 4, 6, 8, 10
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i%2 =! 0)
                {
                    System.Console.WriteLine(i); // 9, 7, 5, 3, 1
                }
            }
        }
    }
}
