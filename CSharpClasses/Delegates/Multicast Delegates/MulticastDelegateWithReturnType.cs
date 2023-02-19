using CSharpClasses.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Delegates.Multicast_Delegates
{
    // Deletegate's return type is int
    public delegate int SampleDelegate();
    internal class MulticastDelegateWithReturnType
    {
        public void Example()
        {
            SampleDelegate del = new SampleDelegate(MethodOne);
            del += MethodTwo;

            // The Value Returned By Delegate will be 2, returned by the MethodTwo(),
            // as it is the last method in the invocation list.
            int ValueReturnedByDelegate = del();
            Console.WriteLine($"Returned Value = {ValueReturnedByDelegate}");
        }
        // This method returns one
        public static int MethodOne()
        {
            Console.WriteLine("MethodOne is Executed");
            return 1;
        }
        // This method returns two
        public static int MethodTwo()
        {
            Console.WriteLine("MethodTwo is Executed");
            return 2;
        }

        
    }
}
