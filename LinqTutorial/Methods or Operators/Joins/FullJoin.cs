using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators.Joins
{
    internal class FullJoin
    {
        public void Example()
        {
            //Full Outer Join = Left Outer Join UNION Right Outer Join
            //Performinng Left Outer Join
            var LeftOuterJoin = from emp in EmployeeData.GetAllEmployees()
                                join dept in Department.GetAllDepartments()
                                on emp.DepartmentId equals dept.ID into EmployeeDepartmentGroup
                                from department in EmployeeDepartmentGroup.DefaultIfEmpty()
                                select new
                                {
                                    //To Avoid Runtime Null Reference Exception, check NULL 
                                    EmployeeId = emp?.ID,
                                    EmployeeName = emp?.Name,
                                    DepartmentName = department?.Name
                                };
            var RightOuterJoin = from dept in Department.GetAllDepartments()
                                 join emp in EmployeeData.GetAllEmployees()
                                 on dept.ID equals emp.DepartmentId into EmployeeDepartmentGroup
                                 from employee in EmployeeDepartmentGroup.DefaultIfEmpty()
                                 select new
                                 {
                                     //To Avoid Runtime Null Reference Exception, check NULL 
                                     EmployeeId = employee?.ID,
                                     EmployeeName = employee?.Name,
                                     DepartmentName = dept?.Name
                                 };
            var FullOuterJoin = LeftOuterJoin.Union(RightOuterJoin);
            foreach (var emp in FullOuterJoin)
            {
                Console.WriteLine($"EmployeeId: {emp.EmployeeId}, Name: {emp.EmployeeName}, Department: {emp.DepartmentName}");
            }
        }

        public void FullJoinUsingMethodSyntax()
        {
            //Performing Left Outer Join using LINQ using Method Syntax
            var MSLeftOuterJOIN = EmployeeData.GetAllEmployees() //Left Data Source
                                                             //Performing Group join with Right Data Source
                              .GroupJoin(
                                    Department.GetAllDepartments(), //Right Data Source
                                    employee => employee.DepartmentId, //Outer Key Selector, i.e. Left Data Source Common Property
                                    department => department.ID, //Inner Key Selector, i.e. Right Data Source Common Property
                                    (employee, department) => new { employee, department } //Projecting the Result
                              )
                              .SelectMany(
                                    x => x.department.DefaultIfEmpty(), //Performing Left Outer Join 
                                                                        //Final Result Set
                                    (employee, department) => new
                                    {
                                        EmployeeId = employee?.employee?.ID,
                                        EmployeeName = employee?.employee?.Name,
                                        DepartmentName = department?.Name
                                    }
                               );
            //Performing Right Outer Join using LINQ using Method Syntax
            var MSRightOuterJOIN = Department.GetAllDepartments() //Left Data Source
                                                                  //Performing Group join with Right Data Source
                              .GroupJoin(
                                    EmployeeData.GetAllEmployees(), //Right Data Source
                                    department => department.ID, //Outer Key Selector, i.e. Left Data Source Common Property
                                    employee => employee.DepartmentId, //Inner Key Selector, i.e. Right Data Source Common Property
                                    (department, employee) => new { department, employee } //Projecting the Result
                              )
                              .SelectMany(
                                    x => x.employee.DefaultIfEmpty(), //Performing Left Outer Join 
                                                                      //Final Result Set
                                    (department, employee) => new
                                    {
                                        EmployeeId = employee?.ID,
                                        EmployeeName = employee?.Name,
                                        DepartmentName = department?.department?.Name
                                    }
                               );
            var FullOuterJoin = MSLeftOuterJOIN.Union(MSRightOuterJOIN);
            //Accessing the Elements using For Each Loop
            foreach (var emp in FullOuterJoin)
            {
                Console.WriteLine($"EmployeeId: {emp.EmployeeId}, Name: {emp.EmployeeName}, Department: {emp.DepartmentName}");
            }
        }
    }
}
