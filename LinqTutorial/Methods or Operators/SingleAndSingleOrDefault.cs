using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTutorial.Methods_or_Operators
{
    internal class SingleAndSingleOrDefault
    {
        public void SingleExample()
        {
            //Sequence contains one element
            List<int> numbers = new List<int>() { 10 };
            //Fetching the Only Element from the Sequenece using Method Syntax
            int numberMS = numbers.Single();
            //Fetching the Only Element from the Sequenece using Query Syntax
            int numberQS = (from num in numbers
                            select num).Single();
            //Printing the Returned element by Single Method
            Console.WriteLine(numberQS);
        }

        public void SingleWithEmptyDataSource()
        {
            //Sequence contains no element i.e. Empty Data Source
            List<int> numbers = new List<int>();
            //Fetching the Only Element from the Sequenece using Method Syntax
            int numberMS = numbers.Single();
        //Fetching the Only Element from the Sequenece using Query Syntax
        int numberQS = (from num in numbers
                        select num).Single();
        //Printing the Returned element by Single Method
        Console.WriteLine(numberQS);
        }

        public  void SingleWithCollectionHavingMoreThanOneItems()
        {
            //Sequence contains more than one element
            List<int> numbers = new List<int>() { 10, 20, 30 }; ;
            //Fetching the Only Element from the Sequenece using Method Syntax
            int numberMS = numbers.Single();
            //Fetching the Only Element from the Sequenece using Query Syntax
            int numberQS = (from num in numbers
                            select num).Single();
            //Printing the Returned element by Single Method
            Console.WriteLine(numberQS);
            Console.ReadLine();
        }

        public void SingleWithPredicate()
        {
            //Sequence contains more than one element
            List<int> numbers = new List<int>() { 10, 20, 30 }; ;
            //Fetching the Only Element from the Sequenece using Method Syntax
            //Where the Element is 20
            int numberMS = numbers.Single(num => num == 20);
            //Fetching the Only Element from the Sequenece using Query Syntax
            //Where the Element is 20
            int numberQS = (from num in numbers
                            select num).Single(num => num == 20);
            //Printing the Returned element by Single Method
            Console.WriteLine(numberQS);
        }

        public void SingleIfConditionReturnsMoreThanOneElement()
        {
            //Sequence contains more than one element
            List<int> numbers = new List<int>() { 10, 20, 30 }; ;
            //Fetching the Only Element from the Sequenece using Method Syntax
            //Where the Element > 10
            int numberMS = numbers.Single(num => num > 10);
            //Fetching the Only Element from the Sequenece using Query Syntax
            //Where the Element > 10
            int numberQS = (from num in numbers
                            select num).Single(num => num > 10);
            //Printing the Returned element by Single Method
            Console.WriteLine(numberQS);
        }

        public void SingleIfConditionDoesNotReturnAnyData()
        {
            //Sequence contains more than one element
            List<int> numbers = new List<int>() { 10, 20, 30 }; ;
            //Fetching the Only Element from the Sequenece using Method Syntax
            //Where the Element < 10
            int numberMS = numbers.Single(num => num < 10);
            //Fetching the Only Element from the Sequenece using Query Syntax
            //Where the Element < 10
            int numberQS = (from num in numbers
                            select num).Single(num => num < 10);
            //Printing the Returned element by Single Method
            Console.WriteLine(numberQS);
        }

        public void SingleOrDefaultExample()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };
            int number = numbers.SingleOrDefault(num => num < 10);
            Console.WriteLine(number);
        }

        public void SingleOrDefaultWhenSequenceIsEmpty()
        {
            //Sequence contains no element
            List<int> numbers = new List<int>();
            //Fetching the Only Element from the Sequenece using Method Syntax
            //Where the Element < 10
            int numberMS = numbers.SingleOrDefault(num => num < 10);
            //Fetching the Only Element from the Sequenece using Query Syntax
            //Where the Element < 10
            int numberQS = (from num in numbers
                            select num).SingleOrDefault(num => num < 10);
            //Printing the Returned element by Single Method
            Console.WriteLine(numberQS);
        }

        public void SingleOrDefaultWhenCollectionReturnsMoreThanOneElement()
        {
            //Sequence contains
            List<int> numbers = new List<int>() { 10, 20, 30 };
            //Fetching the Only Element from the Sequenece using Method Syntax
            //Where the Element > 10
            int numberMS = numbers.SingleOrDefault(num => num > 10);
            //Fetching the Only Element from the Sequenece using Query Syntax
            //Where the Element > 10
            int numberQS = (from num in numbers
                            select num).SingleOrDefault(num => num > 10);
            //Printing the Returned element by Single Method
            Console.WriteLine(numberQS);
        }
    }
}
