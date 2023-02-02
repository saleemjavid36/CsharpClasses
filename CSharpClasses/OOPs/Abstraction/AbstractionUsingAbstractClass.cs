using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Abstraction
{
    public abstract class IBankInterface
    {
        public abstract void ValidateCard();
        public abstract void WithdrawMoney();
        public abstract void CheckBalanace();
        public abstract void BankTransfer();
        public abstract void MiniStatement();
    }
    public class BankFactoryClass
    {
        public static IBankInterface GetBankObject(string bankType)
        {
            IBankInterface BankObject = null;
            if (bankType == "SBI")
            {
                BankObject = new SBI_Bank();
            }
            else if (bankType == "AXIX")
            {
                BankObject = new AXIX_Bank();
            }
            return BankObject;
        }
    }
    public class SBI_Bank : IBankInterface
    {
        public override void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }
        public override void CheckBalanace()
        {
            Console.WriteLine("SBI Bank Check Balanace");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }
        public override void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }
    public class AXIX_Bank : IBankInterface
    {
        public override void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }
        public override void CheckBalanace()
        {
            Console.WriteLine("AXIX Bank Check Balanace");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }
        public override void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
}
