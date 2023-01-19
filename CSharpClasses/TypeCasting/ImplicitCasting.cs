using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.TypeCasting
{
    internal class ImplicitCasting
    {
        public void ImplicitCastingExample()
        {
            int i = 57;

            // automatic type conversion
            long l = i;

            // automatic type conversion
            float f = l;

            // automatic type conversion
            double d = f;

            // Display Result
            Console.WriteLine("Int value " + i);
            Console.WriteLine("Long value " + l);
            Console.WriteLine("Float value " + f);
            Console.WriteLine("Double value " + d);
        }
    }
}
