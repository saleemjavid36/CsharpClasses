
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class ToListAndToArrayOperator
    {
        public void ToListExample()
        {
            //Creating Integer Array
            int[] numbersArray = { 10, 22, 30, 40, 50, 60 };
            //Converting Integer Array to List using ToList method
            List<int> numbersList = numbersArray.ToList();
            //Accessing the List Elements
            foreach (var num in numbersList)
            {
                Console.Write($"{num} ");
            }
        }
        public void ToListWithComplexType()
        {
            //Create an Array of Employees
            Employees[] EmployeesArray = new Employees[]
            {
                new Employees() {ID = 1, Name = "Nishant", Department = "IT" },
                new Employees() {ID = 2, Name = "Priyanka", Department = "HR" },
                new Employees() {ID = 3, Name = "Preety", Department = "HR" },
                new Employees() {ID = 4, Name = "Sambit", Department = "IT" },
                new Employees() {ID = 5, Name = "Sudhanshu", Department = "IT"}
            };
            //Converting Array to List
            List<Employees> EmployeesList = EmployeesArray.ToList();
            //Accessing the Elements of the List
            foreach (var emp in EmployeesArray)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}");
            }
        }

        public void ToListWhenDataSourceIsNull()
        {
            //Creating Integer Array and Initializing it with NULL
            int[] numbersArray = null;
            //Converting Integer Array to List using ToList method
            List<int> numbersList = numbersArray.ToList();
            //Accessing the List Elements
            foreach (var num in numbersList)
            {
                Console.Write($"{num} ");
            }
        }

        public void ToArrayExample()
        {
            //Create a List
            List<int> numbersList = new List<int>()
            {
                10, 22, 30, 40, 50, 60
            };
            //Converting List to Array
            int[] numbersArray = numbersList.ToArray();
            //Accessing the Elements of the Array
            foreach (var num in numbersArray)
            {
                Console.Write($"{num} ");
            }
        }

        public void ToArrayWithComplexType()
        {
            //Create a List of Employees
            List<Employees> EmployeesList = new List<Employees>()
            {
                new Employees() {ID = 1, Name = "Pranaya", Department = "IT" },
                new Employees() {ID = 2, Name = "Priyanka", Department = "HR" },
                new Employees() {ID = 3, Name = "Preety", Department = "HR" },
                new Employees() {ID = 4, Name = "Sambit", Department = "IT" },
                new Employees() {ID = 5, Name = "Sudhanshu", Department = "IT"}
            };
            //Converting List to Array
            Employees[] EmployeesArray = EmployeesList.ToArray();
            //Accessing the Elements of the Array
            foreach (var emp in EmployeesArray)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}");
            }
        }

        public void ToArrayWhenDataSourceIsNull()
        {
            //Create a List
            List<int> numbersList = null;
            //Converting List to Array
            int[] numbersArray = numbersList.ToArray();
            //Accessing the Elements of the Array
            foreach (var num in numbersArray)
            {
                Console.Write($"{num} ");
            }

        }
    }
}
