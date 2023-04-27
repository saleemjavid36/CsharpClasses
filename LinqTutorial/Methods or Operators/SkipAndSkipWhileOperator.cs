using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class SkipAndSkipWhileOperator
    {
        public void Example()
        {
            //Data Source 
            List<int> numbers = new List<int>() { 1, 2, 3, 6, 7, 8, 9, 10, 4, 5 };
            //Skip the First Four Elements and Return Remaining Elements from the Data Source
            //Using Method Syntax
            List<int> ResultMS = numbers.Skip(4).ToList();
            //Using Mixed Syntax
            List<int> ResultQS = (from num in numbers
                                  select num).Skip(4).ToList();
            //Accessing the Elements using a Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
            List<int> ResultMS1 = numbers.SkipWhile(num => num < 5).ToList();
            foreach (var num in ResultMS1)
            {
                Console.Write($"{num} ");
            }
        }

        public void SkipWithFiltering()
        {
            //Sequence Contains 10 Elements
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Skipping the First four elements and Return Remaining Elements from the Sequence 
            //where Number > 3
            //Using Method Syntax
            List<int> ResultMS = numbers.Where(num => num > 3).Skip(4).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  where num > 3
                                  select num).Skip(4).ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public void SkipWhenDataSourceIsNull()
        {
            //Sequence is Null
            List<int> numbers = null;
            //Skip the First three elements and Returns the Remaining Elements

            //Using Method Syntax
            List<int> ResultMS = numbers.Skip(3).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  select num)
                                  .Skip(3)
                                  .ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public void SkipWithComplexType()
        {
            //Data Source
            List<Employees> employees = Employees.GetAllEmployeess();
            //Skip First four Employees who are getting lowest Salary
            //Using Method Syntax
            List<Employees> ResultMS = employees.OrderBy(emp => emp.Salary).Skip(4).ToList();
            //Using Query Syntax
            List<Employees> ResultQS = (from emp in employees
                                       orderby emp.Salary ascending
                                       select emp)
                                       .Skip(4)
                                       .ToList();
            //Accessing the Results using Foreach Loop
            foreach (Employees emp in ResultMS)
            {
                Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Department:{emp.Department}, Salary:{emp.Salary}");
            }
        }

        public void SkipWhileWithString()
        {
            List<string> names = new List<string>() { "Pam", "Rahul", "Kim", "Sara", "Priyanka" };
            List<string> namesResult = names.SkipWhile(name => name.Length < 4).ToList();
            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }
        }

        public void SkipWhileUsingIndex()
        {
            List<string> names = new List<string>() { "Sara", "Rahul", "John", "Pam", "Priyanka" };
            List<string> namesResult = names.SkipWhile((name, index) => name.Length > index).ToList();
            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }
        }
    }
}
