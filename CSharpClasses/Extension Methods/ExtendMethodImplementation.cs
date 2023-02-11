using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Extension_Methods
{
    public static class ExtendMethodImplementation
    {
        public static void Test3(this ExtensionMethod O)
        {
            Console.WriteLine("Method Three");
        }
        public static void Test4(this ExtensionMethod O, int x)
        {
            Console.WriteLine("Method Four: " + x);
        }
        public static void Test5(this ExtensionMethod O)
        {
            Console.WriteLine("Method Five:" + O.x);
        }
    }
}
