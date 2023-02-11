using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Recursion
{
    internal class Recursion
    {

        public void CallFactorial()
        {
            int result = Factorial(5);
            Console.WriteLine("The factorial of " + 5 + " is: " + result);

        }
        public int Factorial(int number)
        {
            if (number == 1)
            {
                return 1; /* exiting condition */
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        public void PrintNumbersFromStartToEndPoint(int start, int end)
        {
            Console.WriteLine(start);

            if (start < end)
            {
                PrintNumbersFromStartToEndPoint(start + 1, end);
            }
        }
        public void PrintNumbersDividedByANumberInRange(int start, int end, int divisor)
        {
            if (start > end)
                return;
            if (start % divisor == 0)
                Console.WriteLine(start);
            PrintNumbersDividedByANumberInRange(start + 1, end, divisor);
        }


        public void PrintSequence(int n, string symbol)
        {
            if (n <= 0)
                return;
            Console.Write(symbol);
            PrintSequence(n - 1, symbol);
        }
    }
}
