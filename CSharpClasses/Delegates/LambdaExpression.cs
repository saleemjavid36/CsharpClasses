using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Delegates
{
    public class LambdaExpression
    {
        public delegate string GreetingsDelegate(string name);
        public void Example()
        {
            GreetingsDelegate obj = (name) =>
            {
                return "Hello @" + name + " welcome to Dotnet Tutorials";
            };
            string GreetingsMessage = obj.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }
        public static string Greetings(string name)
        {
            return "Hello @" + name + " welcome to Dotnet Tutorials";
        }
    }
}
