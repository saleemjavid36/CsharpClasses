using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Variables
{
    public class ReadOnlyVariable
    {
        // instance variable
        int a = 80;

        // static variable
        static int b = 40;

        // Constant variables
        const float max = 50;

        // readonly variables
        readonly int k;

        // constructor
        public ReadOnlyVariable()
        {

            // initializing readonly
            // variable k
            this.k = 90;
        }

        
        public  void ReadOnlyVariableExample()
        {

            // Creating object
            ReadOnlyVariable obj = new ReadOnlyVariable();

            Console.WriteLine("The value of a is = " + obj.a);
            Console.WriteLine("The value of b is = " + ReadOnlyVariable.b);
            Console.WriteLine("The value of max is = " + ReadOnlyVariable.max);
            Console.WriteLine("The value of k is = " + obj.k);
        }
    }
}
