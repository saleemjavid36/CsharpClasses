using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.ExceptionHandling
{
    internal class TryFinallyBlock
    {
        public void SomeMethod()
        {
            try
            {
                Console.WriteLine("Inside SomeMethod");
                int num1 = 10, num2 = 0;
                int result = num1 / num2; //Exception will be thrown here
                Console.WriteLine($"Result: {result}");
            }
            finally
            {
                Console.WriteLine("SomeMethod finally Block");
            }
        }
        
    }
}
