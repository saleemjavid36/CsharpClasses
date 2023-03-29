
using CSharpClasses.Indexers;
using CSharpClasses.Solid_Principles.DIP.Example_With_DIP;
using CSharpClasses.Solid_Principles.ISP;
using CSharpClasses.Solid_Principles.LSP;
using CSharpClasses.Solid_Principles.OCP;
using CSharpClasses.Solid_Principles.DIP;
using System;
using Employee = CSharpClasses.Solid_Principles.DIP.Employee;

namespace CSharpClasses
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            try
            {
                EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
                Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");


            }
            catch (Exception ex)
            {
                Console.WriteLine("some error occured");
            }
        }
        
    }
}