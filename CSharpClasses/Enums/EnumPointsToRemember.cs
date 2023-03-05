using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Enums
{
    internal class EnumPointsToRemember//: WeekDays
    {
        public void Example()
        {
            // This following line will not compile. 
            // Cannot implicitly convert type 'Season' to 'Gender'. 
            // An explicit conversion is required.
            ///Gender gender = Season.Winter;
            // The following line comiples as we have an explicit cast
            Gender gender = (Gender)Season.Winter;
        }

        public void Example2()
        {
            int[] Values = (int[])Enum.GetValues(typeof(Gender));
            Console.WriteLine("Gender Enum Values");
            foreach (int value in Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            string[] Names = Enum.GetNames(typeof(Gender));
            Console.WriteLine("Gender Enum Names");
            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }
        }
    }

    public enum Season : int
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    }
    public enum WeekDays//: Season
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }

}