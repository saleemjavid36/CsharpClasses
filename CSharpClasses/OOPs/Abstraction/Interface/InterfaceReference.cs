﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Abstraction.Interface
{
    interface ITestInterfaceExample
    {
        void Add(int num1, int num2);
    }

    public class ImplementationClass : ITestInterfaceExample
    {
        //Interface Method Implementation
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
        //This method purely belongs to ImplementationClass
        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
        }
    }
}
