using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpClasses.Indexers
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }
    public class Company
    {
        //Create a varibale to hold a list of employees
        private List<Employees> listEmployees;
        //Through the constructor initialize the listEmployees variable
        public Company()
        {
            listEmployees = new List<Employees>();
            listEmployees.Add(new Employees
            { EmployeeId = 101, Name = "Pranaya", Gender = "Male", Salary = 1000 });
            listEmployees.Add(new Employees
            { EmployeeId = 102, Name = "Preety", Gender = "Female", Salary = 2000 });
            listEmployees.Add(new Employees
            { EmployeeId = 103, Name = "Anurag", Gender = "Male", Salary = 5000 });
            listEmployees.Add(new Employees
            { EmployeeId = 104, Name = "Priyanka", Gender = "Female", Salary = 4000 });
            listEmployees.Add(new Employees
            { EmployeeId = 105, Name = "Hina", Gender = "Female", Salary = 3000 });
            listEmployees.Add(new Employees
            { EmployeeId = 106, Name = "Sambit", Gender = "Male", Salary = 6000 });
            listEmployees.Add(new Employees
            { EmployeeId = 107, Name = "Tarun", Gender = "Male", Salary = 8000 });
            listEmployees.Add(new Employees
            { EmployeeId = 108, Name = "Santosh", Gender = "Male", Salary = 7000 });
            listEmployees.Add(new Employees
            { EmployeeId = 109, Name = "Trupti", Gender = "Female", Salary = 5000 });
        }

        // The indexer takes an employeeId as parameter
        // and returns the employee name
        public string this[int employeeId]
        {
            get
            {
                return listEmployees.
                    FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.
                    FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }
        public string this[string gender]
        {
            get
            {
                // Returns the total count of employees whose gender matches
                // with the gender that is passed in.
                return listEmployees.Count(x => x.Gender.ToLower() == gender.ToLower()).ToString();
            }
            set
            {
                // Changes the gender of all employees whose gender matches
                // with the gender that is passed in.
                foreach (Employees employee in listEmployees)
                {
                    if (employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
    class CallClassMethod
    {
        public void CallMethod()
        {
            Company company = new Company();
            Console.WriteLine("Name of Employee with Id = 101: " + company[101]);
            Console.WriteLine();
            Console.WriteLine("Name of Employee with Id = 105: " + company[105]);
            Console.WriteLine();
            Console.WriteLine("Name of Employee with Id = 107: " + company[107]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Changing the names of employees with Id = 101,105,107");
            Console.WriteLine();
            company[101] = "Employee 101 Name Changed";
            company[105] = "Employee 105 Name Changed";
            company[107] = "Employee 107 Name Changed";
            Console.WriteLine("Name of Employee with Id = 101: " + company[101]);
            Console.WriteLine();
            Console.WriteLine("Name of Employee with Id = 105: " + company[105]);
            Console.WriteLine();
            Console.WriteLine("Name of Employee with Id = 107: " + company[107]);
        }

        public void CallBothIndexers()
        {
                Company company = new Company();
                Console.WriteLine("Before changing the Gender of all the male employees to Female");
                Console.WriteLine();
                // Get accessor of string indexer is invoked to return the total count of male employees
                Console.WriteLine("Total Number Employees with Gender = Male:" + company["Male"]);
                Console.WriteLine();
                Console.WriteLine("Total Number Employees with Gender = Female:" + company["Female"]);
                Console.WriteLine();

                // Set accessor of string indexer is invoked to change the gender all "Male" employees to "Female"
                company["Male"] = "Female";
                Console.WriteLine("After changing the Gender of all male employees to Female");
                Console.WriteLine();
                Console.WriteLine("Total Employees with Gender = Male:" + company["Male"]);
                Console.WriteLine();
                Console.WriteLine("Total Employees with Gender = Female:" + company["Female"]);
        }
    }
}
