using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpClasses.File_Handling
{
    internal class StreamWriterStreamReader
    {
        public void Example()
        {
            string file = @"C:\MyTextFile3.txt";
            //Writer data to text file
            using (StreamWriter streamWriter = new StreamWriter(file))
            {
                streamWriter.WriteLine("Hellow StreamWriter Class in C#");
                streamWriter.WriteLine("How are you Doing?");
            }
            //Reading text file using StreamReader Class            
            using (StreamReader reader = new StreamReader(file))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
