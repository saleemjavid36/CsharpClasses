using CSharpClasses.Arrays;
using CSharpClasses.Conditional_Statements;
using CSharpClasses.Input_Output;
using CSharpClasses.Loops;
using CSharpClasses.Methods;
using CSharpClasses.OOPs.Abstraction;
using CSharpClasses.OOPs.Abstraction.Interface;
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
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.CheckBalance();
            savingAccount.DepositAmount(5000);
            savingAccount.WithdrawAmount(2000);
            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.CheckBalance();
            currentAccount.DepositAmount(2000);
            currentAccount.CheckBalance();
            currentAccount.WithdrawAmount(500);

        }
    }
}
