using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Variables
{
    public class StaticVariable
    {
        public static double salary;
        public static string name = "Aks";

        
        public void StaticVariableExample()
        {

            // accessing static variable
            // without object
            StaticVariable.salary = 100000;

            Console.WriteLine(StaticVariable.name + "'s average salary:"
                                               + StaticVariable.salary);
        }
    }
}
