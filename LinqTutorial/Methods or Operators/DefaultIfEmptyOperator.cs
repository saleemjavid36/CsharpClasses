using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class DefaultIfEmptyOperator
    {
        public void Example()
        {
            //Sequence is not empty
            List<int> numbers = new List<int>() { 10, 20, 30 };
            //DefaultIfEmpty Method will return a new sequence with existing sequence values
            //Using Method Syntax
            IEnumerable<int> resultMS = numbers.DefaultIfEmpty();
            //Using Query Syntax
            IEnumerable<int> resultQS = (from num in numbers
                                         select num).DefaultIfEmpty();
            //Accessing the new sequence values using for each loop
            foreach (int num in resultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public void ExampleWhenSequenceIsEmpty()
        {
            //Sequence is empty
            List<int> numbers = new List<int>();
            //DefaultIfEmpty Method will return a new sequence with one element having the value 0
            //as the Sequence is Empty
            //Using Method Syntax
            IEnumerable<int> resultMS = numbers.DefaultIfEmpty();
            //Using Query Syntax
            IEnumerable<int> resultQS = (from num in numbers
                                         select num).DefaultIfEmpty();
            //Accessing the new sequence values using for each loop
            foreach (int num in resultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public void SupplyUserGivenValues()
        {
            //Sequence is empty
            List<int> numbers = new List<int>();
            //DefaultIfEmpty Method will return 5 as the Sequence is Empty
            //as the Sequence is Empty
            //Using Method Syntax
            IEnumerable<int> resultMS = numbers.DefaultIfEmpty(5);
            //Using Query Syntax
            IEnumerable<int> resultQS = (from num in numbers
                                         select num).DefaultIfEmpty();
            //Accessing the new sequence values using for each loop
            foreach (int num in resultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public void SupplyValueWhenSequenceIsNotEmpty()
        {
            //Sequence is not empty
            List<int> numbers = new List<int>() { 10, 20, 30 };
            //DefaultIfEmpty Method will return the Original Sequence values
            //as the Sequence is not Empty
            //Using Method Syntax
            IEnumerable<int> resultMS = numbers.DefaultIfEmpty(5);
            //Using Query Syntax
            IEnumerable<int> resultQS = (from num in numbers
                                         select num).DefaultIfEmpty();
            //Accessing the new sequence values using for each loop
            foreach (int num in resultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public void ExampleWithComplexType()
        {
            //Sequence is not empty
            List<Employees> employees = Employees.GetAllEmployeess();

            List<Employees> emptyList = new List<Employees>();
            //Create an Employee Object to pass into the DefaultIfEmpty method incase the sequence is Empty
            Employees emp5 = new Employees() { ID = 5, Name = "Hina", Salary = 10000, Department = "IT" };
            //DefaultIfEmpty Method will return the Original Sequence values
            //as the Sequence is not Empty
            //Using Method Syntax
            IEnumerable<Employees> resultMS = employees.DefaultIfEmpty(emp5);
            //Using Query Syntax
            IEnumerable<Employees> resultQS = (from employee in employees
                                              select employee).DefaultIfEmpty(emp5);
            //Accessing the new sequence values using for each loop
            foreach (Employees emp in resultMS)
            {
                Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Department:{emp.Department}, Salary:{emp.Salary} ");
            }
            IEnumerable<Employees> resultMS1 = emptyList.DefaultIfEmpty(emp5);
            //Accessing the new sequence values using for each loop
            foreach (Employees emp in resultMS1)
            {
                Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Department:{emp.Department}, Salary:{emp.Salary} ");
            }
        }
    }
}
