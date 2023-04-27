using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class ContainsOperator
    {
        public  void ContainsOperatorWithPrimitiveType()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            var IsExistsMS = IntArray.Contains(33);
            //Using Query Syntax
            var IsExistsQS = (from num in IntArray
                              select num).Contains(33);
            Console.WriteLine($"Is Element 33 Exist: {IsExistsMS}");
        }

        public void ContainsOperatorWithStringType()
        {
            List<string> namesList = new List<string>() { "James", "Sachin", "Sourav", "Pam", "Sara" };
            //Using Method Syntax
            //This method belongs to System.Collections.Generic namespace
            var IsExistsMS1 = namesList.Contains("Anurag");
            //This method belongs to System.Linq namespace
            var IsExistsMS2 = namesList.AsEnumerable().Contains("Anurag");
            //Using Query Syntax
            var IsExistsQS = (from num in namesList
                              select num).Contains("Anurag");
            Console.WriteLine($"Is Name Anurag Exist: {IsExistsQS}");
        }

        public void ContainsMethodWithComplexType()
        {
            List<Student> students = new List<Student>();
            var student1 = new Student() { ID = 101, Name = "Nishant", TotalMarks = 275 };
            var student2 = new Student() { ID = 102, Name = "Priyanka", TotalMarks = 375 };
            students.Add(student1);
            students.Add(student1);
            //Using Method Syntax
            var IsExistsMS = students.Contains(student1);

            //Using Query Syntax
            var IsExistsQS = (from num in students
                              select num).Contains(student1);
            Console.WriteLine(IsExistsMS);
            var student3 = new Student() { ID = 101, Name = "Nishant", TotalMarks = 275 };
            //Using Query Syntax
            var IsExistsQS1 = (from num in students
                              select num).Contains(student3);
            Console.WriteLine(IsExistsQS1);
        }
    }
}
