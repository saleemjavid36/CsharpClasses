using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClasses.Asynchronous_Programming
{
    internal class AsyncAwait
    {
        public void Method1()
        {
            Console.WriteLine("Method1 Started......");
            SomeMethod();
            Console.WriteLine("Method1 End");
        }
        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            //Thread.Sleep(TimeSpan.FromSeconds(10));
             await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("Some Method End");
        }
    }
}
