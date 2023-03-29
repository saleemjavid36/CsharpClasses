using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Collections.Generics
{
    public class ClsMain
    {
        public void Example()
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

            //bool result = ClsCalculator.AreEqual1(4, "nishant");
        }
    }
    public class ClsCalculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }

        //Now this method can accept any data type
        //public static bool AreEqual1(object value1, object value2)
        //{
        //    return value1 == value2;
        //}

        // method overloading
        //public static bool AreEqual(string value1, string value2)
        //{
        //    return value1 == value2;
        //}
        //public static bool AreEqual(double value1, double value2)
        //{
        //    return value1 == value2;
        //}
    }
}
