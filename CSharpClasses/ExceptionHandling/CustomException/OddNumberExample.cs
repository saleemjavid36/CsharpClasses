 using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.ExceptionHandling.CustomException
{
    internal class OddNumberExample
 {      public void CustomErrorExample()
        {
        int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number:");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                Number2 = int.Parse(Console.ReadLine());
                if (Number2 % 2 > 0)
                {
                    //OddNumberException ONE = new OddNumberException();
                    //throw ONE;
                    throw new CustomExceptionWithThreeConstructors("Value can not be odd");
                    //throw new CustomExceptionWithThreeConstructors("Number is not valid");
                }
                Result = Number1 / Number2;
                Console.WriteLine(Result);
            }
            catch (CustomExceptionWithThreeConstructors one)
            {
                int a = 5;
                int b = 0;
                if (b == 0)
                    throw new CustomExceptionWithThreeConstructors("this is the outer error", one);

                Console.WriteLine($"Message: {one.Message}");
                Console.WriteLine($"HelpLink: {one.HelpLink}");
                Console.WriteLine($"Source: {one.Source}");
                Console.WriteLine($"StackTrace: {one.StackTrace}");
            }
            //catch (CustomExceptionWithThreeConstructors custom)
            //{
            //    Console.WriteLine($"Message: {custom.Message}");
            //    Console.WriteLine($"HelpLink: {custom.HelpLink}");
            //    Console.WriteLine($"Source: {custom.Source}");
            //    Console.WriteLine($"StackTrace: {custom.StackTrace}");
            //}
        Console.WriteLine("End of the Program");
    }
}
}
