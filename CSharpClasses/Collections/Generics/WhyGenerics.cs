using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Collections.Generics
{
    public class ClsMain
    {
        private static void Main()
        {
            bool IsEqual = ClsCalculator.AreEqual(10, 20);
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
    public class ClsCalculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
    }
}
