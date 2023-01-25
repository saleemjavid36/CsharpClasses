using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Loops
{
    internal class BreakAndContinue
    {
        public void BreakAndContinueExample()
        { // Nishant is printed only 2 times because of continue statement
                for (int i = 1; i < 10; i++)
                {
                    if (i == 2)
                        continue;
                    if (i == 5)
                        break;                 
                    Console.WriteLine(i);
                }
        }
    }
}
        