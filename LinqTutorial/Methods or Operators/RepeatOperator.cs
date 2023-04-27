using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class RepeatOperator
    {
        public void Example()
        {
            //Repeating the string value Welcome to DOT NET Tutorials for 10 Times
            //Using the Repeat Method
            IEnumerable<string> repeatStrings = Enumerable.Repeat("Welcome to Tech Yatra Programming Tutorials", 10);
            //Accessing the collection or sequence using a foreach loop
            foreach (string str in repeatStrings)
            {
                Console.WriteLine(str);
            }
        }

        public void ExampleIfWePassNegativeCount()
        {
            // Repeating the string value Welcome to DOT NET Tutorials for 10 Times
            //Using the Repeat Method
            IEnumerable<string> repeatStrings =
                Enumerable.Repeat("Welcome to DOT NET Tutorials", -5);
            //Accessing the collection or sequence using a foreach loop
            foreach (string str in repeatStrings)
                {
                    Console.WriteLine(str);
                }
        }
    }
}
