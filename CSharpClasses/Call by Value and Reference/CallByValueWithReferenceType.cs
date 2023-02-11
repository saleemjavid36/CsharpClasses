using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Call_by_Value_and_Reference
{
    internal class CallByValueWithReferenceType
    {
        public void Example ()
        {
            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 1001;
            Emp1.Name = "James";
            UpdateName(Emp1);
            //Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            //Employee Emp2 = Emp1;
            Emp1.Name = "Smith";
            Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            //Console.WriteLine($"Emp2 Name = {Emp2.Name}");
        }
        public static void UpdateName(Employee Emp2)
        {
            //Emp2.Name = "Smith";
            Emp2 = null;
        }
    }
public class Employee
{
    public int EmployeeID;
    public string Name;
}
}
