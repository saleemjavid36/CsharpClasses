using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSharpClasses.Delegates.Multicast_Delegates
{
    internal class WithoutDelegates
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine($"Area is {Width * Height}");
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter is {2 * (Width + Height)}");
        }
        public void Example()
        {
            WithoutDelegates obj = new WithoutDelegates();
            obj.GetArea(23.45, 67.89);
            obj.GetPerimeter(23.45, 67.89);
        }
    }
}
