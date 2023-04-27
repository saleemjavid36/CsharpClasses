using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Delegates
{
    
    internal class DelegatesExample
    {
        public delegate void WorkPerformedHandler(int hours, WorkType workType);
        public void Example()
        {
            DelegatesExample delegatesExample = new DelegatesExample();
            WorkPerformedHandler del = new WorkPerformedHandler(delegatesExample.Manager_WorkPerformed);
            del(5, WorkType.Golf);
        }

        public void Manager_WorkPerformed(int workHours, WorkType wType)
            {
                Console.WriteLine("Work Performed by Event Handler");
                Console.WriteLine($"Work Hours: {workHours}, Work Type: {wType}");
            }
    }
    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}
