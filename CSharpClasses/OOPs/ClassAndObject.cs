using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs
{
    public class Student
    {
        public Student()
        {
                
        }
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public long Mobile { get; set; }
        public string Address { get; set; }

        public string FullName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine(fullName);
            return fullName;
        }

        public void PrintNameLength()
        {
            string fullName = FullName();
            int length = fullName.Length;
            Console.WriteLine("The length of full name is " + length);
        }
    }
}
