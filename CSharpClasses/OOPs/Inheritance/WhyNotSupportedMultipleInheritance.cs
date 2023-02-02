using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Inheritance
{
    public class A
    { 
        public void Print()
        {
            Console.WriteLine("class A");
        } 
    }

    public class B
    {
        public void Print()
        {
            Console.WriteLine("class B");
        }
    }

    internal class WhyNotSupportedMultipleInheritance: A
    {
        public void Display()
        {
            Print();
            Print();
        }
    }
}
