using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Call_by_Value_and_Reference
{
    internal class CallByReferenceWithReference
    {
        public void Example()
        {
            Student Stu = new Student();
            Stu.Id = 1001;
            Stu.Name = "James";
            UpdateName(ref Stu);
            Console.WriteLine($"Emp1 Name = {Stu.Name}");
        }
        public void UpdateName(ref Student Stu2)
        {
            Stu2 = null;
        }
    }
    public class Student
    {
        public int Id;
        public string Name;
    }
}

