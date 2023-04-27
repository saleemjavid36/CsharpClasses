using LinqTutorial.Methods_or_Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial
{
    internal class LastAndLastOrDefault
    {
        public void LastExample()
        {
            //Fetching the Last Element from the Data Source using Last Method
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int MethodSyntax = numbers.Last();
            //Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).Last();
            //Printing the value returned by the Last Method
            Console.WriteLine(MethodSyntax);
        }

        public void LastWithPredicate()
        {
            //Fetching the Last Element from the Data Source which is Divisble by 3
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int MethodSyntax = numbers.Last(num => num % 3 == 0);
            //Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).Last(num => num % 3 == 0);
            //Printing the value returned by the Last Method
            Console.WriteLine(MethodSyntax);
        }
        public void LastWithNullDataSource()
        {
            //Empty Data Source
            List<int> numbersEmpty = new List<int>() { };
            int MethodSyntax = numbersEmpty.Last();
            Console.WriteLine(MethodSyntax);
        }

        public void LastWithCollectionNotReturningData()
        {
            // Specified Condition Doesnot Return Any Element
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int MethodSyntax = numbers.Last(num => num > 50);
            Console.WriteLine(MethodSyntax);
        }
        public void LastWithComplexType()
        {
            //Data Source
            List<Students> listStudents = Students.GetAllStudents();
            //Fetching the Last Employee from listEmployees Collection
            Students student1 = listStudents.Last();
            Console.WriteLine($"{student1.ID}, {student1.Name}, {student1.Gender}");
            //Fetch the Last Employee where the Gender is Male
            Students student2 = listStudents.Last(st => st.Gender == "Male");
            Console.WriteLine($"{student2.ID}, {student2.Name}, {student2.Gender}");
            //Fetch the Last Employee where the Salary is less than 30000
            Students student3 = listStudents.Last(st => st.Age < 21);
            Console.WriteLine($"{student3.ID}, {student3.Name}, {student3.Gender}");
        }

        public void LastOrDefaultExample()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int MethodSyntax = numbers.LastOrDefault();

            //Using Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).LastOrDefault();
            Console.WriteLine(MethodSyntax);
        }

        public void LastOrDefaultWithPredicate()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int MethodSyntax = numbers.LastOrDefault(num => num > 5);

            //Using Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).LastOrDefault(num => num > 5);
            Console.WriteLine(MethodSyntax);
        }

        public void LastOrDefaultWithComplexType()
        {
            //Data Source
            List<Students> listStudents = Students.GetAllStudents();
            //Fetching the Last Employee from listEmployees Collection
            Students student1 = listStudents.LastOrDefault();
            Console.WriteLine($"{student1.ID}, {student1.Name}, {student1.Gender}");
            //Fetch the Last Employee where the Gender is Male
            Students student2 = listStudents.LastOrDefault(st => st.Gender == "Male");
            Console.WriteLine($"{student2.ID}, {student2.Name}, {student2.Gender}");
            //Fetch the Last Employee where the Salary is less than 30000
            Students student3 = listStudents.LastOrDefault(st => st.Age < 21);
            Console.WriteLine($"{student3.ID}, {student3.Name}, {student3.Gender}");
        }

    }
   
}

