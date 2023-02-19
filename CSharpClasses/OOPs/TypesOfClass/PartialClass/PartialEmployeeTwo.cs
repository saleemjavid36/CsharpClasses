using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.TypesOfClass.PartialClass
{
    public partial class PartialEmployee: Parent2
    {
        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name is : {FirstName} {LastName}");
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine($"First Name : {FirstName}");
            Console.WriteLine($"Last Name : {LastName}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Salary : {Salary}");
        }
    }
    public class Parent2 { 
    public string Name { get; set; }
    }
}
