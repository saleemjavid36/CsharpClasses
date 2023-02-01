using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.AccessModifiers
{
    internal class ProtectedAccessModifier
    {
        protected int Id;
        public void Display1()
        {
            //protected Members Accessible with the Containing Type 
            //Where they are created
            Console.WriteLine(Id);
        }
    }
}
