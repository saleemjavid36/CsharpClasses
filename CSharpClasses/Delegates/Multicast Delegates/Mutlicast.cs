using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSharpClasses.Delegates.Multicast_Delegates
{
    internal class MutlicastClass
    {
        public delegate void Calculation(int num1, int num2);
        public void Sum(int a, int b)
        {
            Console.WriteLine($"Sum is {a + b}");
        }
        public void Substraction(int a, int b)
        {
            Console.WriteLine($"Substraction is {a - b}");
        }
        public void Multiplication(int a, int b)
        {
            Console.WriteLine($"Multiplication is {a * b}");
        }
        public void Division(int a, int b)
        {
            Console.WriteLine($"Division is {a / b}");
        }
        public void MulticastExample()
        {
            MutlicastClass example = new MutlicastClass();
            Calculation multiDelegate = new Calculation(example.Sum);
            // binding a method with delegate object
            // In this example multiDelegate is a multicast delegate. 
            // You use += operator to chain delegates together.
            multiDelegate += example.Substraction;
            multiDelegate += example.Multiplication;
            Delegate[] InvocationList = multiDelegate.GetInvocationList();
            Console.WriteLine("InvocationList:");
            foreach (var item in InvocationList)
            {
                Console.WriteLine($"  {item}");
            }
            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate:");
            multiDelegate(4, 1);
            //rectDelegate.Invoke(13.45, 76.89);

            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate After Removing one Pipeline:");
            //Removing a method from delegate object
            multiDelegate -= example.Multiplication;
            multiDelegate.Invoke(15, 4);


        }
    }
}
