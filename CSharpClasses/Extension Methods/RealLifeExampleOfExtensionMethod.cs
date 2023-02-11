using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpClasses.Extension_Methods
{
    public static class RealLifeExampleOfExtensionMethod
    {
        public static int GetWordCount(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                //Split the string by a space
                string[] strArray = inputstring.Split(' ');
                return strArray.Count();
            }
            else
            {
                return 0;
            }
        }
    }
}
