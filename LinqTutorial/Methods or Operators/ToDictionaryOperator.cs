using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class ToDictionaryOperator
    {
        public void Example()
        {
            List<Product> listProducts = new List<Product>
            {
                new Product { ID= 1001, Name = "Mobile", Price = 800 },
                new Product { ID= 1002, Name = "Laptop", Price = 900 },
                new Product { ID= 1003, Name = "Desktop", Price = 800 }
            };
            Dictionary<int, Product> productsDictionary = listProducts.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, Product> kvp in productsDictionary)
            {
                Console.WriteLine(kvp.Key + " Name : " + kvp.Value.Name + ", Price: " + kvp.Value.Price);
            }
        }

        public void Example2()
        {
            List<Product> listProducts = new List<Product>
            {
                new Product { ID= 1001, Name = "Mobile", Price = 800 },
                new Product { ID= 1002, Name = "Laptop", Price = 900 },
                new Product { ID= 1003, Name = "Desktop", Price = 800 }
            };
            Dictionary<int, string> productsDictionary = listProducts.ToDictionary(x => x.ID, x => x.Name);
            foreach (KeyValuePair<int, string> kvp in productsDictionary)
            {
                Console.WriteLine("Key : " + kvp.Key + " Value : " + kvp.Value);
            }
        }


        public void Example3()
        {
            List<Product> listProducts = null;
            Dictionary<int, string> productsDictionary = listProducts.ToDictionary(x => x.ID, x => x.Name);
            foreach (KeyValuePair<int, string> kvp in productsDictionary)
            {
                Console.WriteLine("Key : " + kvp.Key + " Value : " + kvp.Value);
            }

        }
    }
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
