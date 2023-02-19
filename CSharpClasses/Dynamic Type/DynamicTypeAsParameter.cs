using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Dynamic_Type
{
    internal class DynamicTypeAsParameter
    {
        public void Example()
        {
            //Calling DisplayValue Function with different types of values
            DisplayValue("Dynamic in C#"); //String
            DisplayValue(true); //Boolean
            DisplayValue(5000); //Integer
            DisplayValue(111.50); //Double
            DisplayValue(DateTime.Now); //Date
        }
        public void DisplayValue(dynamic val)
        {
            Console.WriteLine(val);
        }
    }
}
