using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Abstraction.Interface
{
    interface I1
    {
        void Add(int num1, int num2);
        //void Sub(int num1, int num2);
    }
    interface I2 : I1
    {
        void Sub(int num1, int num2);
        //int age;
    }
    interface I3 {
        void Mul(int a, int b);
    }

    public class ImplementClass3 : I1, I3
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("Nishant");
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }

    public class ImplementationClass1 : I1
    {
        //Implement only the Add method
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
    }
    public class ImplementationClass2 : I2
    {
        //Implement Both Add and Sub method
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
        }
    }
}
