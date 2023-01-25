using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Conditional_Statements
{
    public class If_elseIf_else
    {
        public void Example()
        {
            int a = 5; int b = 5;
            if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else if (a < b)
            {
                Console.WriteLine("a < b");
            }
            else
            {
                Console.WriteLine("a == b");
            }
        }
    }
}
