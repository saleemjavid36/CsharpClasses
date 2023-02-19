using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.ExceptionHandling.CustomException
{
    public class OddNumberException : Exception
        {
            //Overriding the Message property
            public override string Message
            {
                get
                {
                    return "Divisor Cannot be Odd Number";
                }
            }
            //Overriding the HelpLink Property
            public override string HelpLink
            {
            get
            {
                return "Subscribe my channel for more information";
            }
        }
    }
}
