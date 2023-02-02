using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Polymorphism
{
    internal class RunTimePolymorphism_Parent
    {
        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Show Method");
        }
    }
    internal class RunTimePolymorphism_Child: RunTimePolymorphism_Parent
    {
        //Overriding Method
        public override void Show()
        {
            base.Show();
            RunTimePolymorphism_Parent obj = new RunTimePolymorphism_Parent();
            obj.Show();
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show Method");
        }
    }

    internal class RunTimePolymorphism
    {
        public void Display()
        {
            RunTimePolymorphism_Parent a = new RunTimePolymorphism_Child();
            a.Show();

            RunTimePolymorphism_Parent obj1 = new RunTimePolymorphism_Parent();
            obj1.Show();
            RunTimePolymorphism_Child obj2 = new RunTimePolymorphism_Child();
            obj2.Show();
            Console.ReadKey();
        }
        
    }

}
