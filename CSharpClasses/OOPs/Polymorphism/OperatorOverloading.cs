using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CSharpClasses.OOPs.Polymorphism
{
    internal class Complex
    {
        private int real;
        private int img;
        public Complex(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }
        public static Complex Add(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }
        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
    }
    public class OperatorOverloading
    {
        public void Display()
        {
            Complex c1 = new Complex(3, 7);
            c1.Display();
            Complex c2 = new Complex(5, 2);
            c2.Display();
            Complex c3 = Complex.Add(c1, c2);
            c3.Display();
        }
    }
}
