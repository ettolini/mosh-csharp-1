using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Etto";

            for (var i = 0; i < name.Length; i++)
            {
                System.Console.WriteLine(name[i]); // E t t o
            }

            foreach (var character in name)
            {
                System.Console.WriteLine(character); // E t t o
            }

            var numbers = new int[4] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number); // 1 2 3 4
            }
        }
    }
}
