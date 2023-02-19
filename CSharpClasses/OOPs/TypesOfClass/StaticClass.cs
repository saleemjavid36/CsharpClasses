using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.TypesOfClass
{
    public class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public void Insert()
        {
            //Insert the data
        }
    }

    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        private string MachineName = "";
        public void Insert()
        {
            if (CommonTask.IsEmpty(CustomerCode) && CommonTask.IsEmpty(CustomerName))
            {
                MachineName = CommonTask.GetComputerName();
            }
        }
    }

    public static class CommonTask
    {
       public static bool IsEmpty(string value)
        {
            if (value.Length > 0)
            {
                return true;
            }
            return false;

        }
        public static string GetComputerName()
        {
            return System.Environment.MachineName;
        }
    }



}
