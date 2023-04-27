using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class EmptyOperator
    {
        public void Example()
        {
            //Creating Empty Collection of Strings
            IEnumerable<string> emptyCollection1 = Enumerable.Empty<string>();
            //Creating Empty Collection of Student
            IEnumerable<Student> emptyCollection2 = Enumerable.Empty<Student>();
            //Printing the Type and Count of emptyCollection1
            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            //Printing the Type and Count of emptyCollection2
            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
        }

        public void Example2()
        {
            IEnumerable<int> integerSequence = GetData();
            if (integerSequence != null)
            {
                foreach (var num in integerSequence)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public void Example3()
        {
            IEnumerable<int> integerSequence = GetData() ?? Enumerable.Empty<int>(); ;
            foreach (var num in integerSequence)
            {
                Console.WriteLine(num);
            }
        }

        private static IEnumerable<int> GetData()
        {
            return null;
        }
    }
}
