using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class OrderByDescendingOperator
    {
        public void OrderByDescendingWithValueDataType()
        {
            List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };
            Console.WriteLine("Before Sorting the Data: ");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            //Sorting the data in Descending Order Using Method Syntax
            var MS = intList.OrderByDescending(num => num);
            //Sorting the data in Descending Order Using Query Syntax
            var QS = (from num in intList
                      orderby num descending
                      select num).ToList();
            Console.WriteLine();
            Console.WriteLine("After Sorting the Data in Descending Order: ");
            foreach (var item in QS)
            {
                Console.Write(item + " ");
            }
        }
        public void OrderByDescendingWithString()
        {
            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Priyanka", "Dewangan", "Hina", "Sharma" };
            Console.WriteLine("Before Sorting:");
            foreach (var item in stringList)
            {
                Console.Write(item + " ");
            }
            //Sorting in Descending Order Using Method Syntax
            var MS = stringList.OrderByDescending(name => name);
            //Sorting in Descending Order Using Query Syntax
            var QS = (from name in stringList
                      orderby name descending
                      select name).ToList();
            Console.WriteLine("\nAfter Sorting in Descending Order:");
            foreach (var item in MS)
            {
                Console.Write(item + " ");
            }
        }

        public void OrderByDescendingWithComplexType()
        {
            // Method Syntax
            var MS = Student.GetStudents().OrderByDescending(x => x.ID).ToList();
            //Query Syntax
            var QS = (from std in Student.GetStudents()
                      orderby std.ID descending
                      select std);
            foreach (var student in MS)
            {
                Console.WriteLine(" ID: " + student.ID + ", Name :" + student.Name);
            }
        }
    }
}
