using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Var_Keyword
{
    internal class VarKeywordExample
    {
        public void Example()
        {
            var x = 10; //Implicit Declaration (Indirect)
            //Here var data type implicit convert to int as value 10 is integer
            Console.WriteLine($"Type is {x.GetType()} & value = {x}");
            Console.ReadKey();
        }
    }
}
