using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Dynamic_Type
{
    internal class ComplexDynamicTypeConversion
    { 
        public void ComplexToDynamicType()
        {
            Student student1 = new Student()
            {
                Name = "Anurag",
                Barnch = "CSE",
                Roll = 1001
            };
            // Student type to dynamic conversion
            dynamic dynamicStudent = student1;
            Console.WriteLine($"Name = {dynamicStudent.Name}");
            Console.WriteLine($"Barnch = {dynamicStudent.Barnch}");
            Console.WriteLine($"Roll = {dynamicStudent.Roll}");

            Console.ReadKey();
        }
        public void DynamicToComplexType()
        {
            dynamic dynamicStudent = new Student()
            {
                Name = "Anurag",
                Barnch = "CSE",
                Roll = 1001
            };
            // dynamic to Student type conversion
            Student student1 = dynamicStudent;
            Console.WriteLine($"Name = {student1.Name}");
            Console.WriteLine($"Barnch = {student1.Barnch}");
            Console.WriteLine($"Roll = {student1.Roll}");

            Console.ReadKey();
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Barnch { get; set; }
        public long Roll { get; set; }
    }
}
