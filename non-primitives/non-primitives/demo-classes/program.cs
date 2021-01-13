using System;

namespace DemoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var man1 = new Person();
            man1.FirstName = "Ettore";
            man1.LastName = "Bortolin";
            man1.Introduce(); // My name is Ettore Bortolin

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result); // 3
        }
    }
}