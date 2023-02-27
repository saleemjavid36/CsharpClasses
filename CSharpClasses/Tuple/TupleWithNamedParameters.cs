using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Tuple
{
    internal class TupleWithNamedParameters
    {
        public void Example()
        {
            var values = new List<double>() { 10, 20, 30, 40, 50 };
            var result = Calulate(values);
            Console.WriteLine($"There are {result.count} values and their sum is {result.sum}");
            Console.ReadKey();
        }

        private static (int count, double sum) Calulate(IEnumerable<double> values)
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
