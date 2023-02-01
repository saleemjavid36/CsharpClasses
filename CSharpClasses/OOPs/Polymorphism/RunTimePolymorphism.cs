using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Polymorphism
{
    internal class A
    {
        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Show Method");
        }
    }
    internal class B: A {
        //Overriding Method
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show Method");
        }
    }

    internal class C 
    {
        public void Display()
        {
            A a = new B();
            a.Show();

            A obj1 = new B();
            obj1.Show();
            B obj2 = new B();
            obj2.Show();
            Console.ReadKey();
        }
        
    }

}
