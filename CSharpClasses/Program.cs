using CSharpClasses.Operators;
using CSharpClasses.Variables;
using System;

namespace CSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Nishant");
            Airthmatic airthmatic = new Airthmatic();
            airthmatic.ArithmaticOperators();
            Relational relational = new Relational();
            relational.RelationalOperators();
            Logical logical= new Logical();
            logical.LogicalOperators();
            Bitwise bitwise = new Bitwise();
            bitwise.BitwiseOperators();


        }
    }
}
