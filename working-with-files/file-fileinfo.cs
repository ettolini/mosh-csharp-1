using System;
using System.IO;

namespace demoEnglish
{
    class Program
    {
        static void Main(string[] args)
        {
            // File Methods

            var path = @"c:\somefile.jpg";

            var content = File.ReadAllText(path); // Returns a string of all the text inside the file
            var content2 = File.ReadAllBytes(path); // Returns an array of bytes, represents all the text inside, but in binary code
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);  // (source, destiny, [optional] bool)
            // The third parameter represents if it's allowed to override an already existing file with the same name
            if (File.Exists(path))  // If path exists...
                File.Delete(path);  // It'll be deleted from the file

            // FileIndo Methods

            var fileInfo = new FileInfo(path);  // With FileInfo you need to create its object, and give it a path for its constructor
            fileInfo.CopyTo("...", false);  // Copies the file to "...", the second parameter is whether you can override or not (optional)
            if (fileInfo.Exists)    // If fileInfo exists...
                fileInfo.Delete();  // ... fileInfo is deleted
        }
    }
}