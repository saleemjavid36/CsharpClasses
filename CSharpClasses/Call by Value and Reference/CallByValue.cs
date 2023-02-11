using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Call_by_Value_and_Reference
{
    internal class CallByValue
    {
        public void Example () {
            int a = 15;
            UpdateValue(a);
            //int b = a;
            //b = 30;
            Console.WriteLine(a);
        }
        private static void UpdateValue(int b)
        {
            b = 30;
        }
    }
}
