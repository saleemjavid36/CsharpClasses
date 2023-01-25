using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Loops
{
    internal class ForEach
    {
        public void ForEachLoopExample()
        {
            //creating an array
            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            // foreach loop begin iit will run till the as element of the array
            foreach (int item in a_array)
            {
                Console.WriteLine(item);
            }

        }

    }
}
