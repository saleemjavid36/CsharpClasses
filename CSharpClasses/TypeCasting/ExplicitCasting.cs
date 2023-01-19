using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.TypeCasting
{
    public class ExplicitCasting
    {
        public void ExplicitCastingExample()
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;    // Manual casting: double to int
            int myInt2 = Convert.ToInt32(myInt); //built in method
            string myString = Convert.ToString(myInt2);
            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt); // 9
            Console.WriteLine(myInt2);
            Console.WriteLine(myString);

            string s = "1";
            int d = Convert.ToInt32(s);
            string s1 = "Nishant";
            int d2 = Convert.ToInt32(s1);
        }
    }
}
