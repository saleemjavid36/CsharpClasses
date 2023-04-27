using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LinqTutorial.Methods_or_Operators.Joins
{
    internal class InnerJoin
    {
       
        public void InnerJoinExample()
        {
            //Performing Inner Between Employees and Addresses Data Sources
            var JoinUsingMS = EmployeeData.GetAllEmployees() //Outer Data Source
                           .Join( //Performing LINQ Inner Join
                           Address.GetAllAddresses(),  //Outer Data Source
                           employee => employee.AddressId, //Outer Key Selector
                           address => address.ID, //Inner Key selector
                           (employee, address) => new //Projecting the data into an Annonymous Type
                           {
                               EmployeeName = employee.Name,
                               AddressLine = address.AddressLine
                           }).ToList();
            //Accessing the Result using For Each Loop
            foreach (var employee in JoinUsingMS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }

            //Query Syntax
            //Performing Inner Join Between Employees and Addresses Collections
            var JoinUsingQS = (from emp in EmployeeData.GetAllEmployees() //Outer Data Source
                               join address in Address.GetAllAddresses() //Joining with Inner Data Source
                               on emp.AddressId equals address.ID //Joining Condition
                               select new //Projecting the Result to an Anonymous Type
                               {
                                   EmployeeName = emp.Name,
                                   AddressLine = address.AddressLine
                               }).ToList();
            //Accessing the Elements using Foreach Loop
            foreach (var employee in JoinUsingQS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }

        }

        public void InnerJoinProjection()
        {
            // Performing Inner Between Employee and Addresses Data Sources
            var JoinUsingMS = Address.GetAllAddresses()  //Outer Data Source
                           .Join( //Performing LINQ Inner Join
                           EmployeeData.GetAllEmployees(),  //Outer Data Source
                           address => address.ID,   //Outer Key Selector
                           employee => employee.AddressId, //Inner Key selector
                           (address, employee) => new EmployeeAddress //Projecting the data to named type i.e. EmployeeAddress
                           {
                               EmployeeName = employee.Name,
                               AddressLine = address.AddressLine
                           }).ToList();
            //Accessing the Result using For Each Loop
            foreach (var employee in JoinUsingMS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }

            //query syntax
            //Performing Inner Join Between Employees and Addresses Collections
            var JoinUsingQS = (from emp in EmployeeData.GetAllEmployees() //Outer Data Source
                               join address in Address.GetAllAddresses() //Joining with Inner Data Source
                               on emp.AddressId equals address.ID //Joining Condition
                               select new EmployeeAddress//Projecting the Result to EmployeeAddress Type
                               {
                                   EmployeeName = emp.Name,
                                   AddressLine = address.AddressLine
                               }).ToList();
            //Accessing the Elements using Foreach Loop
            foreach (var employee in JoinUsingQS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
        }
    }

    public class EmployeeData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int DepartmentId { get; set; }
        public static List<EmployeeData> GetAllEmployeesForJoin()
        {
            return new List<EmployeeData>()
            {
                new EmployeeData { ID = 1, Name = "Preety", DepartmentId = 10},
                new EmployeeData { ID = 2, Name = "Priyanka", DepartmentId =20},
                new EmployeeData { ID = 3, Name = "Anurag", DepartmentId = 30},
                new EmployeeData { ID = 4, Name = "Pranaya", DepartmentId = 30},
                new EmployeeData { ID = 5, Name = "Hina", DepartmentId = 20},
                new EmployeeData { ID = 6, Name = "Sambit", DepartmentId = 10},
                new EmployeeData { ID = 7, Name = "Happy", DepartmentId = 10},
                new EmployeeData { ID = 8, Name = "Tarun", DepartmentId = 0},
                new EmployeeData { ID = 9, Name = "Santosh", DepartmentId = 10},
                new EmployeeData { ID = 10, Name = "Raja", DepartmentId = 20},
                new EmployeeData { ID = 11, Name = "Ramesh", DepartmentId = 30}
            };
        }

        public static List<EmployeeData> GetAllEmployees()
        {
            return new List<EmployeeData>()
            {
                new EmployeeData { ID = 1, Name = "Preety", AddressId = 1 },
                new EmployeeData { ID = 2, Name = "Priyanka", AddressId = 2 },
                new EmployeeData { ID = 3, Name = "Anurag", AddressId = 3 },
                new EmployeeData { ID = 4, Name = "Pranaya", AddressId = 4 },
                new EmployeeData { ID = 5, Name = "Hina", AddressId = 5 },
                new EmployeeData { ID = 6, Name = "Sambit", AddressId = 6 },
                new EmployeeData { ID = 7, Name = "Happy", AddressId = 7},
                new EmployeeData { ID = 8, Name = "Tarun", AddressId = 8 },
                new EmployeeData { ID = 9, Name = "Santosh", AddressId = 9 },
                new EmployeeData { ID = 10, Name = "Raja", AddressId = 10},
                new EmployeeData { ID = 11, Name = "Sudhanshu", AddressId = 11}
            };
        }
    }

    public class Address
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
        public static List<Address> GetAllAddresses()
        {
            return new List<Address>()
            {
                new Address { ID = 1, AddressLine = "AddressLine1"},
                new Address { ID = 2, AddressLine = "AddressLine2"},
                new Address { ID = 3, AddressLine = "AddressLine3"},
                new Address { ID = 4, AddressLine = "AddressLine4"},
                new Address { ID = 5, AddressLine = "AddressLine5"},
                new Address { ID = 9, AddressLine = "AddressLine9"},
                new Address { ID = 10, AddressLine = "AddressLine10"},
                new Address { ID = 11, AddressLine = "AddressLine11"},
            };
        }
    }
    class EmployeeAddress
    {
        public string EmployeeName { get; set; }
        public string AddressLine { get; set; }
    }
    class EmployeeResult
    {
        public EmployeeData Employee { get; set; }
        public Address Address { get; set; }
    }
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { ID = 10, Name = "IT"},
                new Department { ID = 20, Name = "HR"},
                new Department { ID = 30, Name = "Sales"  },
            };
        }
    }

}
