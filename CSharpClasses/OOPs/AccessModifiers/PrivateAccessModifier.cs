using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.AccessModifiers
{
    public class PrivateAccessModifier
    {
        public string Name { get; set; }
        private int Age { get; set; }

        private void PrintAge()
        {
            Console.WriteLine("Your age is " + Age);
        }
        public void PrintName()
        {
            Console.WriteLine("Your name is " + Name);
        }

        public void PrintNameAndge()
        {
            // you can access the private property and method with in the same class but not outside the class
            Age = 26;
            PrintName();
            PrintAge();
        }

    }

    public class B:  PrivateAccessModifier { 
    
        public void Display()
        {
           
            PrivateAccessModifier privateAccessModifier = new PrivateAccessModifier();
            privateAccessModifier.Name = "Nishant";
            //privateAccessModifier.PrintName();
            privateAccessModifier.PrintNameAndge();
        }
        
    }

}
