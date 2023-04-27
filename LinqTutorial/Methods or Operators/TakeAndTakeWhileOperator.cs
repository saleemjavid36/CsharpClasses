using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class TakeAndTakeWhileOperator
    {
        public void TakeAndTakeWhileExample()
        {
            //Sequence Contains 10 Elements
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Fetching the First four elements from the Sequence using Take Method
            //Using Method Syntax
            List<int> taketMS = numbers.Take(4).ToList();
            //Using Query Syntax
            List<int> takeQS = (from num in numbers
                                  select num).Take(4).ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in taketMS)
            {
                Console.Write($"{num} ");
            }

            //Fetch Numbers which are less than 6 using TakeWhile Method
            //Using Method Syntax
            List<int> takeAndWhileMS = numbers.TakeWhile(num => num < 6).ToList();
            //Using Query Syntax
            List<int> takeAndWhileQS = (from num in numbers
                                  select num).TakeWhile(num => num < 6).ToList();
            //Accessing the Result using Foreach Loop
            foreach (var num in takeAndWhileMS)
            {
                Console.Write($"{num} ");
            }

        }

        public void TakeAndTakeWhileWithFiltering()
        {

            //Sequence Contains 10 Elements
            List<int> numbers = new List<int>() { 1, 2, 3, 6, 7, 8, 9, 10, 4, 5 };
            //Fetching the First four elements from the Sequence where Number > 3
            //Using Method Syntax
            List<int> ResultMS = numbers.Where(num => num > 3).Take(4).ToList();

            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  where num > 3
                                  select num).Take(4).ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }

            //Using TakeWhile Method to Fetch Numbers which are less than 6
            List<int> Result1 = numbers.TakeWhile(num => num < 6).ToList();
            Console.Write("Result Of TakeWhile Method: ");
            foreach (var num in Result1)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            //Using Where Method to Fetch Numbers which are less than 6
            List<int> Result2 = numbers.Where(num => num < 6).ToList();
            Console.Write("Result Of Where Method: ");
            foreach (var num in Result2)
            {
                Console.Write($"{num} ");
            }
        }

        public void TakeWhenDataSourceIsNull()
        {
            //Data Source is Null
            List<int> numbers = null;
            //Fetching the First four elements from the Sequence
            //Using Method Syntax
            List<int> ResultMS = numbers.Take(4).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  select num)
                                  .Take(4)
                                  .ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public void TakeWithComplexType()
        {
            //Data Source
            List<Employees> employees = Employees.GetAllEmployeess();
            //Fetching First four Employees who are getting Highest Salary
            //Using Method Syntax
            List<Employees> ResultMS = employees.OrderByDescending(emp => emp.Salary).Take(4).ToList();
            //Using Query Syntax
            List<Employees> ResultQS = (from emp in employees
                                       orderby emp.Salary descending
                                       select emp)
                                  .Take(4)
                                  .ToList();
            //Accessing the Results using Foreach Loop
            foreach (Employees emp in ResultMS)
            {
                Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Department:{emp.Department}, Salary:{emp.Salary}");
            }
        }

        public void TakeWhileWithString()
        {
            List<string> names = new List<string>() { "Sara", "Rahul", "John", "Pam", "Priyanka" };
            List<string> namesResult = names.TakeWhile(name => name.Length > 3).ToList();

            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }
        }

        public void TakeWhileMethodWithIndexParameter()
        {
            List<string> names = new List<string>() { "Sara", "Rahul", "John", "Pam", "Priyanka" };
            List<string> namesResult = names.TakeWhile((name, index) => name.Length > index).ToList();

            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }

        }
    }
}
