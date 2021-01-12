using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            // If you opperate with integers, your result is also expected to be an integer
            System.Console.WriteLine(a / b); // 10 / 3 = 3
            // If you wanted to change that, you could cast the operation
            System.Console.WriteLine((float)a / (float)b); // 10 / 3 = 3.333333

            var x = 1;
            var y = 2;
            var z = 3;
            // Precedence works just like regular math, you can also add parentesis to manage the flow
            System.Console.WriteLine(x + y * z); // 1 + (2 * 3) = 7 
        }
    }
}
