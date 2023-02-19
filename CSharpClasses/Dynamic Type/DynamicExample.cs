using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Dynamic_Type
{
    internal class DynamicExample
    {
        public void Example()
        {
            dynamic str = "Hello";
            Console.WriteLine(str.GetType());
            str++;
        }
    }
}
