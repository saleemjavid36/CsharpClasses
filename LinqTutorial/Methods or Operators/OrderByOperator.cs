using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class OrderByOperator
    {
        public void OrderByExample()
        {
            List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };
            Console.WriteLine("Before Sorting : ");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            //Sorting the data in Ascending Order
            //Using Method Syntax
            var MS = intList.OrderBy(num => num).ToList();
            //Using Query Syntax
            var QS = (from name in intList
                      orderby name ascending
                      select name).ToList();

            Console.WriteLine();
            Console.WriteLine("After Sorting : ");
            foreach (var item in MS)
            {
                Console.Write(item + " ");
            }
        }

        public void OrderByWithString()
        {
            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan",
            "Hina","Kumar","Manoj", "Rout", "James"};
            //Using Method Syntax
            var MS = stringList.OrderBy(name => name);
            //Using Query Syntax
            var QS = (from name in stringList
                      orderby name ascending
                      select name).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item + " ");
            }
        }
        public void OrderByWithComplexType()
        {
            //Method Syntax
            var MS = Student.GetStudents().OrderBy(x => x.ID).ToList();
            //Query Syntax
            var QS = (from std in Student.GetStudents()
                      orderby std.ID
                      select std);
            foreach (var student in MS)
            {
                Console.WriteLine(" ID: " + student.ID + ", Name :" + student.Name);
            }
        }

        public void OrderByWIthFilter()
        {
            //Method Syntax
            var MS = Student.GetStudents()
                            .Where(std => std.Name.ToUpper() == "NISHANT")
                            .OrderBy(x => x.ID).ToList();
            //Query Syntax
            var QS = (from std in Student.GetStudents()
                      where std.Name.ToUpper() == "Nishant"
                      orderby std.Name
                      select std);
            foreach (var student in QS)
            {
                Console.WriteLine(" ID: " + student.ID + ", Name :" + student.Name);
            }
        }

    }
}
