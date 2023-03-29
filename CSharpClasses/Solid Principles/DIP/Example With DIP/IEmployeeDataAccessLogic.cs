using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Solid_Principles.DIP.Example_With_DIP
{
    public interface IEmployeeDataAccessLogic
    {
        Employee GetEmployeeDetails(int id);
        //Any Other Employee Related Method Declarations
    }
}
