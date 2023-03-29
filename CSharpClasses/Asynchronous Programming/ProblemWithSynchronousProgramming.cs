using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpClasses.Asynchronous_Programming
{
    internal class ProblemWithSynchronousProgramming
    {
        public void Method1()
        {
            Console.WriteLine("Method1 Started......");
            SomeMethod();
            Console.WriteLine("Method1 End");;
        }
        public static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine("\n");
            Console.WriteLine("Some Method End");
        }
    }
}
