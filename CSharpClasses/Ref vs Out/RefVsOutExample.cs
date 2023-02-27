using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Ref_vs_Out
{
    internal class RefVsOutExample
    {
        public void RefMethod()
        {
            CallMethod_Ref();
        }

        public void OutMethod()
        {
            CallMethod_Out();
        }

        public void CallMethod_Ref()
        {
            int Addition = 0;
            int Multiplication = 0;
            int Subtraction = 0;
            int Division = 0;
            Math_Using_Ref(200, 100, ref Addition, ref Multiplication, ref Subtraction, ref Division);
            Console.WriteLine($"Addition: {Addition}");
            Console.WriteLine($"Multiplication: {Multiplication}");
            Console.WriteLine($"Subtraction: {Subtraction}");
            Console.WriteLine($"Division: {Division}");
        }
        public void CallMethod_Out()
        {
           
            Math_Using_Out(200, 100, out int Addition, out int Multiplication, out int Subtraction, out int Division);
            Console.WriteLine($"Addition: {Addition}");
            Console.WriteLine($"Multiplication: {Multiplication}");
            Console.WriteLine($"Subtraction: {Subtraction}");
            Console.WriteLine($"Division: {Division}");
        }
        public void Math_Using_Ref(int number1, int number2, ref int Addition, ref int Multiplication, ref int Subtraction, ref int Division)
        {
            Addition = number1 + number2;
            Multiplication = number1 * number2;
            Subtraction = number1 - number2;
            Division = number1 / number2;
        }
        public static void Math_Using_Out(int number1, int number2, out int Addition, out int Multiplication, out int Subtraction, out int Division)
        {
            Addition = number1 + number2;
            Multiplication = number1 * number2;
            Subtraction = number1 - number2;
            Division = number1 / number2;
        }
    }
}
