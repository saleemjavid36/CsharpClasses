using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Delegates.Anonymous_Method
{
    internal class AnonymousMethodRealTimeExample
    {
        static void Example()
        {
            // Step 3: 
            // Create an instance of Predicate<Employee> delegate and 
            // pass the method name as an argument to the delegate constructor          
            Predicate<Employee> employeePredicate = new Predicate<Employee>(IsEmployeeExist);
            //Step4
            //Create a collection of List of Employees
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Pranaya", Gender = "Male", Salary = 100000},
                new Employee{ ID = 102, Name = "Priyanka", Gender = "Female", Salary = 200000},
                new Employee{ ID = 103, Name = "Anurag", Gender = "Male", Salary = 300000},
                new Employee{ ID = 104, Name = "Preety", Gender = "Female", Salary = 400000},
                new Employee{ ID = 104, Name = "Sambit", Gender = "Male", Salary = 500000},
            };
            // Step 5: 
            // Now pass the delegate instance as the
            // argument to the Find() method of List collection
            Employee employee = listEmployees.Find(x => employeePredicate(x));
            Console.WriteLine(@"ID : {0}, Name : {1}, Gender : {2}, Salary : {3}",
                employee.ID, employee.Name, employee.Gender, employee.Salary);
        }
        // Step 2: 
        // Create a method whose signature matches with the
        // signature of Predicate<Employee> generic delegate
        public static bool IsEmployeeExist(Employee Emp)
        {
            return Emp.ID == 103;
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }
    class AnonymousMethodExample
    {
        public void Example()
        {
            //Step2
            //Create a collection of List of Employees
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Pranaya", Gender = "Male", Salary = 100000},
                new Employee{ ID = 102, Name = "Priyanka", Gender = "Female", Salary = 200000},
                new Employee{ ID = 103, Name = "Anurag", Gender = "Male", Salary = 300000},
                new Employee{ ID = 104, Name = "Preety", Gender = "Female", Salary = 400000},
                new Employee{ ID = 104, Name = "Sambit", Gender = "Male", Salary = 500000},
            };
            // Step3
            // An anonymous method is being passed as an argument to
            // the Find() method of List Collection.
            Employee employee = listEmployees.Find(
                                    delegate (Employee x)
                                    {
                                        return x.ID == 103;
                                    }
                                );
            Console.WriteLine(@"ID : {0}, Name : {1}, Gender : {2}, Salary : {3}",
                employee.ID, employee.Name, employee.Gender, employee.Salary);
        }
    }
}
