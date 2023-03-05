
using CSharpClasses.Collections.Generics;
using CSharpClasses.Collections.NonGenericCollection.ArrayList_Examples;
using CSharpClasses.Collections.NonGenericCollection.Hashtable_Examples;
using CSharpClasses.Enums;
using CSharpClasses.Events;
using CSharpClasses.Indexers;
using CSharpClasses.Ref_vs_Out;
using CSharpClasses.Tuple;
using System;

namespace CSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClsMain clsMain = new ClsMain();
                clsMain.Example();

                GenericsExample genericClass = new GenericsExample();
                genericClass.Example();

                MyGenericClass<int> integerGenericClass = new MyGenericClass<int>(10);
                int val = integerGenericClass.GenericMethod(200);
                Console.WriteLine(val);
                MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("Hello Generic World");
                stringGenericClass.GenericProperty = "This is a generic property example.";
                string result = stringGenericClass.GenericMethod("Generic Parameter");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("some error occured");
            }
        }
    }
}