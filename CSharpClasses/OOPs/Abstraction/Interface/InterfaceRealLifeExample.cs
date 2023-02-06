using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Abstraction.Interface
{
    //Define the interface with these 3 services
    interface IBankAccount
    {
        bool DepositAmount(decimal amount);
        bool WithdrawAmount(decimal amount);
        decimal CheckBalance();
    }
    interface IPrintPassbook
    {
        void PrintPassbook();
    }

    public class SavingAccount : IBankAccount, IPrintPassbook
    {
        private decimal Balance = 0;
        private readonly decimal PerDayWithdrawLimit = 10000;
        private decimal TodayWithdrawal = 0;
        public void PrintPassbook()
        {

        }
        public bool DepositAmount(decimal Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine($"You have Deposited: {Amount}");
            Console.WriteLine($"Your Account Balance: {Balance}");
            return true;
        }
        //Maximum Withdrawal Per Day: 10000
        public bool WithdrawAmount(decimal Amount)
        {
            if (Balance < Amount)
            {
                Console.WriteLine("You have Insufficient balance!");
                return false;
            }
            else if (TodayWithdrawal + Amount > PerDayWithdrawLimit)
            {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;
            }
            else
            {
                Balance = Balance - Amount;
                TodayWithdrawal = TodayWithdrawal + Amount;
                Console.WriteLine($"You have Successfully Withdraw: {Amount}");
                Console.WriteLine($"Your Account Balance: {Balance}");
                return true;
            }
        }
        public decimal CheckBalance()
        {
            return Balance;
        }
    }
    public class CurrentAccount : IBankAccount
    {
        private decimal Balance = 0;

        public bool DepositAmount(decimal Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine($"You have Deposited: {Amount}");
            Console.WriteLine($"Your Account Balance: {Balance}");
            return true;
        }
        public bool WithdrawAmount(decimal Amount)
        {
            if (Balance < Amount)
            {
                Console.WriteLine("You have Insufficient balance!");
                return false;
            }
            else
            {
                Balance = Balance - Amount;
                Console.WriteLine($"You have Successfully Withdraw: {Amount}");
                Console.WriteLine($"Your Account Balance: {Balance}");
                return true;
            }
        }
        public decimal CheckBalance()
        {
            return Balance;
        }
    }
}
