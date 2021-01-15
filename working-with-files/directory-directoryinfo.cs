using System;
using System.IO;

namespace demoDirectory
{
    class Program
    {
        static void Main(string[] args) // Directory = Folder
        {
            // Directory

            Directory.CreateDirectory(@"c:\temp\folder1");  // Creates a directory, must receive a path where it'll be located
            
            var files = Directory.GetFiles(@"c:\project\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            // This method has three overloads, it should at least get the first parameter. But second and third are optional
            // 1: Target directory's path.  2: The search pattern (*.* -> all files)
            // 3: SearchOption (AllDirectories -> target directory and its sub-directories) (TopDirectoryOnly -> only target directory)
            // It returns a string array, said strings will be the matching paths found in throughout the search
            foreach (var file in files)
                System.Console.WriteLine(file); // It can be iterated like this
            var directories = Directory.GetDirectories(@"c:projects\CSharpFundamentals", "*.*",
                SearchOption.TopDirectoryOnly); // The same method also exists for directories inside the given directory path
            Directory.Exists("...");

            // DirectoryInfo

            var directoryInfo = new DirectoryInfo("...");   // Their different is the same one presented by File and FileInfo
            directoryInfo.GetFiles();           // These two work exactly the same as the previous ones
            directoryInfo.GetDirectories();     // To get to know more methods, Google them up!
        }
    }
}
