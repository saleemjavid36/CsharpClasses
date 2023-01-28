using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Methods
{
    internal class DefaultParameter
    {
        public void DefaultParameterExample(int num = 2)
        {
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine(i * num);
                i++;
            }
        }
        public void MethodCall()
        {
            DefaultParameterExample();
            DefaultParameterExample(3);
        }
    }
}
