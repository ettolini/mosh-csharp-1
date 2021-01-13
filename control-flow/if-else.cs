using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            var isGoldCustomer = true;

            // float price;
            // if (isGoldCustomer)
            //     price = 19.95f;
            // else
            //     price = 29.95f;

            var price = (isGoldCustomer) ? 19.95f : 29.95f; 
            
            System.Console.WriteLine(price); // 19.95
        }
    }
}