using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Abstraction.AbstractClass
{
    //case 1:
    internal abstract class WhenCreateAbstractClass
    {
        public abstract void Print();
    }

    //case 2: 
    abstract class A {
        public abstract void Add(int a, int b);
        public abstract void Sub(int a, int b);

    }
    abstract class B: A
    {
        public override void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

    }

    //case 3:

    interface I1
    {
        void Add(int a, int b);
        void Mul(int a, int b);
    }

    public abstract class C:I1 { 
        
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);   
        }

        public abstract void Mul(int a, int b);
    }



}
