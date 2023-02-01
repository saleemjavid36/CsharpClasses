using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Constructor
{
    internal class UserDefinedDefaultConstructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserDefinedDefaultConstructor()
        {
            Id = 1;
            Name = "Nishant";
        }
        public void Display()
        {
            Console.WriteLine(Id + " " + Name);
        }
    }
}
