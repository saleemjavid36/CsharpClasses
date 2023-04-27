using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators.Joins
{
    internal class LeftJoin
    {
        public void LeftJoinExample()
        {
            //Performing Left Outer Join using LINQ using Query Syntax
            //Left Data Source: Employees
            //Right Data Source: Addresses
            //Note: Left and Right Data Source Matters
            var QSOuterJoin = from emp in EmployeeData.GetAllEmployees() //Left Data Source
                              join add in Address.GetAllAddresses() //Right Data Source
                              on emp.AddressId equals add.ID //Inner Join Condition
                              into EmployeeAddressGroup //Performing LINQ Group Join
                              from address in EmployeeAddressGroup.DefaultIfEmpty() //Performing Left Outer Join
                              select new { emp, address }; //Projecting the Result to Anonymous Type
            //Accessing the Elements using For Each Loop
            foreach (var item in QSOuterJoin)
            {
                //Before Accessing the AddressLine, please check null else you will get Null Reference Exception
                Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
            }
        }

        public void ProjectingTheResult()
        {
            //Performing Left Outer Join using LINQ using Query Syntax
            //Left Data Source: Employees
            //Right Data Source: Addresses
            //Note: Left and Right Data Source Matters
            var QSOuterJoin = from emp in EmployeeData.GetAllEmployees() //Left Data Source
                              join add in Address.GetAllAddresses() //Right Data Source
                              on emp.AddressId equals add.ID //Inner Join Condition
                              into EmployeeAddressGroup //Performing LINQ Group Join
                              from address in EmployeeAddressGroup.DefaultIfEmpty() //Performing Left Outer Join

                                  //Projecting the Result to Named Type
                              select new EmployeeResult
                              {
                                  Employee = emp,
                                  Address = address
                              };
            //Accessing the Elements using For Each Loop
            foreach (var item in QSOuterJoin)
            {
                //Before Accessing the AddressLine, please check null else you will get Null Reference Exception
                Console.WriteLine($"Name : {item.Employee.Name}, Address : {item.Address?.AddressLine} ");
            }
        }

        public void LeftJoinUsingMethodSyntax()
        {
            //Performing Left Outer Join using LINQ using Method Syntax
            //Left Data Source: Employees
            //Right Data Source: Addresses
            //Note: Left and Right Data Source Matters
            var MSOuterJOIN = EmployeeData.GetAllEmployees() //Left Data Source
                                                         //Performing Group join with Right Data Source
                              .GroupJoin(
                                    Address.GetAllAddresses(), //Right Data Source
                                    employee => employee.AddressId, //Outer Key Selector, i.e. Left Data Source Common Property
                                    address => address.ID, //Inner Key Selector, i.e. Right Data Source Common Property
                                    (employee, address) => new { employee, address } //Projecting the Result
                              )
                              .SelectMany(
                                    x => x.address.DefaultIfEmpty(), //Performing Left Outer Join 
                                    (employee, address) => new { employee, address } //Final Result Set
                               );
            //Accessing the Elements using For Each Loop
            foreach (var item in MSOuterJOIN)
            {
                Console.WriteLine($"Name : {item.employee.employee.Name}, Address : {item.address?.AddressLine} ");
            }

        }
    }
}
