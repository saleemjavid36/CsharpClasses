using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Collections.Generics
{
    internal class GenericsExample
    {
        private void Example()
        {
            bool IsEqual = Calculator.AreEqual<double>(10.5, 20.5);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        }
    }

    public class Calculator
    {
        //public static bool AreEqual(int value1, int value2)
        //{
        //    return value1 == value2;
        //}
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
