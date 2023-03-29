using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Solid_Principles.DIP
{
    internal class EmployeeDataAccessLogic
    {
        public Employee GetEmployeeDetails(int id)
        {
            //In real time get the employee details from database
            //but here we have hard coded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Nishant",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}
