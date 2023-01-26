using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Methods
{
    internal class MethodWithReturnType
    {
        public int LengthOfName(string name)
        {
            int length = name.Length;
            return length;
        }

        public void MethodCall()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            int length = LengthOfName(name);
            Console.WriteLine("The length of " + name + " is " + length);
        }
    }
}
