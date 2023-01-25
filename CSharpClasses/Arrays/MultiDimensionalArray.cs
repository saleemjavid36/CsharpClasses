using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Arrays
{
    internal class MultiDimensionalArray
    {
        public void MultiDimensionalArrayExample()
        {
            //initializing 2D array
            int[,] numbers = { { 2, 3 }, { 4, 5 } };

            // access first element from the first row
            Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);

            // access first element from second row
            Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);

            // old element
            Console.WriteLine("Old element at index [0, 0] : " + numbers[0, 0]);

            // assigning new value
            numbers[0, 0] = 222;

            // new element
            Console.WriteLine("New element at index [0, 0] : " + numbers[0, 0]);
        }
    }
}
