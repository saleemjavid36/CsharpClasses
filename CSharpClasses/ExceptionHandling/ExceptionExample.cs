using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.ExceptionHandling
{
    internal class ExceptionExample
    {
        public void Example()
        {
            int a = 20;
            int b = 0;
            int c;
            Console.WriteLine("A VALUE = " + a);
            Console.WriteLine("B VALUE = " + b);
            c = a / b;
            Console.WriteLine("C VALUE = " + c);
        }
        // logical implementation
        public void LogicalImplementation()
        {
            int Number1, Number2, Result;
            Console.WriteLine("Enter First Number:");
            Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            Number2 = int.Parse(Console.ReadLine());
            if (Number2 == 0)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            else
            {
                Result = Number1 / Number2;
                Console.WriteLine($"Result = {Result}");
            }
        }
    }
}
