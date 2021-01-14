using System;
using System.Collections.Generic;

namespace FriendLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter your name.");
            var input = Console.ReadLine();
            var name = new char[input.Length];
            
            for (var i = 0; i < input.Length; i++)
                name[i] = input[i];

            Array.Reverse(name);
            var reversedName = string.Join("", name);
            System.Console.WriteLine("Here you go: " + reversedName);
        }
    }
}
