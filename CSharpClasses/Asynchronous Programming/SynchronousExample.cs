using System;
using System.Diagnostics;
using System.Threading;

namespace CSharpClasses.Asynchronous_Programming
{
    internal class SynchronousExample
    {
        public void Demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            StartSchoolAssembly();
            TeachClass12();
            TeachClass11();
            watch.Stop();
            Console.WriteLine($"Execution Time: { watch.ElapsedMilliseconds} ms");
        }


        public static void StartSchoolAssembly()
        {
            Thread.Sleep(8000);
            Console.WriteLine("School Started");
        }


        public static void TeachClass12()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Taught class 12");

        }

        public static void TeachClass11()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Taught class 11");

        }
    }
}
