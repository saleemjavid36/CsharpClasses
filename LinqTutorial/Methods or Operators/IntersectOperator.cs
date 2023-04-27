﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class IntersectOperator
    {

        public void Example()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            //Method Syntax
            var MS = dataSource1.Intersect(dataSource2).ToList();
            //Query Syntax
            var QS = (from num in dataSource1
                      select num)
                      .Intersect(dataSource2).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public void IntersectWithNullCollection()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = null;
            //Method Syntax
            var MS = dataSource1.Intersect(dataSource2).ToList();

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public void IntersectOperatorWithString()
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Intersect(dataSource2).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Intersect(dataSource2).ToList();
            foreach (var item in QS)
            {
                Console.WriteLine(item);
            }
        }

        public void IntersectOperatorWithIgnoringCase()
        {

            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Intersect(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Intersect(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var item in QS)
            {
                Console.WriteLine(item);
            }
        }

        public void IntersectOperatorWithComplexType()
        {
            List<Student> StudentCollection1 = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 105, Name = "Hina"},
                new Student {ID = 106, Name = "Anurag"},
            };
            List<Student> StudentCollection2 = new List<Student>()
            {
                new Student {ID = 105, Name = "Hina"},
                new Student {ID = 106, Name = "Anurag"},
                new Student {ID = 107, Name = "Pranaya"},
                new Student {ID = 108, Name = "Santosh"},
            };

            //Method Syntax
            var MS = StudentCollection1.Select(x => x.Name)
                     .Intersect(StudentCollection2.Select(y => y.Name)).ToList();
            //Query Syntax
            var QS = (from std in StudentCollection1
                      select std.Name)
                      .Intersect(StudentCollection2.Select(y => y.Name)).ToList();
            foreach (var name in MS)
            {
                Console.WriteLine(name);
            }
        }
    }
}
