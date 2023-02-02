using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Abstraction.Interface
{
    internal class InterfaceInterviewQuestions
    {
        //  why do we need interface in C# 
        // Answer - to support multiple inheritance
        //Is more than one Interface allowed to Implement a Class in C#?
        interface I1
        {
        
        }
        interface I2
        {
        }

        class A
        {
        }
        class B 
        {
        }
        class C: A,I1,I2
        {

        }

        // Can an interface implement abstract class ?

        abstract class AA
        { 
        }

        interface I3 {
          public void Add();
            public void Remove();
        }

        // can an interface be declare as sealed ?
        //sealed interface I4 { }

        //Is it Necessary to Implement all Interface Methods in C#?
        abstract class AB: I3
        { 
           

            public void Add()
            {
                throw new NotImplementedException();
            }

            public abstract void Remove();

        }



    }
}
