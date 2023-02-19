using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.ExceptionHandling
{
    internal class TryCatchWIthCommonMsg
    {
        public void TryCatch()
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number:");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                Number2 = int.Parse(Console.ReadLine());
                Result = Number1 / Number2;
                Console.WriteLine($"Result = {Result}");
            }
            catch
            {
                Console.WriteLine("Some Error Occurred...");
            }
        }
    }
}
