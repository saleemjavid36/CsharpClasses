using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Variables
{
    public class ConstantVariable
    {
        // instance variable
        int a = 10;

        // static variable
        static int b = 20;

        // constant variable
        const float max = 50;

        
        public  void ConstantVariableExample()
        {

            // creating object
            ConstantVariable obj = new ConstantVariable();
            

            // displaying result
            Console.WriteLine("The value of a is = " + obj.a);
            Console.WriteLine("The value of b is = " + ConstantVariable.b);
            Console.WriteLine("The value of max is = " + ConstantVariable.max);
        }
    }
}
