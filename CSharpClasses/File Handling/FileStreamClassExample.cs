using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpClasses.File_Handling
{
    internal class FileStreamClassExample
    {
        public void FileCreate()
        {
            //Set the File Path
            string FilePath = @"C:\File.txt";
            FileStream fileStream = new FileStream(FilePath, FileMode.Create);
            fileStream.Close();
            Console.Write("File has been created and the Path is C:\\MyFile.txt");
        }

        public void FileOpenAndWrite()
        {
            //Set the File Path
            string FilePath = @"C:\File.txt";
            FileStream fileStream = new FileStream(FilePath, FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("C# Is an Object Oriented Programming Language");
            fileStream.Write(bdata, 0, bdata.Length);
            fileStream.Close();
            Console.WriteLine("Successfully saved file with data : C# Is an Object Oriented Programming Language");
        }

        public void FileRead()
        {
            string FilePath = @"C:\File.txt";
            string data;
            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                data = streamReader.ReadToEnd();
            }
            Console.WriteLine(data);
        }
    }
}
