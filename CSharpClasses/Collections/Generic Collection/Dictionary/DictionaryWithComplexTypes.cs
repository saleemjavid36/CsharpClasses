using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpClasses.Collections.Generic_Collection.Dictionary
{
    internal class DictionaryWithComplexTypes
    {
        public void Example()
        {
            Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"} },
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},
                //The following Statement will give runtime error
                //System.ArgumentException: 'An item with the same key has already been added. Key: 101'
                //{ 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"}}
            };
            foreach (KeyValuePair<int, Student> item in dictionaryStudents)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }
        }
        public void TryGetValueMethod()
        {
            Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"} },
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}}
            };
            foreach (KeyValuePair<int, Student> item in dictionaryStudents)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }
            Student std102;
            if (dictionaryStudents.TryGetValue(102, out std102))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {std102.ID}, Name: {std102.Name}, Branch: {std102.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 102 is not found in the dictionary");
            }
            Student std105;
            if (dictionaryStudents.TryGetValue(105, out std105))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {std105.ID}, Name: {std105.Name}, Branch: {std105.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 105 is not found in the dictionary");
            }
        }

        public void ConvertArrayToDictionary()
        {
            Student[] arrayStudents = new Student[3];
                arrayStudents[0] = new Student() { ID = 101, Name = "Anurag", Branch = "CSE" };
                arrayStudents[1] = new Student() { ID = 102, Name = "Mohanty", Branch = "CSE" };
                arrayStudents[2] = new Student() { ID = 103, Name = "Sambit", Branch = "ETC" };
                Dictionary<int, Student> dictionaryStudents = arrayStudents.ToDictionary(std => std.ID, std => std);
                // OR        
                // Dictionary<int, Student> dictionaryStudents = arrayStudents.ToDictionary(employee => employee.ID);
                //OR use a foreach loop
                //Dictionary<int, Student> dict = new Dictionary<int, Student>();
                //foreach (Student std in arrayStudents)
                //{
                //    dict.Add(std.ID, std);
                //}
                foreach (KeyValuePair<int, Student> item in dictionaryStudents)
                {
                    Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
                }
        }

        public void GetKeysAndValuesFromDictionary()
        {
            Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"} },
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}}
            };
            // To get all the keys in the dictionary use the keys properties of dictionary
            Console.WriteLine("All Keys in Student Dictionary");
            foreach (int key in dictionaryStudents.Keys)
            {
                Console.WriteLine(key + " ");
            }

            // Once you get the keys, then get the values using the keys
            Console.WriteLine("\nAll Keys and values in Student Dictionary");
            foreach (int key in dictionaryStudents.Keys)
            {
                var student = dictionaryStudents[key];
                Console.WriteLine($"Key: {key}, ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
            }

            //To get all the values in the dictionary use Values property
            Console.WriteLine("\nAll Student objects in Student Dictionary");
            foreach (Student student in dictionaryStudents.Values)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
            }
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
    }
}
