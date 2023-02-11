using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Extension_Methods
{
    public class ExtensionMethod
    {
        public int x = 100;
        public void Test1()
        {
            Console.WriteLine("Method one: " + this.x);
        }
        public void Test2()
        {
            Console.WriteLine("Method two: " + this.x);
        }
    }
}
