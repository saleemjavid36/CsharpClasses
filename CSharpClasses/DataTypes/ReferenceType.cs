using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.DataTypes
{
    internal class ReferenceType
    {
        public void ReferenceTypeExample()
        {
            // declaring string
            string a = "Geeks";

            //append in a
            //a += "for";
            a = a + "for"; 
            a = a + "Geeks";
            Console.WriteLine(a);

            // declare object obj
            object obj;
            obj = 20;
            Console.WriteLine(obj);

            // to show type of object
            // using GetType()
            Console.WriteLine(obj.GetType());
        }
    }
}
