using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class RangeOperator
    {
        public void Example()
        {
            //Generating Intger Numbers from 1 to 10
            IEnumerable<int> numberSequence = Enumerable.Range(1, 10);
            //Accessing the numberSequence using Foreach Loop
            foreach (int num in numberSequence)
            {
                Console.Write($"{num} ");
            }
        }

        public void RangeWithWhere()
        {
            //Using Range with Where Extension Method
            IEnumerable<int> EvenNumbers = Enumerable.Range(10, 20).Where(x => x % 2 == 0).Select(s => s * s);
            //Printing the Even Numbers between 10 and 40
            foreach (int num in EvenNumbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
