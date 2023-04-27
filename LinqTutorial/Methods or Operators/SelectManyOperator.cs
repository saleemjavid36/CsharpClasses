using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int TotalMarks { get; set; }
        public List<string> Programming { get; set; }
        public static List<Student> GetStudents1()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,Name = "Preety"},
                new Student{ID= 102,Name = "Priyanka"}
            };
            return listStudents;
        }
        public static List<Student> GetStudents2()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,Name = "Preety"},
                new Student{ID= 102,Name = "Priyanka"}
            };
            return listStudents;
        }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Email = "James@j.com", Programming = new List<string>() { "C#", "Jave", "C++"} },
                new Student(){ID = 3, Name = "Nishant", Email = "Sara@j.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" }},
                new Student(){ID = 4, Name = "Patrik", Email = "Patrik@j.com", Programming = new List<string>() { "MVC", "Jave", "LINQ"} },
                new Student(){ID = 2, Name = "Nishant", Email = "Nishant@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" }},
                new Student(){ID = 6, Name = "Vijay", Email = "Vijay@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" } },
                new Student(){ID = 5, Name = "Ajay", Email = "Ajay@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" }}
            };
        }
        public void Example()
        {
            List<string> nameList = new List<string>() { "Pranaya", "Kumar" };

                IEnumerable<char> querySyntax = from str in nameList
                                                from ch in str
                                                select ch;
                foreach (char c in querySyntax)
                {
                    Console.Write(c + " ");
                }
            }

        public void SelectManyWithComplexTypes()
        {
            List<string> MethodSyntax = Student.GetStudents().SelectMany(std => std.Programming).ToList();
            //Using Query Syntax
            IEnumerable<string> QuerySyntax = from std in Student.GetStudents()
                                              from program in std.Programming
                                              select program;
            //Printing the values
            foreach (string program in MethodSyntax)
            {
                Console.WriteLine(program);
            }
        }

        public void RemoveDuplicates()
        {
            //Using Method Syntax
            List<string> MethodSyntax = Student.GetStudents()
                                        .SelectMany(std => std.Programming)
                                        .Distinct()
                                        .ToList();
            //Using Query Syntax
            IEnumerable<string> QuerySyntax = (from std in Student.GetStudents()
                                               from program in std.Programming
                                               select program).Distinct().ToList();
            //Printing the values
            foreach (string program in QuerySyntax)
            {
                Console.WriteLine(program);
            }
        }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.ID == y.ID && x.Name == y.Name;
        }
        public int GetHashCode(Student obj)
        {
            return obj.ID.GetHashCode() ^ obj.Name.GetHashCode();
        }
    }

}
