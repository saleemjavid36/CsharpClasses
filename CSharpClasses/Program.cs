using CSharpClasses.Arrays;
using CSharpClasses.Conditional_Statements;
using CSharpClasses.Input_Output;
using CSharpClasses.Loops;
using CSharpClasses.Methods;
using CSharpClasses.OOPs.AccessModifiers;
using CSharpClasses.OOPs.Constructor;
using CSharpClasses.OOPs.Encapsulation;
using CSharpClasses.OOPs.Inheritance;
using CSharpClasses.Operators;
using CSharpClasses.Variables;
using System;

namespace CSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseKeywordChild b = new BaseKeywordChild();
            b.Method3();
            b.Method2();
            b.Method1();
            //Third third = new Third();
            //third.Display();
            //PrivateConstructor privateConstructor = new PrivateConstructor();
            //StaticConstructor staticConstructor = new StaticConstructor();

            //CopyConstructor parameterized = new CopyConstructor(5);
            //parameterized.Display();
            //CopyConstructor copyConstructor = new CopyConstructor(parameterized);
            //copyConstructor.Display();
            //Bank bank = new Bank();
            //You cannot access the Private Variable
            //bank.balance; //Compile Time Error
            //You can access the private variable via public setter and getter methods
            //bank.SetBalance(500);
            //Console.WriteLine(bank.GetBalance());
            //if we do not follow the encapsulation
            //IfDoNotFollowEncapsulation ifDoNotFollowEncapsulation = new IfDoNotFollowEncapsulation();
            // ifDoNotFollowEncapsulation.Amount = -250;
            // Console.WriteLine(ifDoNotFollowEncapsulation.Amount);
            //IfWeFollowEncapsulation ifWeFollowEncapsulation = new IfWeFollowEncapsulation();
            //ifWeFollowEncapsulation.SetAmount(10);
            //Console.WriteLine(ifWeFollowEncapsulation.GetAmount());
            //ProtectedAccessModifier protectedAccessModifier = new ProtectedAccessModifier();
            //protectedAccessModifier.Id

        }
    }
}
