using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CSharpClasses.Operators
{
    internal class Bitwise
    {
        public void BitwiseOperators()
        {
            //Bitwise OR
            int firstNumber = 14, secondNumber = 11, result;
            result = firstNumber | secondNumber;
            Console.WriteLine("{0} | {1} = {2}", firstNumber, secondNumber, result);

            //Bitwise AND
            int  result1;
            result1 = firstNumber & secondNumber;
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result1);

            //Bitwise XOR
            int result2 = firstNumber ^ secondNumber;
            Console.WriteLine("{0} ^ {1} = {2}", firstNumber, secondNumber, result2);

            //Bitwise Complement 
            int number = 26, result3;
            result3 = ~number;
            Console.WriteLine("~{0} = {1}", number, result3);
            //We got -27 as output when we were expecting 229.Why did this happen?
            //It happens because the binary value 11100101 which we expect to be 229 is 
            //actually a 2's complement representation of -27. Negative numbers in computer are represented in 2's complement representation.
            //For any integer n, 2's complement of n will be -(n+1).

            //Bitwise Left Shift 
            int number1 = 42;
            Console.WriteLine("{0}<<1 = {1}", number1, number1 << 1);
            Console.WriteLine("{0}<<2 = {1}", number1, number1 << 2);
            Console.WriteLine("{0}<<4 = {1}", number1, number1 << 4);

            //Bitwise Right Shift
            int number2 = 42;
            Console.WriteLine("{0}>>1 = {1}", number2, number2 >> 1);
            Console.WriteLine("{0}>>2 = {1}", number2, number2 >> 2);
            Console.WriteLine("{0}>>4 = {1}", number2, number2 >> 4);


        }
    }
}
