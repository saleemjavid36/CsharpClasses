using CSharpClasses.Arrays;
using CSharpClasses.Conditional_Statements;
using CSharpClasses.Delegates;
using CSharpClasses.Delegates.Multicast_Delegates;
using CSharpClasses.Delegates.RealLifeExample;
using CSharpClasses.ExceptionHandling;
using CSharpClasses.ExceptionHandling.CustomException;
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
using CSharpClasses.Operators;
using CSharpClasses.Variables;
using System;

namespace CSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //WithoutDelegates withoutDelegates = new WithoutDelegates();
                //withoutDelegates.Example();

                //MutlicastClass mutlicastClass = new MutlicastClass();
                //mutlicastClass.MulticastExample();

                //UseMulticastInDifferentWay useMulticastInDifferentWay = new UseMulticastInDifferentWay();
                //useMulticastInDifferentWay.Example();

                MulticastDelegateWithReturnType multicastDelegateWithReturnType = new MulticastDelegateWithReturnType();
                multicastDelegateWithReturnType.Example();

                MulticastDelegateUsingOutParameter multicastDelegateUsingOutParameter = new MulticastDelegateUsingOutParameter();
                multicastDelegateUsingOutParameter.Example();

            }
            catch(Exception ex)
            {
                Console.WriteLine("some error occured");
            }
            
        }
    }
}