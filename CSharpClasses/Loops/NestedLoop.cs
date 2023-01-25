using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Loops
{
    internal class NestedLoop
    {
        public void NestedLoopExample()
        {
            // loop within loop printing Nishant
            for (int i = 2; i < 3; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.WriteLine("Nishant");
                }
            }       
        }

    }
}
