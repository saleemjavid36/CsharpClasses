using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Collections.NonGenericCollection.ArrayList_Examples
{
    internal class ArrayListExample
    {
        public void Example()
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add("James"); //Adding Duplicate Value
            arrayList1.Add(" "); //Adding Empty
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            arrayList1.Add(null); //Adding null
            Console.WriteLine(arrayList1.Count);
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            //Insert "First Element" at First Position i.e. Index 0
            arrayList1.Insert(0, "First Element");
            //Insert "Third Element" at Third Position i.e. Index 2
            arrayList1.Insert(2, "Third Element");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            //Adding Elements to ArrayList using object initializer syntax
            var arrayList2 = new ArrayList()
            {
                102, "Smith", "Smith", true, 15.6
            };

            arrayList1.InsertRange(0, arrayList2);
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
