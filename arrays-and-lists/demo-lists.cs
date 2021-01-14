using System.Collections.Generic;

namespace ListsMyBro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add Method
            var numbers = new List<int>() { 1, 2, 3, 4 }; // 1, 2, 3, 4
            numbers.Add(1); // numbers + 1 -> 1, 2, 3, 4, 1
            
            // AddRange Method
            numbers.AddRange(new int[3] { 5, 6, 7 }); 
            foreach (var number in numbers)
                System.Console.WriteLine(number); // numbers + [5, 6, 7] -> 1, 2, 3, 4, 1, 5, 6, 7

            // IndexOf and LastIndexOf Method
            System.Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); 
            // First index where the element is located -> 0
            System.Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));
            // Last index where the element is located -> 4

            // Count Method
            System.Console.WriteLine("Count: " + numbers.Count);    // List's current length -> 8

            // Remove Method
            for (var i = 0; i < numbers.Count; i++)
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]); // Where there was a 1 store, its value is changed to 0
            // Modifying collections (what we just did) is not allowed in foreach loops. A for loop would be needed

            // Clear Method
            numbers.Clear(); // Removes all elements from the list
        }
    }
}