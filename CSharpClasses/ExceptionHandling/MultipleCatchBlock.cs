using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.ExceptionHandling
{
    internal class MultipleCatchBlock
    {
        public void MultiCatch()
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                Number2 = int.Parse(Console.ReadLine());
                Result = Number1 / Number2;
                Console.WriteLine($"Result: {Result}");
            }
           
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Enter Only Integer Numbers which is greater than zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occured, please debug the code");
            }

        }

        public void MultiCatchWithDifferentTypeOfException()
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                Number2 = int.Parse(Console.ReadLine());
                Result = Number1 / Number2;
                Console.WriteLine($"Result: {Result}");
            }
            //int[] numbers = new int[10];

            //// This would throw an IndexOutOfRangeException because the index 11 is outside the bounds of the array
            //int number = numbers[11];

            //string str = null;

            //// This would throw a NullReferenceException because str is null and doesn't have a reference to an instance of the string class
            //int length = str.Length;
            //    int a = int.MaxValue;
            //    int b = int.MaxValue;

            //    // This would throw an OverflowException because the result of a + b is too large to be stored in an int data type
            //    int c = a + b;
            //}


            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Enter Only Integer Numbers");
            }
            catch (IndexOutOfRangeException IORE)
            {
                Console.WriteLine("Enter Only valid index number");
            }
            //catch (NullReferenceException NRE)
            //{
            //    Console.WriteLine("string should not be null");
            //}
            catch (OverflowException OE)
            {
                Console.WriteLine("enter a valid value");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Catch Block...");
            }
        }
    }

}
