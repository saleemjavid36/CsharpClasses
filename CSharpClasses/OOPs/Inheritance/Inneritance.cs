using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace CSharpClasses.OOPs.Inheritance
{
    internal class Parent
    {
        public Parent() {
            Console.WriteLine("Parent Class Constructor");
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
        private void Method4()
        {
            Console.WriteLine("Method 4");
        }
    }

    internal class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child class constructor");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
    }

    internal class Third {
        
        public void Display()
        {
            Child child = new Child();
            child.Method1();
            child.Method2();
            child.Method3();
            //child.Method4
        }
        
    }


}
