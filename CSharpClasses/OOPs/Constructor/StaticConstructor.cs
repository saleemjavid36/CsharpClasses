using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Constructor
{
    internal class StaticConstructor
    {
        int age;
        static string name;
        static StaticConstructor()
        {
            name  = "nishant";
            Console.WriteLine("Static constructor called");
        }
        public StaticConstructor()
        {
            age = 5;
            name = "nishant";
           Console.WriteLine("Default Constructer is called");
        }
    }
}
