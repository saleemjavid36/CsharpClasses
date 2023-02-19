using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.TypesOfClass.PartialClass
{
    public interface IEmployee
    {
        void EmployeeMethod();
    }
    public interface ICustomer
    {
        void CustomerMethod();
    }
    sealed partial class PartialEmployee: IEmployee, ICustomer
    {
        public void EmployeeMethod()
        {

        }
        public void CustomerMethod() { }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public void Display()
        {
            DisplayFullName();

        }
    }

   
}
