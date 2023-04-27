using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000 },
                new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 },
                new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 },
                new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 },
                new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 },
                new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000 }
            };
            return employees;
        }
    }
    public class SelectOperator
    {
        public void SelectMethod()
        {
            List<Employee> basicQuery = (from emp in Employee.GetEmployees()
                                         select emp).ToList();
            foreach (Employee emp in basicQuery)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }
            //Using Method Syntax
            IEnumerable<Employee> basicMethod = Employee.GetEmployees().ToList();
            foreach (Employee emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }
        }

        public void SelectSingleProperties()
        {
            List<int> basicPropQuery = (from emp in Employee.GetEmployees()
                                        select emp.ID)
                                        .ToList(); //At this Point the Query is Executed
            foreach (var id in basicPropQuery)
            {
                Console.WriteLine($"ID : {id}");
            }
            //Using Method Syntax
            IEnumerable<int> basicPropMethod = Employee.GetEmployees()
                                               .Select(emp => emp.ID);
            //At this Point the Query is Just Generated, Not Executed
            foreach (var id in basicPropMethod) //At this Point the Query is going to be Executed
            {
                Console.WriteLine($"ID : {id}");
            }
        }
    
    public void SelectMultiProperties()
        {
            //Query Syntax
            IEnumerable<Employee> selectQuery = (from emp in Employee.GetEmployees()
                                                 select new Employee()
                                                 {
                                                     FirstName = emp.FirstName,
                                                     LastName = emp.LastName,
                                                     Salary = emp.Salary
                                                 });

            foreach (var emp in selectQuery)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }

            //Method Syntax
            List<Employee> selectMethod = Employee.GetEmployees().
                                          Select(emp => new Employee()
                                          {
                                              FirstName = emp.FirstName,
                                              LastName = emp.LastName,
                                              Salary = emp.Salary
                                          }).ToList();
            foreach (var emp in selectMethod)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }
        }

        public void SelectAnonymousObjecr()
        {
            //Query Syntax
            var selectQuery = (from emp in Employee.GetEmployees()
                               select new
                               {
                                   FirstName = emp.FirstName,
                                   LastName = emp.LastName,
                                   Salary = emp.Salary
                               });

            foreach (var emp in selectQuery)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }

            //Method Syntax
            var selectMethod = Employee.GetEmployees().
                                          Select(emp => new
                                          {
                                              FirstName = emp.FirstName,
                                              LastName = emp.LastName,
                                              Salary = emp.Salary
                                          }).ToList();
            foreach (var emp in selectMethod)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }
        }
    }
}
