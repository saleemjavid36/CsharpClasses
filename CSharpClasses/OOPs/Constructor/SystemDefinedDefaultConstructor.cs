using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Constructor
{
    internal class SystemDefinedDefaultConstructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public void Display()
        {
            Console.WriteLine(Id + " " + Name);  
        }
    }
}
