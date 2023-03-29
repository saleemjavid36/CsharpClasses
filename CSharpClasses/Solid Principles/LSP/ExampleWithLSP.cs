using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Solid_Principles.LSP
{
    internal class ExampleWithLSP
    {
        public void Example()
        {
            IFruit fruit = new Orange1();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
            fruit = new Apple1();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
        }

    }
    public interface IFruit
    {
        string GetColor();
    }
    public class Apple1 : IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }
    public class Orange1 : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
}
