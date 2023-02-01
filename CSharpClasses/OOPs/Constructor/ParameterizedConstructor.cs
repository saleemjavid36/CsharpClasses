﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Constructor
{
    internal class ParameterizedConstructor
    {
        int x;
        public ParameterizedConstructor(int i)
        {
            //Initializing the variable
            x = i;
            Console.WriteLine($"Parameterized Constructor is Called : {i}");
        }
        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}
