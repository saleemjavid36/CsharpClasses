using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Collections.NonGenericCollection.ArrayList_Examples
{
    internal class RemoveElementsFromArraylist
    {
        public void Example()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal",
                    "HongKong",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "HongKong",
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.Remove("HongKong"); //Removes first occurance of null
            Console.WriteLine("\n\nArray List Elements After Removing First Occurances of HongKong");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveAt(3); //Removes element at index postion 3, it is 0 based index
            Console.WriteLine("\n\nArray List1 Elements After Removing Element from Index 3");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            Console.WriteLine("\n\nArray List Elements After Removing First Two Elements");

            int totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"Total Items: {totalItems}, Capacity: {arrayList.Capacity}"));
            //Remove all items from the Array list             
            arrayList.Clear();
            totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"Total Items After Clear(): {totalItems}, Capacity: {arrayList.Capacity}"));

            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
        }

        public void ContainElement()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "UK",
                    "Nepal",
                    101
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\n\nIs ArrayList Contains India: {arrayList.Contains("India")}"); // true
            Console.WriteLine($"Is ArrayList Contains USA: {arrayList.Contains("USA")}"); // false
            Console.WriteLine($"Is ArrayList Contains 101: {arrayList.Contains(101)}"); // true
            Console.WriteLine($"Is ArrayList Contains 10.5: {arrayList.Contains(10.5)}"); // false
        }
    }
}
