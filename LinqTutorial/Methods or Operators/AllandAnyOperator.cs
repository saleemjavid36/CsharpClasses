using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class AllandAnyOperator
    {
        public void Example()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            bool ResultMS = IntArray.All(x => x > 10);
            //Using Query Syntax
            bool ResultQS = (from num in IntArray
                             select num).All(x => x > 10);
            Console.WriteLine("Is All Numbers are greater than 10 : " + ResultMS);
            //Using Method Syntax
            var anyMS = IntArray.Any(x => x > 20);
            //Using Query Syntax
            var anyQS = (from num in IntArray
                            select num).Any();
            Console.WriteLine("Is there any element in the collection: " + anyMS);
        }

        public void AllandAnyWithString()
        {
            string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };
            //Using Method Syntax
            bool ResultMS = stringArray.All(name => name.Length > 5);
            //Using Query Syntax
            bool ResultQS = (from num in stringArray
                             select num).All(name => name.Length > 5);
            Console.WriteLine("Is All Names are greater than 5 Characters : " + ResultQS);

            //Method Syntax
            var anyMS = stringArray.Any(name => name.Length > 5);
            //Query Syntax
            var anyQS = (from name in stringArray
                            select name).Any(name => name.Length > 5);
            Console.WriteLine("Is Any name with a Length greater than 5 Characters: " + anyMS);
        }

        public void AllandAnyWithComplexType()
        {
            //Using Method Syntax
            bool MSResult = Students.GetAllStudents().All(std => std.TotalMarks > 250);
            //Using Query Syntax
            bool QSResult = (from std in Students.GetAllStudents()
                             select std).All(std => std.TotalMarks > 250);
            Console.WriteLine($"Is All Students Having Total Marks 250: {MSResult}");

            //Using Method Syntax
            bool MSany = Students.GetAllStudents().Any(std => std.TotalMarks > 250);
            //Using Query Syntax
            bool QSany = (from std in Students.GetAllStudents()
                             select std).Any(std => std.TotalMarks > 250);
            Console.WriteLine($"Any Student Having Total Marks > 250: {MSany}");
        }

        public void AllandAnyWithNestedCollection()
        {
            //Using Method Syntax
            var MSResult = Students.GetAllStudents()
                            .Where(std => std.Subjects.All(x => x.Marks > 80)).ToList();
            //Using Query Syntax
            var QSResult = (from std in Students.GetAllStudents()
                            where std.Subjects.All(x => x.Marks > 80)
                            select std).ToList();
            foreach (var student in QSResult)
            {
                Console.WriteLine($"{student.Name} - {student.TotalMarks}");
                foreach (var subject in student.Subjects)
                {
                    Console.WriteLine($" {subject.SubjectName} - {subject.Marks}");
                }
            }

            //Using Method Syntax
            var MSAny = Students.GetAllStudents()
                            .Where(std => std.Subjects.Any(x => x.Marks > 90)).ToList();
            //Using Query Syntax
            var QSAny = (from std in Students.GetAllStudents()
                            where std.Subjects.Any(x => x.Marks > 90)
                            select std).ToList();
            foreach (var student in QSAny)
            {
                Console.WriteLine($"{student.Name} - {student.TotalMarks}");
                foreach (var subject in student.Subjects)
                {
                    Console.WriteLine($" {subject.SubjectName} - {subject.Marks}");
                }
            }
        }
    }
    public class Students
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Barnch { get; set; }
        public int Age { get; set; }
        public int TotalMarks { get; set; }
        public List<Subject> Subjects { get; set; }
        public static List<Students> GetAllStudents()
        {
            List<Students> listStudentss = new List<Students>()
            {
                new Students{ID= 101,Name = "Preety", TotalMarks = 265, Gender = "Female", Barnch = "CSE", Age = 20 ,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 80},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }},
                new Students{ID= 102,Name = "Priyanka", TotalMarks = 278, Gender = "Female", Barnch = "CSE", Age = 20 ,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 90},
                        new Subject(){SubjectName = "Science", Marks = 95},
                        new Subject(){SubjectName = "English", Marks = 93}
                    }},
                new Students{ID= 103,Name = "James", TotalMarks = 240, Gender = "Female", Barnch = "CSE", Age = 20 ,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 70},
                        new Subject(){SubjectName = "Science", Marks = 80},
                        new Subject(){SubjectName = "English", Marks = 90}
                    }},
                new Students{ID= 104,Name = "Hina", TotalMarks = 275, Gender = "Male", Barnch = "ETC", Age = 21 ,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 90},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }},
                new Students{ID= 105,Name = "Anurag", TotalMarks = 255, Gender = "Male", Barnch = "ETC", Age = 21 ,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 80},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 85}
                    }
                },
            };
            return listStudentss;
        }
    }
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public int Marks { get; set; }
        public static List<Subject> GetAllSubjects()
        {
            return new List<Subject>()
            {
                new Subject { ID = 1, SubjectName = "ASP.NET"},
                new Subject { ID = 2, SubjectName = "SQL Server" },
                new Subject { ID = 5, SubjectName = "Linq"}
            };
        }
    }
}
