using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Polymorphism
{
    internal class CompileTimePolymorphism
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
        public void Add(int b, int a, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }
}
