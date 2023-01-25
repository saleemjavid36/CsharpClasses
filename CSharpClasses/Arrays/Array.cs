using System;
using System.Linq;

namespace CSharpClasses.Arrays
{
    internal class Array
    {
        public void ArrayExample()
        {
            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };
            
            // Declare an array
            string[] cars4;

            // Add values, using new
            cars4 = new string[] { "Volvo", "BMW", "Ford" };

            // Add values without using new (this will cause an error)
            //cars4 = { "Volvo", "BMW", "Ford"};

            // how to access element of an array
            Console.WriteLine(cars[0]);
            // Outputs Volvo

            // how to assign the element at a purticular index of array
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            // Now outputs Opel instead of Volvo

            // how to check the length of an array
            Console.WriteLine(cars.Length);
            // Outputs 4

            //other methods
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            //iteration using loop
            foreach(int i in myNumbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
