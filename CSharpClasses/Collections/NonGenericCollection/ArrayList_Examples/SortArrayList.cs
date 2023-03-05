using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Collections.NonGenericCollection.ArrayList_Examples
{
    internal class SortArrayList
    {
        public void Example()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "Nepal",
                    "HongKong",
                    "Austrailla",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "Brazil",
            };
            Console.WriteLine("Array List Elements Before Sorting");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            // Sorting the elements of  ArrayList Using sort() method
            arrayList.Sort();
            Console.WriteLine("\n\nArray List Elements After Sorting");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
