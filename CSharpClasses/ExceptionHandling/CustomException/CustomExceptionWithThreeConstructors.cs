using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.ExceptionHandling.CustomException
{
    internal class CustomExceptionWithThreeConstructors: Exception
    {
        public CustomExceptionWithThreeConstructors()
            {
            }
            public CustomExceptionWithThreeConstructors(string message)
                : base(message)
            {
            }
            public CustomExceptionWithThreeConstructors(string message, Exception inner)
                : base(message, inner)
            {
            }

            //Overriding the HelpLink Property
            public override string HelpLink
            {
                get
                {
                    return "To get more information subscribe my channel";
                }
            }
        }
}
