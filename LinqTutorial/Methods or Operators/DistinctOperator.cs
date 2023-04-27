using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
        internal class DistinctOperator
    {
        public void DistinctExample()
        {
            List<int> intCollection = new List<int>()
            {
                1,2,3,2,3,4,4,5,6,3,4,5
            };
            //Using Method Syntax
            var MS = intCollection.Distinct();
            //Using Query Syntax
            var QS = (from num in intCollection
                      select num).Distinct();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public void DistinctWithString()
        {
            string[] namesArray = { "Priyanka", "HINA", "hina", "Anurag", "Anurag", "ABC", "abc" };
            var distinctNames = namesArray.Distinct();
            foreach (var name in distinctNames)
            {
                Console.WriteLine(name);
            }
        }

        public void DistinctWithString_IgnoreCaseSensative()
        {
            string[] namesArray = { "Priyanka", "HINA", "hina", "Anurag", "Anurag", "ABC", "abc" };
            var distinctNames = namesArray.Distinct(StringComparer.OrdinalIgnoreCase);
            foreach (var name in distinctNames)
            {
                Console.WriteLine(name);
            }
        }

        public void DistinctWithComplexTypes()
        {
            //Using Method Syntax
            var MS = Student.GetStudents()
                    .Select(std => std.Name)
                    .Distinct().ToList();
            //Using Query Syntax
            var QS = (from std in Student.GetStudents()
                      select std.Name)
                      .Distinct().ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }
    }
}
