using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Collections.NonGenericCollection.Hashtable_Examples
{
    internal class HashtableExample
    {
        public void Example()
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using key value pair
            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
            hashtable.Add("Name", "James"); //Here key is Name and value is James
            hashtable.Add("Salary", 3500); //Here key is Salary and value is 3500
            hashtable.Add("Location", "Mumbai"); //Here key is Location and value is Mumbai
            hashtable.Add("EmailID", "a@a.com"); //Here key is EmailID and value is a@a.com
            //Printing the keys and their values using foreach loop
            Console.WriteLine("Printing Hashtable using Foreach Loop");
            foreach (object obj in hashtable.Keys)
            {
                Console.WriteLine(obj + " : " + hashtable[obj]);
            }
            //Or
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            }
            Console.WriteLine("\nPrinting Hashtable using Keys");
            //I want to print the Location by using the Location key
            Console.WriteLine("Location : " + hashtable["Location"]);
            //I want to print the Email ID by using the EmailID key
            Console.WriteLine("Emaild ID : " + hashtable["EmailID"]);
        }
    
    public void Initializer()
        {
            //Creating a Hashtable using collection-initializer syntax
            Hashtable citiesHashtable = new Hashtable(){
                            {"UK", "London, Manchester, Birmingham"}, //Key:UK, Value:London, Manchester, Birmingham
                            {"USA", "Chicago, New York, Washington"}, //Key:USA, Value:Chicago, New York, Washington
                            {"India", "Mumbai, New Delhi, Pune"}      //Key:India, Value:Mumbai, New Delhi, Pune
                        };
            Console.WriteLine("Creating a Hashtable Using Collection-Initializer");
            foreach (DictionaryEntry city in citiesHashtable)
            {
                Console.WriteLine($"Key: {city.Key}, Value: {city.Value}");
            }
        }
    
    public void CheckAvailibility()
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using key value pair
            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
            hashtable.Add("Name", "James"); //Here key is Name and value is James
            hashtable.Add("Job", "Developer");
            hashtable.Add("Salary", 3500);
            hashtable.Add("Location", "Mumbai");
            hashtable.Add("Dept", "IT");
            hashtable.Add("EmailID", "a@a.com");
            //Checking the key using the Contains methid
            Console.WriteLine("Is EmailID Key Exists : " + hashtable.Contains("EmailID"));
            Console.WriteLine("Is Department Key Exists : " + hashtable.Contains("Department"));
            //Checking the key using the ContainsKey methid
            Console.WriteLine("Is EmailID Key Exists : " + hashtable.ContainsKey("EmailID"));
            Console.WriteLine("Is Department Key Exists : " + hashtable.ContainsKey("Department"));
            //Checking the value using the ContainsValue method
            Console.WriteLine("Is Mumbai value Exists : " + hashtable.ContainsValue("Mumbai"));
            Console.WriteLine("Is Technology value Exists : " + hashtable.ContainsValue("Technology"));
        }
        public void RemoveAndClear()
        {
            Hashtable employee = new Hashtable
            {
                { "EId", 1001 },
                { "Name", "James" },
                { "Salary", 3500 },
                { "Location", "Mumbai" },
                { "EmailID", "a@a.com" }
            };
            //Count Property returns the number of elements present in the collection
            Console.WriteLine($"Hashtable Total Elements: {employee.Count}");
            // Remove EId as this key exists
            employee.Remove("EId");
            Console.WriteLine($"After Removing EID Total Elements: {employee.Count}");
            //Following statement throws run-time exception: KeyNotFoundException
            //employee.Remove("City"); 
            //Check key before removing it
            if (employee.ContainsKey("City"))
            {
                employee.Remove("City");
            }
            else
            {
                Console.WriteLine("Hashtable doesnot contain City key");
            }
            //Removes all elements
            employee.Clear();
            Console.WriteLine($"After Clearing Hashtable Total Elements: {employee.Count}");
        }
    
    public void AssignAndUpdateWithIndexers()
        {

            Hashtable hashtable = new Hashtable();
            hashtable[1] = "One";
            hashtable[5] = "Five";
            hashtable[30] = "Thirty";
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            }
            //Updating 
            hashtable[1] = "Smith"; //Update value of  key
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            }
        }

        public void CloneHashtable()
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using Add method
            hashtable.Add("EId", 1001);
            hashtable.Add("Name", "James");
            hashtable.Add("Job", "Developer");
            hashtable.Add("Salary", 3500);
            hashtable.Add("Location", "Mumbai");
            hashtable.Add("Dept", "IT");
            hashtable.Add("EmailID", "a@a.com");
            Console.WriteLine("Hashtable  Elements:");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            //Creating a clone Hashtable using Clone method
            Hashtable cloneHashtable = (Hashtable)hashtable.Clone();
            Console.WriteLine("\nCloned Hashtable Elements:");
            foreach (DictionaryEntry item in cloneHashtable)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }

    }
}
