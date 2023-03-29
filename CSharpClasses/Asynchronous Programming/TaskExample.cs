using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClasses.Asynchronous_Programming
{
    internal class TaskExample
    {
        public async Task MainMethod()
        {
            Console.WriteLine("Main Method Started......");
            await SomeMethod();
            Console.WriteLine("Main Method End");
        }
        public async static Task SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            await Wait();
            Console.WriteLine("Some Method End");
        }
        private static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }

       
    }

  

}
