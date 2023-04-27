using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class GroupByMultipleKeys
    {
        public void Example()
        {
            //Using Method Syntax
            var GroupByMultipleKeysMS = Students.GetAllStudents()
                .GroupBy(x => new { x.Barnch, x.Gender })
                .Select(g => new
                {
                    Branch = g.Key.Barnch,
                    Gender = g.Key.Gender,
                    Students = g.OrderBy(x => x.Name)
                }); ;
            //Using Query Syntax
            var GroupByMultipleKeysQS = (from std in Students.GetAllStudents()
                                         group std by new
                                         {
                                             std.Barnch,
                                             std.Gender
                                         } into stdGroup
                                         select new
                                         {
                                             Branch = stdGroup.Key.Barnch,
                                             Gender = stdGroup.Key.Gender,
                                             //Sort the Students of Each group by Name in Ascending Order
                                             Students = stdGroup.OrderBy(x => x.Name)
                                         });
            //It will iterate through each group
            foreach (var group in GroupByMultipleKeysQS)
            {
                Console.WriteLine($"Barnch : {group.Branch} Gender: {group.Gender} No of Students = {group.Students.Count()}");
                //It will iterate through each item of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"  ID: {student.ID}, Name: {student.Name}, Age: {student.Age} ");
                }
                Console.WriteLine();
            }
        }
    }
}
