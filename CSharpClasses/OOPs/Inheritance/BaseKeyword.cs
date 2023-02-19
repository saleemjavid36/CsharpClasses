using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Inheritance
{
    class BaseKeywordParent
    {
        public BaseKeywordParent(int number)
        {
            Console.WriteLine($"Class A Constructor is Called : {number}");
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
    class BaseKeywordChild : BaseKeywordParent
    {
        public BaseKeywordChild() : base(10)
        {
            Console.WriteLine("Class B Constructor is Called");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        static void Display()
        {
            BaseKeywordChild obj = new BaseKeywordChild();
        }
    }
}
