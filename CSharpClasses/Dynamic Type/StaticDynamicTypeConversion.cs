using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Dynamic_Type
{
    internal class StaticDynamicTypeConversion
    {
        public void Example()
        {
            //Convert from int to dynamic
            int int1 = 50;
            dynamic dynamic1 = int1; //Explicit cast not required
            Console.WriteLine($"int1 = {int1} & dynamic1 = {dynamic1}");
            //Convert from dynamic to int
            dynamic dynamic2 = 100;
            int int2 = dynamic2; //Explicit cast not required
            Console.WriteLine($"int2 = {int2} & d2 = {dynamic2}");
        }
    }
}
