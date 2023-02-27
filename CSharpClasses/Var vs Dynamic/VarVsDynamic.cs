using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Var_vs_Dynamic
{
    internal class VarVsDynamic
    {
        public void Var_Example()
        {
            var x = "String1"; //Early Bounded
            int Len = x.Length;
        }

        public void dynamic_Example()
        {
            dynamic x = "String1"; //Late Bounded
            int Len = x.length;
        }

        //var as a return type and parameter type
        public int Method1(int x, int y)
        {
            return x + y;
        }

        // dynamic as a returntype and parameter type
        public dynamic SomeMethod(dynamic x, dynamic y)
        {
            return x + y;
        }
    }
}
