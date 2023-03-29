using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Collections.Generic_List
{
    internal class ListWithComplexTypes
    {
        public void Example()
        {
            // Create Employee Objects
            Employee emp1 = new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 };
            Employee emp2 = new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 };
            Employee emp3 = new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 };

            // Create a Generic List of type Employee
            List<Employee> listEmployees = new List<Employee>();
            //Adding Employees to the listEmployees collection using Add Method
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            Console.WriteLine("Retrive the First Employee By Index");
            //Retrieving Items from the collection by using Index. 
            //The following line of code will retrieve the employee from the list. 
            //The List index is  0 based.
            Employee FirstEmployee = listEmployees[0]; //Fetch the First Added Employee from the Collection
            Console.WriteLine($"ID = {FirstEmployee.ID}, Name = {FirstEmployee.Name}, Gender = {FirstEmployee.Gender}, Salary = {FirstEmployee.Salary}");
            //Retrieving All Employees of Generic List Collection using For loop
            Console.WriteLine("\nRetrieving All Employees using For Loop");
            for (int i = 0; i < listEmployees.Count; i++)
            {
                Employee employee = listEmployees[i];
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            //Retrieving All Employees of Generic List Collection using For Each loop
            Console.WriteLine("\nRetrieving All Employees using For Each Loop");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            //Inserting an Employee into the Index Position 1.
            Employee emp4 = new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 };
            listEmployees.Insert(1, emp4);
            //Retrieving the list after inserting the employee in index position 1
            Console.WriteLine("\nRetriving the List After Inserting New Employee in Index 1");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            //If you want to get the index postion of a specific employee then use Indexof() method as follows
            Console.WriteLine("\nIndex of emp3 object in the List = " + listEmployees.IndexOf(emp3));
        }

        public void FindMethods()
        {
            // Create Employee Objects
            Employee Employee1 = new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 };
            Employee Employee2 = new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 };
            Employee Employee3 = new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 };
            Employee Employee4 = new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 };
            //Creating a list of type Employee
            List<Employee> listEmployees = new List<Employee>
            {
                Employee1,
                Employee2,
                Employee3,
                Employee4
            };
            // use Contains method to check if an item exists or not in the list 
            Console.WriteLine("Contains Method Check Employee2 Object");
            if (listEmployees.Contains(Employee2))
            {
                Console.WriteLine("Employee2 Object Exists in the List");
            }
            else
            {
                Console.WriteLine("Employee2 Object Does Not Exists in the List");
            }
            // Use Exists method when you want to check if an item exists or not
            // in the list based on a condition
            Console.WriteLine("\nExists Method Name StartsWith P");
            if (listEmployees.Exists(x => x.Name.StartsWith("P")))
            {
                Console.WriteLine("List contains Employees whose Name Starts With P");
            }
            else
            {
                Console.WriteLine("List does not Contain Any Employee whose Name Starts With P");
            }
            // Use Find() method, if you want to return the First Matching Element by a conditions 
            Console.WriteLine("\nFind Method to Return First Matching Employee whose Gender = Male");
            Employee? emp = listEmployees.Find(employee => employee.Gender == "Male");
            Console.WriteLine($"ID = {emp?.ID}, Name = {emp?.Name}, Gender = {emp?.Gender}, Salary = {emp?.Salary}");
            // Use FindLast() method when you want to searche an item by a conditions and returns the Last matching item from the list
            Console.WriteLine("\nFindLast Method to Return Last Matching Employee whose Gender = Male");
            Employee? lastMatchEmp = listEmployees.FindLast(employee => employee.Gender == "Male");
            Console.WriteLine($"ID = {lastMatchEmp?.ID}, Name = {lastMatchEmp?.Name}, Gender = {lastMatchEmp?.Gender}, Salary = {lastMatchEmp?.Salary}");
            // Use FindAll() method when you want to return all the items that matches the conditions
            Console.WriteLine("\nFindAll Method to return All Matching Employees Where Gender = Male");
            List<Employee> filteredEmployees = listEmployees.FindAll(employee => employee.Gender == "Male");
            foreach (Employee femp in filteredEmployees)
            {
                Console.WriteLine($"ID = {femp.ID}, Name = {femp.Name}, Gender = {femp.Gender}, Salary = {femp.Salary}");
            }

            // Use FindIndex() method when you want to return the index of the first item by a condition
            Console.WriteLine($"\nIndex of the First Matching Employee whose Gender is Male = {listEmployees.FindIndex(employee => employee.Gender == "Male")}");

            // Use FindLastIndex() method when you want to return the index of the last item by a condition
            Console.WriteLine($"Index of the Last Matching Employee whose Gender is Male = {listEmployees.FindLastIndex(employee => employee.Gender == "Male")}");
        }

        public void SortAndReverseMethods()
        {
                List<int> numbersList = new List<int> { 1, 8, 7, 5, 2 };
                Console.WriteLine("Numbers Before Sorting");
                foreach (int i in numbersList)
                {
                    Console.Write($"{i} ");
                }
                // The Sort() of List Collection class will sort the data in ascending order 
                numbersList.Sort();
                Console.WriteLine("\n\nNumbers After Sorting");
                foreach (int i in numbersList)
                {
                    Console.Write($"{i} ");
                }
                // If you want to  to retrieve data in descending order then use the Reverse() method
                numbersList.Reverse();
                Console.WriteLine("\n\nNumbers in Descending order");
                foreach (int i in numbersList)
                {
                    Console.Write($"{i} ");
                }
                //Another Example of Sorting String
                List<string> names = new List<string>() { "Pranaya", "Anurag", "Sambit", "Hina", "Rakesh" };
                Console.WriteLine("\n\nNames Before Sorting");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                names.Sort();
                Console.WriteLine("\nNames After Sorting");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                names.Reverse();
                Console.WriteLine("\nNames in Descending Order");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }

    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }

}
