using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpClasses.Var_Keyword
{
    internal class WhyVarKeyword
    {
        //var z = 10;
        public void Example()
        {
            //var a = null;
            int a = 10, b = 20; 
            //var x = 10;
            //You can see the object creation statement becomes quite long and also unreadable
            SomeBigClassWithSomeMoreOperations<string, string> obj = new SomeBigClassWithSomeMoreOperations<string, string>();
            //Create object with var keyword.
            //Short and Readable
            //Short and Readable
            var obj1 = new SomeBigClassWithSomeMoreOperations<string, string>();
        }

        public void Example2()
        {
            //Using var keyword to declare Anonymous Type
            //After new keyword we have not specified the type type and hence
            //it becomes an Anonymous Type
            var student = new { Id = 1001, Name = "Pranaya" };
            Console.WriteLine($"Id: {student.Id} Name: {student.Name} ");
        }
        public void Example3()
        {
           // List of Strings
                List<string> nameList = new List<string> { "Anurag", "Pranaya", "Raj", "James", "Sara", "Priyanka" };
                //Using var Keyword in Foreach Loop
                foreach (var name in nameList)
                {
                    Console.WriteLine(name);
                }
            // Using var Keyword in For Loop
            for (var index = 1; index <= 5; index++)
            {
                Console.WriteLine(index);
            }
        }

        public void PointsToRemember()
        {
            // var x;
            //var y = null;
            //var a = 5, b = 7, c = 8;
        }

        }
    public class SomeBigClassWithSomeMoreOperations<T1, T2>
    {
        public string Name { get; set; }
    }
}
