﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Delegates.Multicast_Delegates
{
    public delegate void MathDelegate(int No1, int No2);
    internal class UseMulticastInDifferentWay
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
        }
        //Static Method
        public static void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
        }
        //Non-Static Method
        public void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
        }
        //Non-Static Method
        public void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is : {x / y}");
        }
        public void Example()
        {
            UseMulticastInDifferentWay p = new UseMulticastInDifferentWay();
            //Static Method within the same class can be access directly
            MathDelegate del1 = new MathDelegate(Add);
            //Static Method can be access using class name
            MathDelegate del2 = new MathDelegate(UseMulticastInDifferentWay.Sub);
            //Non-Static Method must be access through object 
            MathDelegate del3 = new MathDelegate(p.Mul);
            MathDelegate del4 = new MathDelegate(p.Div); ;
            //In this example del5 is a multicast delegate. 
            //We can use +(plus) operator to chain delegates together and 
            //-(minus) operator to remove a delegate.
            MathDelegate del5 = del1 + del2 + del3 + del4;
            Delegate[] InvocationList = del5.GetInvocationList();
            Console.WriteLine("InvocationList:");
            foreach (var item in InvocationList)
            {
                Console.WriteLine($" {item}");
            }
            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate::");
            del5.Invoke(20, 5);
            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate After Removing one Delegate:");
            del5 -= del2;
            del5(22, 7);
        }
    }
}
