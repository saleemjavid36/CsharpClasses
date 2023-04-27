using LinqTutorial.IEnumerable_and_IQueryable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinqTutorial.Methods_or_Operators
{
    internal class FirstandFirstOrDefault
    {
        public void FirstExample()
        {
            //Fetching the First Element from the Data Source using First Method
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int MethodSyntax = numbers.First();
            //Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).First();
            //Printing the value returned by the First Method
            Console.WriteLine(MethodSyntax);
        }

        public void FirstWithPredicate()
        {
            //Fetching the First Element from the Data Source which is Divisble by 2
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int MethodSyntax = numbers.First(num => num % 2 == 0);
            //Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).First(num => num % 2 == 0);
            //Printing the value returned by the First Method
            Console.WriteLine(MethodSyntax);
        }
        public void FirstWithNullDataSource()
        {
            //Empty Data Source
            List<int> numbersEmpty = new List<int>() { };
            int MethodSyntax = numbersEmpty.First();
            Console.WriteLine(MethodSyntax);
        }

        public void FirstWithCollectionNotReturningData()
        {
            // Specified Condition Doesnot Return Any Element
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int MethodSyntax = numbers.First(num => num > 50);
            Console.WriteLine(MethodSyntax);
        }

        public void FirstWithComplexType()
        {
            //Data Source
            List<Students> listStudents = Students.GetAllStudents();
            //Fetching the First Employee from listEmployees Collection
            Students student1 = listStudents.First();
            Console.WriteLine($"{student1.ID}, {student1.Name}, {student1.Gender}");
            //Fetch the First Employee where the Gender is Male
            Students student2 = listStudents.First(st => st.Gender == "Male");
            Console.WriteLine($"{student2.ID}, {student2.Name}, {student2.Gender}");
            //Fetch the First Employee where the Salary is less than 30000
            Students student3 = listStudents.First(st => st.Age < 21);
            Console.WriteLine($"{student3.ID}, {student3.Name}, {student3.Gender}");
        }

        public void FirstOrDefaultExample()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int MethodSyntax = numbers.FirstOrDefault();

            //Using Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).FirstOrDefault();
            Console.WriteLine(MethodSyntax);
        }

        public void FirstOrDefaultWithPredicate()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int MethodSyntax = numbers.FirstOrDefault(num => num > 5);

            //Using Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).FirstOrDefault(num => num > 5);
            Console.WriteLine(MethodSyntax);
        }

        public void FirstOrDefaultWithComplexType()
        {
            //Data Source
            List<Students> listStudents = Students.GetAllStudents();
            //Fetching the First Employee from listEmployees Collection
            Students student1 = listStudents.FirstOrDefault();
            Console.WriteLine($"{student1.ID}, {student1.Name}, {student1.Gender}");
            //Fetch the First Employee where the Gender is Male
            Students student2 = listStudents.FirstOrDefault(st => st.Gender == "Male");
            Console.WriteLine($"{student2.ID}, {student2.Name}, {student2.Gender}");
            //Fetch the First Employee where the Salary is less than 30000
            Students student3 = listStudents.FirstOrDefault(st => st.Age < 21);
            Console.WriteLine($"{student3.ID}, {student3.Name}, {student3.Gender}");
        }
    }
}
