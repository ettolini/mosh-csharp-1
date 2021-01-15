using System;

namespace demoEnglishProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            string reversed = ReverseName(name);
            System.Console.WriteLine("Reversed name: " + reversed);
        }

        public static string ReverseName(string name)
        {
            char[] array = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
                array[name.Length - 1] = name[i - 1];

            return new string(array);
        }
    }
}
