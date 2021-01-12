using System;

namespace TypeConversion2
{
    class Program
    {
        static void Main(string[] args)
        {
            // You expect an error/exception to occur inside the Try Block
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                System.Console.WriteLine(b);
            }
            // What's inside the Catch Block is what will be executed if an exception is catched
            catch (Exception)
            {
                System.Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }
}
