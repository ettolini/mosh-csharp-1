using System;
using System.IO;

namespace demoDirectoryFilio
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            System.Console.WriteLine("Extension: " + Path.GetExtension(path));
            // .sln
            System.Console.WriteLine("File Name: " + Path.GetFileName(path));
            // HelloWorld.sln
            System.Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            // HelloWorld
            System.Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
            // C:\Projects\CSharpFundamentals\HelloWorld
        }
    }
}
