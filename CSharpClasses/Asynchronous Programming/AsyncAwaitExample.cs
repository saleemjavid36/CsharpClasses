using CSharpClasses.Methods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpClasses.Asynchronous_Programming
{
    internal class AsyncAwaitExample
    {
        public async Task Demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var task1 = StartSchoolAssembly();
            await task1;
            var task2 = TeachClass12();
            var task3 = TeachClass11();
            //We measure the execution time of three asynchronous methods.
            //Task.WaitAll(f1(), f2(), f3());
            //The Task.WaitAll waits for all of the provided tasks to complete execution.

            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution Time: { watch.ElapsedMilliseconds} ms");
        }

        public static async Task StartSchoolAssembly()
        {
            await Task.Delay(8000);
            Console.WriteLine("School Started");
        }

        public static async Task TeachClass12()
        {
            await Task.Delay(3000);
            Console.WriteLine("Taught class 12");
        }

        public static async Task TeachClass11()
        {
            await Task.Delay(2000);
            Console.WriteLine("Taught class 11");
        }
    }
}
