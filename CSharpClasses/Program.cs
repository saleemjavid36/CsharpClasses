using CSharpClasses.Arrays;
using CSharpClasses.Call_by_Value_and_Reference;
using CSharpClasses.Conditional_Statements;
using CSharpClasses.Extension_Methods;
using CSharpClasses.Input_Output;
using CSharpClasses.Loops;
using CSharpClasses.Methods;
using CSharpClasses.OOPs.Abstraction;
using CSharpClasses.OOPs.Abstraction.Interface;
using CSharpClasses.OOPs.AccessModifiers;
using CSharpClasses.OOPs.Constructor;
using CSharpClasses.OOPs.Encapsulation;
using CSharpClasses.OOPs.Inheritance;
using CSharpClasses.OOPs.Polymorphism;
using CSharpClasses.OOPs.TypesOfClass;
using CSharpClasses.Operators;
using CSharpClasses.Variables;
using System;

namespace CSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExtensionMethod extensionMethod = new ExtensionMethod();
            //extensionMethod.Test1();
            //extensionMethod.Test2();
            //extensionMethod.Test3();
            //extensionMethod.Test4(5);
            //extensionMethod.Test5();

            string myWord = "Welcome to Dotnet Tutorials Extension Methods Article By Nishant Gupta";
            int wordCount = myWord.GetWordCount();
            Console.WriteLine("string : " + myWord);
            Console.WriteLine("Count : " + wordCount);

            //Manager1 m1 = new Manager1();
            //m1.GetEmployeeData();
            //m1.DisplayEmployeeData();

            //Printer printer = new Printer();
            //printer.Display();
            //printer.Print();
            //LaserJet laserJet = new LaserJet();
            //laserJet.Display();
            //laserJet.Print();
            //InkJet inkJet = new InkJet();
            //inkJet.Display();
            //inkJet.Print();

        }
    }
}
