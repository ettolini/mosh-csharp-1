namespace DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[1];
            numbers[0] = 1;

            System.Console.WriteLine(numbers[0]); // 1
            System.Console.WriteLine(numbers[1]); // 0 by default

            var flags = new bool[1];
            flags[0] = true;

            System.Console.WriteLine(flags[0]); // true
            System.Console.WriteLine(flags[1]); // false by default

            var names = new string[2] {"Ettore", "Hector"};

            System.Console.WriteLine(names[0]); // Ettore
            System.Console.WriteLine(names[1]); // Hector
        }
    }
}