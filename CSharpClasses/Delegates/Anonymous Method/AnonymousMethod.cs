using CSharpClasses.Loops;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Delegates.Anonymous_Method
{
    internal class AnonymousMethod
    {
         public delegate string GreetingsDelegate (string name);
        public void Example()
        {
            GreetingsDelegate gd = delegate (string name)
            {
                

                return "Hello @" + name + " Welcome to Dotnet Tutorials";
            };
            string GreetingsMessage = gd.Invoke("Nishant");
            Console.WriteLine(GreetingsMessage);
        }
    }
}
