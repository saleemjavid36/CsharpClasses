using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Call_by_Value_and_Reference
{
    internal class CallByReference
    {
        public void Example()
        {
            int a = 15;
            UpdateValue(ref a);
            Console.WriteLine(a);
        }
        public void UpdateValue(ref int b)
        {
            b = 30;
        }
    }
}
