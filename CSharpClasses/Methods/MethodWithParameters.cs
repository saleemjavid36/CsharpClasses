using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Methods
{
    internal class MethodWithParameters
    {
        public void MethodWithparametersExample(string firstName, string lastName)
        {
            if (firstName == null || lastName == null)
            {
                throw new ArgumentNullException("Either first or last name is null");
            }
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }

        public void MethodCall()
        {
            Console.WriteLine("Enter the first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            string lastName = Console.ReadLine();
            MethodWithparametersExample(firstName, lastName);
        }

    }
}
