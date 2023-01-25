using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Loops
{
    internal class DoWhile
    {
        public void DoWhileExample()
        {
            int x = 1;
            do
            {
                // The line will be printed even
                // if the condition is false
                Console.WriteLine("Nishant");
                x++;
            }
            while (x < 5);
        }

    }
}
