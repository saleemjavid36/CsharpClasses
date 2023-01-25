using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Conditional_Statements
{
    public class Ifelse
    {
        public void Example()
        {
            int a = 6, b = 7;
            if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else
            {
                Console.WriteLine("either a is less than b or equal to b");
            }
        }
    }
}
