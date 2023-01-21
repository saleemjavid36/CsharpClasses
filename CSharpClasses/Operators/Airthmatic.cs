using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Operators
{
    internal class Airthmatic
    {
        // Function
        public void ArithmaticOperators()
        {
             
            int result;
        int x = 10, y = 5;

        // Addition
        result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
             
            // Subtraction
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
             
            // Multiplication
            result = (x* y);
            Console.WriteLine("Multiplication Operator: "+ result);
             
            // Division
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);
             
            // Modulo
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
        }
}
}
