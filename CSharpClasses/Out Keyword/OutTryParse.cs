using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Out_Keyword
{
    internal class OutTryParse
    {
        public void Example()
        {
            string s = "09-Jun-2018";
            DateTime date;
            if (DateTime.TryParse(s, out date))
            {
                Console.WriteLine(date);
            }
            Console.WriteLine("Press any key to exit.");
        }
    }
}
