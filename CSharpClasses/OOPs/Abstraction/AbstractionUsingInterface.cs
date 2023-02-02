using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Abstraction
{
    public interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();
    }
    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if (bankType == "SBI")
            {
                BankObject = new SBIBank();
            }
            else if (bankType == "AXIX")
            {
                BankObject = new AXIXBank();
            }
            return BankObject;
        }
    }
    public class SBIBank : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }
        public void CheckBalanace()
        {
            Console.WriteLine("SBI Bank Check Balanace");
        }
        public void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }
        public void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }
    public class AXIXBank : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }
        public void CheckBalanace()
        {
            Console.WriteLine("AXIX Bank Check Balanace");
        }
        public void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }
        public void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
}
