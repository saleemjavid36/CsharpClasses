using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class SequenceEqualOperator
    {
        public void Example()
        {

            //Collection 1 or Sequenece 1
            List<string> cityList1 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };
            //Collection 1 or Sequenece 1
            List<string> cityList2 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };
            //Checking if both Sequences are Equal or not
            //Using Method Syntax
            bool IsEqualMS = cityList1.SequenceEqual(cityList2);
            //Using Query Syntax
            bool IsEqualQS = (from city in cityList1
                              select city).SequenceEqual(cityList2);
            //Printing the Result
            Console.WriteLine(IsEqualQS);
        }

        public void IfCaseIsDifferent()
        {
            //Collection 1 or Sequenece 1
            List<string> cityList1 = new List<string> { "DELHI", "mumbai", "Hyderabad" };
            //Collection 1 or Sequenece 1
            List<string> cityList2 = new List<string> { "delhi", "MUMBAI", "Hyderabad" };
            //Checking if both Sequences are Equal or not
            //Using Method Syntax
            bool IsEqualMS = cityList1.SequenceEqual(cityList2);
            //Using Query Syntax
            bool IsEqualQS = (from city in cityList1
                              select city).SequenceEqual(cityList2);
            //Printing the Result
            Console.WriteLine(IsEqualQS);
        }

        public void IgnoreCase()
        {
            //Collection 1 or Sequenece 1
            List<string> cityList1 = new List<string> { "DELHI", "mumbai", "Hyderabad" };
            //Collection 1 or Sequenece 1
            List<string> cityList2 = new List<string> { "delhi", "MUMBAI", "Hyderabad" };
            //Checking if both Sequences are Equal or not
            //Using Method Syntax
            bool IsEqualMS = cityList1.SequenceEqual(cityList2, StringComparer.OrdinalIgnoreCase);
            //Using Query Syntax
            bool IsEqualQS = (from city in cityList1
                              select city).SequenceEqual(cityList2, StringComparer.OrdinalIgnoreCase);
            //Printing the Result
            Console.WriteLine(IsEqualMS);
        }

        public void WhenOrderIsDifferent()
        {
            //Collection 1 or Sequenece 1
            List<string> cityList1 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };
            //Collection 1 or Sequenece 1
            List<string> cityList2 = new List<string> { "Delhi", "Hyderabad", "Mumbai" };
            //Checking if both Sequences are Equal or not
            //Using Method Syntax
            bool IsEqualMS = cityList1.SequenceEqual(cityList2, StringComparer.OrdinalIgnoreCase);
            //Using Query Syntax
            bool IsEqualQS = (from city in cityList1
                              select city).SequenceEqual(cityList2, StringComparer.OrdinalIgnoreCase);
            //Printing the Result
            Console.WriteLine(IsEqualMS);
        }

        public void SolveTheDifferentOrderProblem()
        {
            //Collection 1 or Sequenece 1
            List<string> cityList1 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };
            //Collection 1 or Sequenece 1
            List<string> cityList2 = new List<string> { "Delhi", "Hyderabad", "Mumbai" };
            //Checking if both Sequences are Equal or not
            //Using Method Syntax
            bool IsEqualMS = cityList1.OrderBy(city => city).SequenceEqual(cityList2.OrderBy(city => city), StringComparer.OrdinalIgnoreCase);
            //Using Query Syntax
            bool IsEqualQS = (from city in cityList1.OrderBy(city => city)
                              select city).SequenceEqual(cityList2.OrderBy(city => city), StringComparer.OrdinalIgnoreCase);
            //Printing the Result
            Console.WriteLine(IsEqualMS);
        }

        public void ComplexType()
        {
            //Collection 1 or Sequenece 1
            List<Student> StudentList1 = Student.GetStudents1();
            //Collection 1 or Sequenece 1
            List<Student> StudentList2 = Student.GetStudents2();
            //Checking if both Sequences are Equal or not
            //Using Method Syntax
            bool IsEqualMS = StudentList1.SequenceEqual(StudentList2);
            //Using Query Syntax
            bool IsEqualQS = (from std in StudentList1
                              select std).SequenceEqual(StudentList2);
            //Printing the Result
            Console.WriteLine(IsEqualMS);
        }

        public void CustomStudentComparer()
        {
            //Collection 1 or Sequenece 1
            List<Student> StudentList1 = Student.GetStudents1();
            //Collection 1 or Sequenece 1
            List<Student> StudentList2 = Student.GetStudents2();
            //Creating an Instance of StudentComparer
            StudentComparer studentComparer = new StudentComparer();
            //Checking if both Sequences are Equal or not
            //Using Method Syntax
            //Passing the StudentComparer Instance to the SequenceEqual method
            bool IsEqualMS = StudentList1.SequenceEqual(StudentList2, studentComparer);
            //Using Query Syntax
            //Passing the StudentComparer Instance to the SequenceEqual method
            bool IsEqualQS = (from std in StudentList1
                              select std).SequenceEqual(StudentList2, studentComparer);
            //Printing the Result
            Console.WriteLine(IsEqualMS);
        }

        public void AnonymousTypeSequenceEqual()
        {
            //Collection 1 or Sequenece 1
            List<Student> StudentList1 = Student.GetStudents1();
            //Collection 1 or Sequenece 1
            List<Student> StudentList2 = Student.GetStudents2();

            //Checking if both Sequences are Equal or not
            //Using Method Syntax
            //Projecting the Individual Properties to an Anonymous Type
            bool IsEqualMS = StudentList1
                             .Select(std => new { std.ID, std.Name })
                             .SequenceEqual(StudentList2.Select(std => new { std.ID, std.Name }));
            //Using Query Syntax
            //Projecting the Individual Properties to an Anonymous Type
            bool IsEqualQS = (from std in StudentList1
                              select new { std.ID, std.Name })
                             .SequenceEqual(StudentList2.Select(std => new { std.ID, std.Name }));
            //Printing the Result
            Console.WriteLine(IsEqualQS);
        }

    }
}
