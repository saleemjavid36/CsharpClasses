using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.DataTypes
{
    public class PointerType
    {
        public void PointerTypeExample()
        {
            unsafe
            {

                // declare variable
                int n = 10;

                // store variable n address 
                // location in pointer variable p
                int* p = &n;
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)p);
            }
        }
    }
}
