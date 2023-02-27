using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Indexers
{
    public class Employee
    {
        //Declare the properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        //Initialize the properties through constructor
        public Employee(int ID, string Name, string Job, int Salary, string Location,
                        string Department, string Gender)
        {
            this.ID = ID;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Location = Location;
            this.Department = Department;
            this.Gender = Gender;
        }
        public object this[int index]
        {
            //The get accessor is used for returning a value
            get
            {
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Location;
                else if (index == 5)
                    return Department;
                else if (index == 6)
                    return Gender;
                else
                    return null;
            }

            // The set accessor is used to assigning a value
            set
            {
                if (index == 0)
                    ID = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Job = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToDouble(value);
                else if (index == 4)
                    Location = value.ToString();
                else if (index == 5)
                    Department = value.ToString();
                else if (index == 6)
                    Gender = value.ToString();
            }
        }

        //public object this[string Name]
        //{
        //    //The get accessor is used for returning a value
        //    get
        //    {
        //        if (Name == "ID")
        //            return ID;
        //        else if (Name == "Name")
        //            return Name;
        //        else if (Name == "Job")
        //            return Job;
        //        else if (Name == "Salary")
        //            return Salary;
        //        else if (Name == "Location")
        //            return Location;
        //        else if (Name == "Department")
        //            return Department;
        //        else if (Name == "Gender")
        //            return Gender;
        //        else
        //            return null;
        //    }

        //    // The set accessor is used to assigning a value
        //    set
        //    {
        //        if (Name == "ID")
        //            ID = Convert.ToInt32(value);
        //        else if (Name == "Name")
        //            Name = value.ToString();
        //        else if (Name == "Job")
        //            Job = value.ToString();
        //        else if (Name == "Salary")
        //            Salary = Convert.ToDouble(value);
        //        else if (Name == "Location")
        //            Location = value.ToString();
        //        else if (Name == "Department")
        //            Department = value.ToString();
        //        else if (Name == "Gender")
        //            Gender = value.ToString();
        //    }
        //}

    }

public class CallMethod
    {
        public void Example()
        {
            Employee emp = new Employee(101, "Pranaya", "SSE", 10000, "Mumbai", "IT", "Male");
            Console.WriteLine("EID = " + emp[0]);
            Console.WriteLine("Name = " + emp[1]);
            Console.WriteLine("Job = " + emp[2]);
            Console.WriteLine("Salary = " + emp[3]);
            Console.WriteLine("Location = " + emp[4]);
            Console.WriteLine("Department = " + emp[5]);
            Console.WriteLine("Gender = " + emp[6]);
            emp[1] = "Kumar";
            emp[3] = 65000;
            emp[5] = "BBSR";
            Console.WriteLine("=======Afrer Modification=========");
            Console.WriteLine("EID = " + emp[0]);
            Console.WriteLine("Name = " + emp[1]);
            Console.WriteLine("Job = " + emp[2]);
            Console.WriteLine("Salary = " + emp[3]);
            Console.WriteLine("Location = " + emp[4]);
            Console.WriteLine("Department = " + emp[5]);
            Console.WriteLine("Gender = " + emp[6]);
            //Console.WriteLine("EID = " + emp["ID"]);
            //Console.WriteLine("Name = " + emp["Name"]);
            //Console.WriteLine("Job = " + emp["job"]);
            //Console.WriteLine("Salary = " + emp["salary"]);
            //Console.WriteLine("Location = " + emp["Location"]);
            //Console.WriteLine("Department = " + emp["department"]);
            //Console.WriteLine("Gender = " + emp["Gender"]);
            //emp["Name"] = "Kumar";
            //emp["salary"] = 65000;
            //emp["Location"] = "BBSR";
            //Console.WriteLine("=======Afrer Modification=========");
            //Console.WriteLine("EID = " + emp["ID"]);
            //Console.WriteLine("Name = " + emp["Name"]);
            //Console.WriteLine("Job = " + emp["job"]);
            //Console.WriteLine("Salary = " + emp["salary"]);
            //Console.WriteLine("Location = " + emp["Location"]);
            //Console.WriteLine("Department = " + emp["department"]);
            //Console.WriteLine("Gender = " + emp["Gender"]);
        }
    }
}
