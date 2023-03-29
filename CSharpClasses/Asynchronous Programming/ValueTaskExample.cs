using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClasses.Asynchronous_Programming
{
    internal class ValueTaskExample
    {
        public static Dictionary<int, string> cardDictionary = new Dictionary<int, string>()
            {
                { 1001, "1001 Card Info" },
                { 1002, "1002 Card Info" },
                { 1003, "1003 Card Info" },
                { 1004, "1004 Card Info" }
            };
        public void Example()
        {
            //Synchronous Call
            var Card1001Result = getCreditCard(1001);
            Console.WriteLine(Card1001Result);
            //Synchronous Call
            var Card1002Result = getCreditCard(1002);
            Console.WriteLine(Card1002Result);
            //Asynchronous Call
            var Card1006Result = getCreditCard(1006);
            Console.WriteLine(Card1006Result);
            Console.ReadKey();
        }
        public static async ValueTask<string> getCreditCard(int Id)
        {
            if (cardDictionary.ContainsKey(Id))
            {
                //We return synchronously if we have the cards info in the dictionary
                return cardDictionary[Id];
            }
            //If not available in the dicitonary, look for the card info in the database
            //asynchronous operation
            var card = $"Card Info - {Id} From Database";
            cardDictionary[Id] = card;
            return await Task.FromResult(card);
        }
    }
}
