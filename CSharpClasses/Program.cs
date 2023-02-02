using CSharpClasses.Arrays;
using CSharpClasses.Conditional_Statements;
using CSharpClasses.Input_Output;
using CSharpClasses.Loops;
using CSharpClasses.Methods;
using CSharpClasses.OOPs.Abstraction;
using CSharpClasses.OOPs.AccessModifiers;
using CSharpClasses.OOPs.Constructor;
using CSharpClasses.OOPs.Encapsulation;
using CSharpClasses.OOPs.Inheritance;
using CSharpClasses.OOPs.Polymorphism;
using CSharpClasses.Operators;
using CSharpClasses.Variables;
using System;

namespace CSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            ////Abstraction not implemented
            //Console.WriteLine("Transaction doing SBI Bank");
            //SBI sbi = new SBI();
            //sbi.ValidateCard();
            //sbi.WithdrawMoney();
            //sbi.CheckBalanace();
            //sbi.BankTransfer();
            //sbi.MiniStatement();
            //Console.WriteLine("\nTransaction doing AXIX Bank");
            //AXIX AXIX = new AXIX();
            //AXIX.ValidateCard();
            //AXIX.WithdrawMoney();
            //AXIX.CheckBalanace();
            //AXIX.BankTransfer();
            //AXIX.MiniStatement();

            ////Abstraction implementation using Interface
            //Console.WriteLine("Transaction doing SBI Bank");
            //IBank sbiBank = BankFactory.GetBankObject("SBI");
            //sbiBank.ValidateCard();
            //sbiBank.WithdrawMoney();
            //sbiBank.CheckBalanace();
            //sbiBank.BankTransfer();
            //sbiBank.MiniStatement();
            //Console.WriteLine("\nTransaction doing AXIX Bank");
            //IBank AXIXBank = BankFactory.GetBankObject("AXIX");
            //AXIXBank.ValidateCard();
            //AXIXBank.WithdrawMoney();
            //AXIXBank.CheckBalanace();
            //AXIXBank.BankTransfer();
            //AXIXBank.MiniStatement();

            //// Abstraction implementation using Abstract class
            //Console.WriteLine("Transaction doing SBI Bank");
            //IBankInterface sbi_Bank = BankFactoryClass.GetBankObject("SBI");
            //sbi_Bank.ValidateCard();
            //sbi_Bank.WithdrawMoney();
            //sbi_Bank.CheckBalanace();
            //sbi_Bank.BankTransfer();
            //sbi_Bank.MiniStatement();
            //Console.WriteLine("\nTransaction doing AXIX Bank");
            //IBankInterface AXIX_Bank = BankFactoryClass.GetBankObject("AXIX");
            //AXIX_Bank.ValidateCard();
            //AXIX_Bank.WithdrawMoney();
            //AXIX_Bank.CheckBalanace();
            //AXIX_Bank.BankTransfer();
            //AXIX_Bank.MiniStatement();
        }
    }
}
