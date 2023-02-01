using System;

namespace OtherAssembly
{
    public class Program
    {
        private protected int Salary { get; set; }
        protected internal int Age { get; set; }
        protected int Id { get; set; }
        public string Name { get; set; }  
        protected internal void PrintAge()
        {
            Console.WriteLine(Age);
        }
        public void Display()
        {
            Id = 1;
            Console.WriteLine(Id);
        }
        private protected void PrintSalary()
        {
            Salary = 10000;
            Console.WriteLine(Salary);
        }
    }

    public class Child : Program
    { 
        public void Example()
        {
            Id = 5;
            Age = 26;
            Salary = 20000;
            PrintSalary();
            Console.WriteLine(Id);
            PrintAge();
        }
    }

    public class Third
    { 
    public void Display()
        {
            Program program = new Program();
            program.Age = 26;
            program.PrintAge();
        }
    }


}
