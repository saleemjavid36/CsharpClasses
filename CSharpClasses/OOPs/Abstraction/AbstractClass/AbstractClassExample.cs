using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Abstraction.AbstractClass
{
    public abstract class AbstractClassExample
    {
        public static void PrintClassName()
        {
            Console.WriteLine("AbstracClassExample");
        }
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }

    public class Example
    {
        public void Display()
        {
            // can not create instance of abstract class
            //AbstractClassExample abstractClassExample = new AbstractClassExample();

            // but you can create the instance of the child class who has inherited the abstract class
            AbsChild absChild = new AbsChild();

            // we can use abstract class as a reference that can hold the object of the child class
            AbstractClassExample abstractClassExample = null;
            AbsChild abs = new AbsChild();
            abstractClassExample = abs;
            abstractClassExample.Add(3,4);
            

            // you can directly call the static member of abstract class
            AbstractClassExample.PrintClassName();

            
        }
    }
    public class AbsChild : AbstractClassExample
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is : {x / y}");
        }

        public void PrintMyName()
        {
            Console.WriteLine("Nishant Gupta");
        }
    }
}
