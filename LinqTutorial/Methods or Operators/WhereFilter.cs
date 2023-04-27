using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class WhereFilter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public List<string> Technology { get; set; }
        public static List<WhereFilter> GetEmployees()
        {
            List<WhereFilter> employees = new List<WhereFilter>()
            {
                new WhereFilter {ID = 101, Name = "Preety", Gender = "Female", Salary = 60000,
                              Technology = new List<string>() {"C#", "Jave", "C++"} },
                new WhereFilter {ID = 102, Name = "Priyanka", Gender = "Female", Salary = 50000,
                              Technology =new List<string>() { "WCF", "SQL Server", "C#" } },
                new WhereFilter {ID = 103, Name = "Hina", Gender = "Female", Salary = 40000,
                              Technology =new List<string>() { "MVC", "Jave", "LINQ"}},
                new WhereFilter {ID = 104, Name = "Anurag", Gender = "Male", Salary = 450000},
                new WhereFilter {ID = 105, Name = "Sambit", Gender = "Male", Salary = 550000},
                new WhereFilter {ID = 106, Name = "Sushanta", Gender = "Male", Salary = 700000,
                             Technology =new List<string>() { "ADO.NET", "C#", "LINQ" }}
            };
            return employees;
        }
        public void Example()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Method Syntax
            List<int> filteredData = intList.Where(num => num > 5).ToList();
            //Query Syntax
            IEnumerable<int> filteredResult = from num in intList
                                              where num > 5
                                              select num;

            foreach (int number in filteredData)
            {
                Console.WriteLine(number);
            }
        }

        public void WhereWithComplexTypes()
        {
            //Query Syntax
            var QuerySyntax = from employee in WhereFilter.GetEmployees()
                              where employee.Salary > 50000
                              select employee;
            //Method Syntax
            var MethodSyntax = WhereFilter.GetEmployees()
                               .Where(emp => emp.Salary > 50000);

            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine($"Name : {emp.Name}, Salary : {emp.Salary}, Gender : {emp.Gender}");
                if (emp.Technology != null && emp.Technology.Count() > 0)
                {
                    Console.Write(" Technology : ");
                    foreach (var tech in emp.Technology)
                    {
                        Console.Write(tech + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(" Technology Not Available ");
                }
            }
        }

        public void MultiCondtion()
        {
            //Query Syntax
            var QuerySyntax = from employee in WhereFilter.GetEmployees()
                              where employee.Salary > 500000 && employee.Gender == "Male"
                              select employee;
            //Method Syntax
            var MethodSyntax = WhereFilter.GetEmployees()
                               .Where(emp => emp.Salary > 500000 && emp.Gender == "Male")
                               .ToList();

            foreach (var emp in MethodSyntax)
            {
                Console.WriteLine($"Name : {emp.Name}, Salary : {emp.Salary}, Gender : {emp.Gender}");
                if (emp.Technology != null && emp.Technology.Count() > 0)
                {
                    Console.Write(" Technology : ");
                    foreach (var tech in emp.Technology)
                    {
                        Console.Write(tech + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(" Technology Not Available ");
                }
            }
        }
    }
}
