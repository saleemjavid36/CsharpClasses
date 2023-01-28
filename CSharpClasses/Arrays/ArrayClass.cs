using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace CSharpClasses.Arrays
{
    public class ArrayClass
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
            Console.WriteLine("Element at zero index in cars array - " + cars4[0]);
            // Outputs Volvo

            // how to assign the element at a purticular index of array
            cars4[0] = "Opel";
            Console.WriteLine("element at 0 index after updating value - " + cars4[0]);
            // Now outputs Opel instead of Volvo

            // how to check the length of an array
            Console.WriteLine(" length of the array - " + cars.Length);
            // Outputs 4

            //other methods
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine("Max - " + myNumbers.Max());  // returns the largest value
            Console.WriteLine("Min - " + myNumbers.Min());  // returns the smallest value
            Console.WriteLine("Sum - " + myNumbers.Sum());  // returns the sum of elements

            //iteration using loop
            foreach(int i in myNumbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
