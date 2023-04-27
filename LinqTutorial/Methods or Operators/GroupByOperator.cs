using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class GroupByOperator
    {
        public void Example()
        {
            //Using Method Syntax
            IEnumerable<IGrouping<string, Students>> GroupByMS = Students.GetAllStudents().GroupBy(s => s.Barnch);
            //Using Query Syntax
            IEnumerable<IGrouping<string, Students>> GroupByQS = (from std in Students.GetAllStudents()
                                                                 group std by std.Barnch);
            //It will iterate through each groups
            foreach (IGrouping<string, Students> group in GroupByMS)
            {
                Console.WriteLine(group.Key + " : " + group.Count());
                //Iterate through each student of a group
                foreach (var student in group)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Gender :" + student.Gender);
                }
            }
        }

        public void Example2()
        {
            //Using Method Syntax
            //First Group the Data by Gender
            var GroupByMS = Students.GetAllStudents().GroupBy(s => s.Gender)
                            //Then Sorting the data based on key in Descending Order
                            .OrderByDescending(c => c.Key)
                            .Select(std => new
                            {
                                Key = std.Key,
                                //Sorting the Students in Each Group based on Name in Ascending order
                                Students = std.OrderBy(x => x.Name)
                            });
            //Using Query Syntax
            //First Group the Data by Gender
            var GroupByQS = from std in Students.GetAllStudents()
                                //First store the data into a group
                            group std by std.Gender into stdGroup
                            //Then Sorting the data based on key in Descending Order
                            orderby stdGroup.Key descending
                            select new
                            {
                                Key = stdGroup.Key,
                                //Sorting the Students in Each Group based on Name in Ascending order
                                Students = stdGroup.OrderBy(x => x.Name)
                            };
            //It will iterate through each groups
            foreach (var group in GroupByQS)
            {
                Console.WriteLine(group.Key + " : " + group.Students.Count());
                //Iterate through each student of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Branch :" + student.Barnch);
                }
            }
        }
    }
}
