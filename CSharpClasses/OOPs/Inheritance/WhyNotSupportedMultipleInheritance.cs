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

    public class B: A
    {

    }
    public class C: A
    {
    }

    internal class WhyNotSupportedMultipleInheritance: B
    {
        public void Display()
        {
            Print();
            Print();
        }
    }
}
