using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class AggregateFunctions
    {
        public void Example()
        {

            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };

            //Max
            //Using Method Syntax
            int MSTotal = intNumbers.Sum();
            //Using Query Syntax
            int QSTotal = (from num in intNumbers
                           select num).Sum();
            Console.WriteLine("Sum = " + QSTotal);

            //Count
            //Using Method Syntax
            int MSCount = intNumbers.Count();
            Console.WriteLine("No of Elements = " + MSCount);

            //Average
            // Using Method Syntax
            var MSAverageValue = intNumbers.Average();
            Console.WriteLine("Average Value = " + MSAverageValue);

            //Max
            //Using Method Syntax
            int MSLergestNumber = intNumbers.Max();
            Console.WriteLine("Largest Number = " + MSLergestNumber);

            //Min
            //Using Method Syntax
            int MSLowestNumber = intNumbers.Min();
            Console.WriteLine("Lowest Number = " + MSLowestNumber);
        }

        public void AggreagateFunctionsWithWhere()
        {
            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };
            //Using Method Syntax
            int MSTotal = intNumbers.Where(num => num > 50).Sum();
            //Using Query Syntax
            int QSTotal = (from num in intNumbers
                           where num > 50
                           select num).Sum();
            Console.WriteLine("Sum = " + QSTotal);

            //Count
            //Using Method Syntax
            int MSCount = intNumbers.Where(num => num > 40).Count();
            //Using Query Syntax
            var QSCount = (from num in intNumbers
                           where num > 40
                           select num).Count();
            Console.WriteLine("No of Elements = " + MSCount);

            //Average
            //Using Method Syntax
            var MSAverageValue = intNumbers.Where(num => num > 50).Average();
            //Using Query Syntax
            var QSAverageValue = (from num in intNumbers
                                  where num > 50
                                  select num).Average();
            Console.WriteLine("Average Value = " + MSAverageValue);

            //Max
            //Using Method Syntax
            int MSLergestNumber = intNumbers.Where(num => num < 50).Max();
            Console.WriteLine("Largest Number = " + MSLergestNumber);

            //Min
            //Using Method Syntax
            int MSLowestNumber = intNumbers.Where(num => num > 50).Min();
            Console.WriteLine("Lowest Number = " + MSLowestNumber);

        }

        public void AggregateFunctionsWithComplexType()
        {
            //Using Method Syntax
            var TotalSalaryMS = Employees.GetAllEmployeess()
                              .Sum(emp => emp.Salary);
            //Using Query Syntax
            var TotalSalaryQS = (from emp in Employees.GetAllEmployeess()
                                 select emp).Sum(e => e.Salary);

            Console.WriteLine("Sum Of Salary = " + TotalSalaryMS);

            //Count 
            //Using Method Syntax
            var MSCount = Employees.GetAllEmployeess().Count();
            //Using Query Syntax
            var QSCount = (from emp in Employees.GetAllEmployeess()
                           select emp).Count();
            Console.WriteLine("Total No of Employees = " + QSCount);

            //Average
            //Using Method Syntax
            var MSAverageSalary = Employees.GetAllEmployeess()
                                 .Average(emp => emp.Salary);
            //Using Query Syntax
            var QSAverageSalary = (from emp in Employees.GetAllEmployeess()
                                   select emp).Average(e => e.Salary);
            Console.WriteLine("Average Salary = " + MSAverageSalary);

            //Max
            //Using Method Syntax
            var MSHighestSalary = Employees.GetAllEmployeess()
                              .Max(emp => emp.Salary);
            Console.WriteLine("Highest Salary = " + MSHighestSalary);

            //Min
            //Using Method Syntax
            var MSLowestSalary = Employees.GetAllEmployeess()
                                 .Min(emp => emp.Salary);
            Console.WriteLine("Lowest Salary = " + MSLowestSalary);

        }
    }

    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        public static List<Employees> GetAllEmployeess()
        {
            List<Employees> listStudents = new List<Employees>()
            {
                new Employees{ID= 101,Name = "Preety", Salary = 10000, Department = "IT"},
                new Employees{ID= 102,Name = "Priyanka", Salary = 15000, Department = "Sales"},
                new Employees{ID= 103,Name = "James", Salary = 50000, Department = "Sales"},
                new Employees{ID= 104,Name = "Hina", Salary = 20000, Department = "IT"},
                new Employees{ID= 105,Name = "Anurag", Salary = 30000, Department = "IT"},
                new Employees{ID= 106,Name = "Sara", Salary = 25000, Department = "IT"},
                new Employees{ID= 107,Name = "Pranaya", Salary = 35000, Department = "IT"},
                new Employees{ID= 108,Name = "Manoj", Salary = 11000, Department = "Sales"},
                new Employees{ID= 109,Name = "Sam", Salary = 45000, Department = "Sales"},
                new Employees{ID= 110,Name = "Saurav", Salary = 25000, Department = "Sales"}
            };
            return listStudents;
        }
    }
}
