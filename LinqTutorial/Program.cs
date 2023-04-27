
using LinqTutorial.Methods_or_Operators;
using LinqTutorial.Methods_or_Operators.Joins;
using LinqTutorial.Query_Syntax;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqTutorial
{
    internal class Program
    {
        static void Main(string[] args)
           {
            InnerJoin inner = new InnerJoin();
            inner.InnerJoinExample();
            inner.InnerJoinProjection();

            GroupJoin groupJoin = new GroupJoin();
            groupJoin.Example();
            groupJoin.ExampleUsingQuerySyntax();

            LeftJoin leftJoin = new LeftJoin();
            leftJoin.LeftJoinExample();
            leftJoin.LeftJoinUsingMethodSyntax();
            leftJoin.ProjectingTheResult();

            RightJoin rightJoin = new RightJoin();
            rightJoin.Example();

            FullJoin fullJoin = new FullJoin();
            fullJoin.Example();
            fullJoin.FullJoinUsingMethodSyntax();

            CrossJoin crossJoin = new CrossJoin();
            crossJoin.Example();





          }
    }
}
