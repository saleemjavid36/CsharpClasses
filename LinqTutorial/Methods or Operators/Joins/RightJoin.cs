using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators.Joins
{
    internal class RightJoin
    {
        public void Example()
        {
            //Performing Right Outer Join using LINQ using Query Syntax
            //Changing the Data Sources
            //Left Data Source: Addresses 
            //Right Data Source: Employees
            //Note: Left and Right Data Source Matters
            var QSRightJoin = from add in Address.GetAllAddresses()  //Left Data Source
                              join emp in EmployeeData.GetAllEmployees() //Right Data Source
                              on add.ID equals emp.AddressId //Inner Join Condition
                              into EmployeeAddressGroup //Performing LINQ Group Join
                              from employee in EmployeeAddressGroup.DefaultIfEmpty() //Performing Left Outer Join
                              select new { add, employee }; //Projecting the Result to Anonymous Type
            //Accessing the Elements using For Each Loop
            foreach (var item in QSRightJoin)
            {
                //Before Accessing the AddressLine, please check null else you will get Null Reference Exception
                Console.WriteLine($"Name : {item.employee?.Name}, Address : {item.add?.AddressLine} ");
            }
        }
    }
}
