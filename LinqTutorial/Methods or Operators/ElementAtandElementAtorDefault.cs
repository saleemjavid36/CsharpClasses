using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class ElementAtandElementAtorDefault
    {
        public void ElementAtExample()
        {
            //Data Source
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using ElementAt Method
            //Fetch the Element from Index Position 1 using Method Syntax
            //ElementAt Method returns a Single Value
            int MethodSyntax = numbers.ElementAt(1);
            //Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).ElementAt(1);
            //Printing the value returned by the ElementAt Method
            Console.WriteLine(MethodSyntax);
        }

        public void ElementAtExample2()
        {
            //Data Source
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using ElementAt Method
            //Fetch the Element from Index Position -1 or 10 using Method Syntax
            //int MethodSyntax = numbers.ElementAt(-1);
            int MethodSyntax = numbers.ElementAt(10);
            //Printing the value returned by the ElementAt Method
            Console.WriteLine(MethodSyntax);
        }
        public void ElementAtExample3()
        {
            //Data Source is Empty
            List<int> numbers = new List<int>();
            //Using ElementAt Method
            int MethodSyntax = numbers.ElementAt(1);
            //Printing the value returned by the ElementAt Method
            Console.WriteLine(MethodSyntax);
        }

        public void ElementAtExample4()
        {
            //Data Source is Null
            List<int> numbers = null;
            //Using ElementAt Method
            int MethodSyntax = numbers.ElementAt(1);
            //Printing the value returned by the ElementAt Method
            Console.WriteLine(MethodSyntax);
        }
        public void ElementAtOrDefaultExample()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Method Syntax
            int MethodSyntax = numbers.ElementAtOrDefault(1);
            //Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).ElementAtOrDefault(1);
            Console.WriteLine(MethodSyntax);
        }

        public void ElementAtOrDefaultExample2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int MethodSyntax1 = numbers.ElementAtOrDefault(10);
            Console.WriteLine($"Value at Index Position 10: {MethodSyntax1}");
            int MethodSyntax2 = numbers.ElementAtOrDefault(-1);
            Console.WriteLine($"Value at Index Position -1: {MethodSyntax2}");
        }

        public void Example()
        {
            //ElementAtOrDefault Method Syntax
            Students ElementAtMS = Students.GetAllStudents().ElementAt(1);
            //ElementAtOrDefault Query Syntax
            Students ElementAtQS = (from student in Students.GetAllStudents()
                                   select student).ElementAt(2);
            //ElementAtOrDefault Method Syntax
            Students ElementAtOrDefaultMS = Students.GetAllStudents().ElementAtOrDefault(0);
            //ElementAtOrDefault Query Syntax
            Students ElementAtOrDefaultQS = (from student in Students.GetAllStudents()
                                            select student).ElementAtOrDefault(3);
            Console.WriteLine($"ID: {ElementAtMS.ID}, Name: {ElementAtMS.Name}");
        }
    }
}
