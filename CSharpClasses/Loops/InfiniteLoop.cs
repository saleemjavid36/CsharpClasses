using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Loops
{
    internal class InfiniteLoop
    {
        public void InfiniteLoopExample()
        {
            // The statement will be printed infinite times
            for (; ; )
                Console.WriteLine("This is printed infinite times");
        }

    }
}
