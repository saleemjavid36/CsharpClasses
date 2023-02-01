using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.AccessModifiers
{
    public class PublicAccessModifier
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void PrintAge()
        {
            Console.WriteLine(26);
        }

    }

    public class BB { 
    
    public void PublicModifierExample()
        {
            PublicAccessModifier publicAccessModifier = new PublicAccessModifier();
            publicAccessModifier.Name = "Nishant";
            publicAccessModifier.Age = 26;
            publicAccessModifier.PrintAge();
        }
    }

    public class BC: PublicAccessModifier { 
    
        public void Example()
        {
            Name = "Nishant";
            Age = 26;
            PrintAge();
        }
    }



}
