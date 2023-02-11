using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.TypesOfClass.PartialClass.PartialMethod
{
    partial class PartialClass
    {
        // Declaration of the partial method.
        partial void PartialMethod();
        // A public method calling the partial method
        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            PartialMethod();
        }
    }
}
