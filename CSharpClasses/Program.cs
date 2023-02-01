using CSharpClasses.Arrays;
using CSharpClasses.Conditional_Statements;
using CSharpClasses.Input_Output;
using CSharpClasses.Loops;
using CSharpClasses.Methods;
using CSharpClasses.OOPs.AccessModifiers;
using CSharpClasses.OOPs.Constructor;
using CSharpClasses.OOPs.Encapsulation;
using CSharpClasses.OOPs.Inheritance;
using CSharpClasses.OOPs.Polymorphism;
using CSharpClasses.Operators;
using CSharpClasses.Variables;
using System;

namespace CSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Compile Time Polymorphism
            CompileTimePolymorphism obj = new CompileTimePolymorphism();
            obj.Add(10, 20);
            obj.Add(10.5f, 20.5f);
            obj.Add("Pranaya", "Rout"); Console.ReadKey();

            //Run Time Polymorphism
            RunTimePolymorphism runTimePolymorphism = new RunTimePolymorphism();
            runTimePolymorphism.Display();

            //Operator Overloading
            OperatorOverloading operatorOverloading = new OperatorOverloading();
            operatorOverloading.Display();

            //Method Overriding
            MethodOverriding methodOverriding = new MethodOverriding();
            methodOverriding.Display();
        }
    }
}
