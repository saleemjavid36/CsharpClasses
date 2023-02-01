using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.AccessModifiers
{
    internal class InternalAccessModifier
    {
        internal int Id { get; set; }
        internal void PrintId()
        {
            Console.WriteLine(Id);
        }
    }

    class Second { 
        public void Example()
        {
            InternalAccessModifier internalAccessModifier = new InternalAccessModifier();
            internalAccessModifier.PrintId();

        }

        class Third: InternalAccessModifier
        {
            public void Example()
            {
                Id = 42;
                PrintId();
            }

        }

    }

}
