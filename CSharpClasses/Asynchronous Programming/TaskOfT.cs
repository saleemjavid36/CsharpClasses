using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClasses.Asynchronous_Programming
{
    internal class TaskOfT
    {
        public static async Task<Weather> Get(string city)
        {
            await Task.Delay(10);
            var weather = new Weather
            {
                City = city,
                Date = DateTime.Now,
                AvgTempratureF = new Random().Next(5, 70)
            };

            return weather;
        }
        //static async Task CheckTaskStatus()
        //{

        //}
        public static void LogTaskStatus(TaskStatus status)
        {
            Console.WriteLine($"Task Status: {Enum.GetName(typeof(TaskStatus), status)}");
        }
    }
    public class Weather
    {
        public string City { get; set; }
        public DateTime Date { get; set; }
        public double AvgTempratureF { get; set; }
    }

   
}
