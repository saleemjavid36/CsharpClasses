using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Input_Output
{
    public class UserInputOutput
    {
        public void TakeInputFromUser()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("The length of the name is - " + name.Length);
            Console.Write("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is " + name + " you are " + age + " years old");
        }

    }
}
