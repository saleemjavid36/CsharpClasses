using CSharpClasses.Loops;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Delegates.Anonymous_Method
{
    internal class AnonymousMethod
    {
         public delegate string GreetingsDelegate(string name);
        static void Example()
        {
            GreetingsDelegate gd = delegate (string name)
            {
                //break;
                //continue;

                return "Hello @" + name + " Welcome to Dotnet Tutorials";
            };
            string GreetingsMessage = gd.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage);
        }
    }
}
