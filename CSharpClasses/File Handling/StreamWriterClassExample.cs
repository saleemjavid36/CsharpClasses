using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpClasses.File_Handling
{
    internal class StreamWriterClassExample
    {
        public void FileWrite()
        {
            // This will create a file named MyFile.txt at the specified location i.e. in the D Drive
            // Here we are using the StreamWriter constructor which takes the string path as an argument to create an instance of StreamWriter class
            StreamWriter sw = new StreamWriter("C://MyFile.txt");
            //Asking user to enter the text that we want to write into the MyFile.txt file
            Console.WriteLine("Enter the Text that you want to write on File");
            // To read the input from the user
            string str = Console.ReadLine();
            // To write the data into the stream
            sw.Write(str);
            // Clears all the buffers
            sw.Flush();
            // To close the stream
            sw.Close();
        }

        public void SaveVariableDataToFile()
        {
            string file = @"C:\MyTextFile1.txt";
            int a, b, result;
            a = 15;
            b = 20;
            result = a + b;
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write("Sum of {0} + {1} = {2}", a, b, result);
            }
            Console.WriteLine("Saved");
        }
    }
}
