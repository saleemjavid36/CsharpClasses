using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Out_Keyword
{
    internal class OutExample
    {
        public void Example()
        {
            string Gender, Department;
            long Salary;

            GetEmployeeDetails(out string EmployeeName, out Gender, out Salary, out Department);
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}, Department: {3}",
            EmployeeName, Gender, Salary, Department);
            Console.WriteLine("Press any key to exit.");
        }
        static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
            EmployeeName = "Pranaya Rout";
            Gender = "Male";
            Salary = 20000;
            Department = "IT";
        }
    }
}
 