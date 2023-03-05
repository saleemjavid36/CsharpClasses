using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Tuple
{
    internal class TupleExample
    {
        public void Example()
        {
            var values = new List<double>() { 10, 20, 30, 40, 50 };
            var result = Calulate(values);
            Console.WriteLine($"There are {result.Item1} values and their sum is {result.Item2}");
        }

        private static (int, double) Calulate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }
            return (count, sum);
        }
    }
}
