using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class stringSubSequences
    {
        public void SubSequence(string str, int idx, string res)
        {
            if (idx == str.Length)
            {
                Console.WriteLine(res);
                return;
            }
            SubSequence(str, idx + 1, res + str[idx]);
            SubSequence(str, idx + 1, res);
        }

        public void Example()
        {
            string str = "abc";
            SubSequence(str, 0, "");
        }
    }
}
