using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators.Joins
{
    internal class CrossJoin
    {
        public void Example()
        {
            // Cross Join using Query Syntax
            var CrossJoinResult = from student in Student.GetStudents() //First Data Source
                                  from subject in Subject.GetAllSubjects() //Cross Join with Second Data Source
                                                                           //Projecting the Result to Anonymous Type
                                  select new
                                  {
                                      StudentName = student.Name,
                                      SubjectName = subject.SubjectName
                                  };
            //Accessing the Elements using For Each Loop
            foreach (var item in CrossJoinResult)
            {
                Console.WriteLine($"Name : {item.StudentName}, Subject: {item.SubjectName}");
            }
        }
    }
}
