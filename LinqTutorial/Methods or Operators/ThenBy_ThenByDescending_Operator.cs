using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class ThenBy_ThenByDescending_Operator
    {
        public void ThenByExample()
        {
            //Sorting the Student data by Name and Email in Descending Order
            //Using Method Syntax
            var MS = Student.GetStudents()
                            .OrderBy(x => x.Name)
                            .ThenBy(y => y.Email)
                            .ToList();
            foreach (var student in MS)
            {
                Console.WriteLine("Name :" + student.Name + ", Email : " + student.Email);
            }

            //Sorting the Student data by Name and Email in Descending Order
            //Using Query Syntax
            var QS = (from std in Student.GetStudents()
                      orderby std.Name, std.Email
                      select std);
            foreach (var student in QS)
            {
                Console.WriteLine("Name :" + student.Name + ", Email : " + student.Email);
            }
        }

        public void SortByMultipleValues()
        {
            //First Sort Students in Ascending Order Based on Branch
            //Then Sort Students in Descending Order Based on FirstName
            //Finally Sort Students in Ascending Order Based on LastName
            //Using Method Syntax
            var MS = Student.GetStudents()
                     .OrderBy(x => x.ID)
                     .ThenByDescending(y => y.Name)
                     .ThenBy(z => z.Email)
                     .ToList();
            //Using Query Syntax
            var QS = (from std in Student.GetStudents()
                      orderby std.ID ascending,
                              std.Name descending,
                              std.Email //by default ascending
                      select std).ToList();
            foreach (var student in QS)
            {
                Console.WriteLine("ID " + student.ID + ", Name :" + student.Name + ", Email : " + student.Email);
            }
        }

        public void SortWithWhere()
        {
            //First, fetch only the students whose name is Nishant
            //Sort the Students in ascending order based on Name
            //Sort the students in descending order based on their Email
            //Using Method Syntax
            var MS = Student.GetStudents()
                     .Where(std => std.Name == "Nishant")
                     .OrderBy(x => x.ID)
                     .ThenByDescending(y => y.Email)
                     .ToList();
            //Using Query Syntax
            var QS = (from std in Student.GetStudents()
                      where std.Name == "Nishant"
                      orderby std.ID, //By Default it is Ascending
                              std.Email descending
                      select std).ToList();
            foreach (var student in QS)
            {
                Console.WriteLine("ID " + student.ID + ", Name :" + student.Name + ", Email : " + student.Email);
            }
        }
    }
}
