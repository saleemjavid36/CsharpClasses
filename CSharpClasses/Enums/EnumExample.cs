using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Enums
{

    class EnumExample
    {
        public void Example()
        {
            //Create a collection to store employees
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Name = "Anurag", Gender = 0 });
            empList.Add(new Employee() { Name = "Pranaya", Gender = 1 });
            empList.Add(new Employee() { Name = "Priyanka", Gender = 2 });
            empList.Add(new Employee() { Name = "Sambit", Gender = 3 });

            //Loop through each employees and print the Name and Gender
            foreach (var emp in empList)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", emp.Name, GetGender(emp.Gender));
            }
        }
        //This method is used to return the Gender 
        public static string GetGender(int gender)
        {
            // The switch here is now more readable and maintainable because 
            // of replacing the integral numbers with Gender enum
            switch (gender)
            {
                case (int)Gender.Unknown:
                    return "Unknown";
                case (int)Gender.Male:
                    return "Male";
                case (int)Gender.Female:
                    return "Female";
                default:
                    return "Invalid Data for Gender";
            }
        }
    }
    // 0 - Unknown
    // 1 - Male
    // 2 - Female
 
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
