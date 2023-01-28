using CSharpClasses.Arrays;
using CSharpClasses.Conditional_Statements;
using CSharpClasses.Input_Output;
using CSharpClasses.Loops;
using CSharpClasses.Methods;
using CSharpClasses.OOPs;
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
            //ArrayClass array = new ArrayClass();
            //array.ArrayExample();
            //IterationArrayUsingLoop iterationArrayUsingLoop = new IterationArrayUsingLoop();
            //iterationArrayUsingLoop.Example();
            //MultiDimensionalArray multiDimensionalArrayUsingLoop = new MultiDimensionalArray();
            //multiDimensionalArrayUsingLoop.MultiDimensionalArrayExample();
            //Method method = new Method();
            //method.SumOfTwoNumbers();
            //MethodWithParameters methodWithParameters = new MethodWithParameters();
            //methodWithParameters.MethodCall();
            //MethodWithReturnType methodWithReturnType = new MethodWithReturnType();
            //methodWithReturnType.MethodCall();
            //DefaultParameter defaultParameter = new DefaultParameter();
            //defaultParameter.MethodCall();
            Student student = new Student();
            student.Id = 1;
            student.FirstName = "Nishant";
            student.LastName = "Gupta";
            student.Mobile = 9870880111;
            student.PrintNameLength();

            Student student2 = new Student();
            student.Id = 2;
            student.FirstName = "Shubham";
            student.LastName = "Gupta";
            student.Mobile = 123456754;
            student.PrintNameLength();
        }
    }
}
