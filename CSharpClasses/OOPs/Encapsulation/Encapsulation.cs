using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Encapsulation
{
    public class Bank
    {
        //Hiding class data by declaring the variable as private
        private double balance;
        //Creating public Setter and Getter methods
        //Public Getter Method
        //This method is used to return the data stored in the balance variable
        public double GetBalance()
        {
            //add validation logic if needed
            return balance;
        }
        //Public Setter Method
        //This method is used to stored the data  in the balance variable
        public void SetBalance(double balance)
        {
            // add validation logic to check whether data is correct or not
            this.balance = balance;
        }
    }
}
