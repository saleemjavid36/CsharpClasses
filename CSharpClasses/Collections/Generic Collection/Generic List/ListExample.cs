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
        }

        public void CheckAvailibility()
        {
            //Creating a Generic List of string type and adding elements using collection initializer
            List<string> countries = new List<string>
            {
                "INDIA",
                "USA",
                "JAPAN",
                "UK"
            };
            //Accessing List Elements using ForEach Loop
            Console.WriteLine("All Generic List Elemenst");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Checking the Item using the Contains method
            Console.WriteLine("\nIs INDIA Exists in List: " + countries.Contains("INDIA"));
            Console.WriteLine("Is NZ Exists in List: " + countries.Contains("NZ"));
        }
  
        public void RemoveMethods()
        {
            //Creating a Generic List of string type and adding elements using collection initializer
            List<string> countries = new List<string>
            {
                "INDIA",
                "USA",
                "JAPAN",
                "UK",
                "AUSTRALIA",
                "SRILANKA",
                "BANGLADESG",
                "NEPAL",
                "CHINA",
                "NZ",
                "SOUTH AFRICA"
            };
            Console.WriteLine($"Before Removing Element Count : {countries.Count}");
            //Using Remove method to Remove an Element from the List
            Console.WriteLine($"\nRemoving Element SRILANKA : {countries.Remove("SRILANKA")}");
            Console.WriteLine($"After Removing SRILANKA Element Count : {countries.Count}");
            //Removing Element using Index Position from the List
            countries.RemoveAt(2);
            Console.WriteLine($"\nAfter Removing Index 2 Element Count : {countries.Count}");
            // Using RemoveAll method to Remove Elements from the List
            // Here, we are removing element whose length is less than 3 i.e. UK and NZ
            //countries.RemoveAll(x => x.Length < 3);
            Console.WriteLine($"\nRemoveAll Method Removes: {countries.RemoveAll(x => x.Length < 3)} Element(s)");
            Console.WriteLine($"After RemoveAll Method Element Count : {countries.Count}");
            //Removing Element using RemoveRange(int index, int count) Method
            //Here, we are removing the first two elements
            countries.RemoveRange(0, 2);
            Console.WriteLine($"\nAfter RemoveRange Method Element Count : {countries.Count}");
            //Removing All Elements using Clear method
            countries.Clear();
            Console.WriteLine($"\nAfter Clear Method Element Count : {countries.Count}");
        }

        public void CopyList()
        {
            // Create new array with 3 elements.
            string[] array = new string[] { "INDIA", "USA", "UK" };
            // Copy the array to a List.
            List<string> copiedList = new List<string>(array);
            Console.WriteLine("Copied Elements in List");
            foreach (var item in copiedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
