using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Solid_Principles.LSP
{
    internal class ExampleWithoutLSP
    {
        public void Example()
        {
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());
        }
    }
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
