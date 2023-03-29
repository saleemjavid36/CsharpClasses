using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpClasses.File_Handling
{
    internal class TextReaderExample
    {
        public void Example()
        {
            string filePath = @"C:\File1.txt";
            //Read One Line
            using (TextReader textReader = File.OpenText(filePath))
            {
                Console.WriteLine(textReader.ReadLine());
            }
            //Read 4 Characters
            using (TextReader textReader = File.OpenText(filePath))
            {
                char[] ch = new char[4];
                textReader.ReadBlock(ch, 0, 4);
                Console.WriteLine(ch);
            }
            //Read full file
            using (TextReader textReader = File.OpenText(filePath))
            {
                Console.WriteLine(textReader.ReadToEnd());
            }
        }
    }
}
