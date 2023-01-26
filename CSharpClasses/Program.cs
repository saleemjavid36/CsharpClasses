using CSharpClasses.Conditional_Statements;
using CSharpClasses.Input_Output;
using CSharpClasses.Loops;
using CSharpClasses.Methods;
using CSharpClasses.Operators;
using CSharpClasses.Variables;
using System;

namespace CSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UserInputOutput userInputOutput = new UserInputOutput();
            //userInputOutput.TakeInputFromUser();
            //Console.WriteLine("Hello Nishant");
            //Airthmatic airthmatic = new Airthmatic();
            //airthmatic.ArithmaticOperators();
            //Relational relational = new Relational();
            //relational.RelationalOperators();
            //Logical logical = new Logical();
            //logical.LogicalOperators();
            //Bitwise bitwise = new Bitwise();
            //bitwise.BitwiseOperators();
            //Ifclass ifclass = new Ifclass();
            //ifclass.Example();
            //Ifelse ifelse = new Ifelse();
            //ifelse.Example();
            //If_elseIf_else if_ElseIf_Else = new If_elseIf_else();
            //if_ElseIf_Else.Example();
            //TernaryOperator ternaryOperator = new TernaryOperator();
            //ternaryOperator.Example();
            //SwitchClass switchClass = new SwitchClass();
            //switchClass.Example();
            //ForLoop forLoop= new ForLoop();
            //forLoop.ForLoopExample();
            //WhileLoop whileLoop = new WhileLoop();
            //whileLoop.WhileLoopExample();
            //DoWhile doWhile = new DoWhile();
            //doWhile.DoWhileExample();
            ////InfiniteLoop infiniteLoop = new InfiniteLoop();
            ////infiniteLoop.InfiniteLoopExample();
            //BreakAndContinue breakAndContinue = new BreakAndContinue();
            //breakAndContinue.BreakAndContinueExample();
            //ForEach forEach = new ForEach();
            //forEach.ForEachLoopExample();
            //NestedLoop nestedLoop = new NestedLoop();
            //nestedLoop.NestedLoopExample();
            Method method = new Method();
            method.SumOfTwoNumbers();
            MethodWithParameters methodWithParameters = new MethodWithParameters();
            methodWithParameters.MethodCall();
            MethodWithReturnType methodWithReturnType = new MethodWithReturnType();
            methodWithReturnType.MethodCall();

        }
    }
}
