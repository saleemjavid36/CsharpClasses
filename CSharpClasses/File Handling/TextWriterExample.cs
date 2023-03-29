using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpClasses.File_Handling
{
    internal class TextWriterExample
    {
        public void Example()
        {
            string filePath = @"C:\File1.txt";
            using (TextWriter textWriter = File.CreateText(filePath))
            {
                textWriter.WriteLine("Hello TextWriter Abstract Class!");
                textWriter.WriteLine("File Handling Tutorial in C#");
            }
            Console.WriteLine("Write Successful");
        }
        public async void WriteCharAsync()
        {
            string filePath = @"C:\MyFile2.txt";
            using (TextWriter textWriter = File.CreateText(filePath))
            {
                await textWriter.WriteLineAsync("Hello TextWriter Abstract Class!");
                await textWriter.WriteLineAsync("File Handling Tutorial in C#");
            }
            Console.WriteLine("Async Write Successful");
        }
    }
}
