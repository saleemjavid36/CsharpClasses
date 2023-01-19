using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Variables
{
    public class LocalVariable
    {
        // Method
        public void StudentAge()
        {

            // local variable age
            int age = 0;

            age = age + 10;
            Console.WriteLine("Student age is : " + age);
        }

        //can not use local variable outside the scope
        //it will give error if you print the local variable here
        //Console.WriteLine("Student age is : " + age);
    }
}
