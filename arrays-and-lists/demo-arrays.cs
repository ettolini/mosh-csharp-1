using System;

namespace ArraysArrechas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Length
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine("Length: " + numbers.Length); // Returns the total number of indexes in the array

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            System.Console.WriteLine("Index of 9: " + index); // Returns the index where the given element is located

            // Clear()
            Array.Clear(numbers, 0, 2);                     // Clears elements from the array. It first receives the array to clear,
            System.Console.WriteLine("Effect of Clear()");  // then the index of said array from where the clearing process will start,
            foreach (var n in numbers)                      // and finally, the number of elements to clear.
                System.Console.WriteLine(n);                // "Clearing" means giving the cell its default value.

            // Copy
            int[] another = new int[3];                     // Copies elements from an array into another. 
            Array.Copy(numbers, another, 3);                // It first receives the array to copy from, then the array to copy to,
            System.Console.WriteLine("Effect of Copy()");   // and then the number of elements to copy (starting from index 0)
            foreach (var a in another)
                System.Console.WriteLine(a);

            // Sort()
            Array.Sort(numbers);                            
            System.Console.WriteLine("Effect of Sort()");   // Sorts the order of the elements inside the array. From lower to greater.
            foreach (var n in numbers)
                System.Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);
            System.Console.WriteLine("Effect of Reverse()");    // Sorts the order of the elements inside the array. From greater to lower.
            foreach (var n in numbers)
                System.Console.WriteLine(n);
        }
    }
}