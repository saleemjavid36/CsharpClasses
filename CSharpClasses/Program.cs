
using CSharpClasses.Enums;
using CSharpClasses.Ref_vs_Out;
using System;

namespace CSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //EnumExample example = new EnumExample();
                //example.Example();

                EnumPointsToRemember points = new EnumPointsToRemember();
                points.Example();
                points.Example2();


            }
            catch (Exception ex)
            {
                Console.WriteLine("some error occured");
            }
            
        }
    }
}