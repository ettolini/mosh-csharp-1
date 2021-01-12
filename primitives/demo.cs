using System;

namespace primitives_code_
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can define variables like this...
            byte number = 2;
            // Or you can use the "var" keyword so the engine identifies the variable's type based on its given value
            // Keep in mind, if you were to give it a byte value, it wouldn't be recorded as such, but as an int
            // If you really want to use byte, you should specify it, but int is recommended by default anyways
            var count = 10;
            var totalPrice = 20.95f;
            var character = "A";
            var firstName = "Mosh";
            var isWorking = false;

            // You can type this command as such...
            Console.WriteLine(number);
            // Or you could type "cw" and press Enter, then you'd get it like the following (identifier not included)
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);
        }
    }
}
