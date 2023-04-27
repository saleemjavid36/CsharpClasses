﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class ConcatOperator
    {
        public void ConcatOperatorWithPrimitiveTypes()
        {
            List<int> sequence1 = new List<int> { 1, 2, 3, 4 };
            List<int> sequence2 = new List<int> { 2, 4, 6, 8 };
            //Method Syntax
            var MS = sequence1.Concat(sequence2);
            //Query Syntax
            var QS = (from num in sequence1
                      select num)
                      .Concat(sequence2).ToList();
            foreach (var item in MS)
            {
                Console.Write(item + " ");
            }
        }

        public void ConcatOperatorWithNullCollection()
        {
            List<int> sequence1 = new List<int> { 1, 2, 3, 4 };
            List<int> sequence2 = null;
            var result = sequence1.Concat(sequence2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void ConcatOperatorWithComplexType()
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
            var MS = StudentCollection1.Concat(StudentCollection2).ToList();
            //Query Syntax
            var QS = (from std in StudentCollection1
                      select std).Concat(StudentCollection2).ToList();
            foreach (var student in MS)
            {
                Console.WriteLine($" ID : {student.ID} Name : {student.Name}");
            }
        }
    }
}
