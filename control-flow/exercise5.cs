using System;

namespace demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                    System.Console.WriteLine(i);
            }
        }
    }
}
