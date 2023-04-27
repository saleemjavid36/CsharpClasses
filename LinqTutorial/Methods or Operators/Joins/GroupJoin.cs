using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators.Joins
{
    internal class GroupJoin
    {
        public void Example()
        {
            //Group Employees by Department using Method Syntax
            var GroupJoinMS = Department.GetAllDepartments(). //Outer Data Source i.e. Departments
                GroupJoin( 
                    EmployeeData.GetAllEmployeesForJoin(), //Inner Data Source
                    dept => dept.ID, //Outer Key Selector  i.e. the Common Property
                    emp => emp.DepartmentId, //Inner Key Selector  i.e. the Common Property
                    (dept, emp) => new { dept, emp } //Projecting the Result to an Anonymous Type
                );
            //Printing the Result set
            //Outer Foreach is for Each department
            foreach (var item in GroupJoinMS)
            {
                Console.WriteLine("Department :" + item.dept.Name);
                //Inner Foreach loop for each employee of a Particular department
                foreach (var employee in item.emp)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
        }

        public void ExampleUsingQuerySyntax()
        {
            //Group Employees by Department using Query Syntax
            var GroupJoinQS = from dept in Department.GetAllDepartments() //Outer Data Source i.e. Departments
                              join emp in EmployeeData.GetAllEmployeesForJoin() //Joining with Inner Data Source i.e. Employees
                              on dept.ID equals emp.DepartmentId //Joining Condition
                              into EmployeeGroups //Projecting the Joining Result into EmployeeGroups
                              //Final Result include each department and the corresponding employees
                              select new { dept, EmployeeGroups };
            //Printing the Result set
            //Outer Foreach is for Each department
            foreach (var item in GroupJoinQS)
            {
                Console.WriteLine("Department :" + item.dept.Name);
                //Inner Foreach loop for each employee of a Particular department
                foreach (var employee in item.EmployeeGroups)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
        }
    }
}
