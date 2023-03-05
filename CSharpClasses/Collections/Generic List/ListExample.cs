using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Collections.Generic_List
{
    internal class ListExample
    {
        public void Example()
        {
            //Creating a Generic List of string type to store string elements
            List<string> countries = new List<string>();
            //Adding String Elements to the Generic List using the Add Method
            countries.Add("INDIA");
            countries.Add("USA");
            //The following Two Statements will give compile time error as element is not string type
            //countries.Add(100);
            //countries.Add(true);
            //Creating Another Generic List Collection of String Type
            List<string> newCountries = new List<string>();
            //Adding Elements using Add Method
            newCountries.Add("JAPAN");
            newCountries.Add("UK");
            //Adding the newCountries collection into countries collection using AddRange Method
            countries.AddRange(newCountries);
            //Accessing Generic List Elements using ForEach Loop
            Console.WriteLine("Accessing Generic List using For Each Loop");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Accessing Generic List Elements using For Loop
            Console.WriteLine("\nAccessing Generic List using For Loop");
            for (int i = 0; i < countries.Count; i++)
            {
                var element = countries[i];
                Console.WriteLine(element);
            }
            //Accessing List Elements by using the Integral Index Position
            Console.WriteLine("\nAccessing Individual List Element by Index Position");
            Console.WriteLine($"First Element: {countries[0]}");
            Console.WriteLine($"Second Element: {countries[1]}");
            Console.WriteLine($"Third Element: {countries[2]}");
            Console.WriteLine($"Fourth Element: {countries[3]}");
        }


        public void InsertAndInsertRange()
        {
            //Creating a Generic List of string type
            List<string> countries = new List<string>
            {
                "INDIA",
                "USA"
            };
            Console.WriteLine("Accessing List Elements Before Inserting");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Insert Element at Index Position 1
            countries.Insert(1, "China");
            Console.WriteLine($"\nIndex of China Element in the List : {countries.IndexOf("China")}");
            //Accessing List After Insert Method
            Console.WriteLine("\nAccessing List After Inserting China At Index 1");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Creating Another Generic List Collection of string type
            List<string> newCountries = new List<string>
            {
                "JAPAN",
                "UK"
            };
            //Inserting the newCountries collection into the existing countries list at Index 2 using InsertRange Method
            countries.InsertRange(2, newCountries);
            //Accessing countries List After InsertRange Method
            Console.WriteLine("\nAccessing List After InsertRange At Index 2");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
