﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.TypesOfClass.PartialClass.PartialMethod
{
    partial class PartialClass
    {
        // Partial method implemented
        partial void PartialMethod(int a)
        {
            Console.WriteLine("Partial PartialMethod  Invoked");
        }
    }
}
