using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpClasses.File_Handling
{
    internal class StreamReaderClassExample
    {
        public void ReadFile()
        {
            //Creating a new input stream i.e.  MyFile.txt and opens it
            StreamReader sr = new StreamReader("C://MyFile.txt");
            Console.WriteLine("Content of the File");
            // This is used to specify from where to start reading input stream
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // To read line from input stream
            string str = sr.ReadLine();
            // To read the whole file line by line
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            // to close the stream
            sr.Close();
        }
    }
}
