using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Events
{
    //Step1: Define one delegate
    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    public class Worker
    {
        //Step2: Define one event to notify the work progress using the custom delegate
        public event WorkPerformedHandler WorkPerformed;
        //Step2: Define another event to notify when the work is completed using built-in EventHandler delegate
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, WorkType workType)
        {
            if (WorkPerformed != null)
            {
                //WorkPerformed(5, WorkType.GenerateReports);
                WorkPerformed.Invoke(5, WorkType.GenerateReports);
            }
            //Raising Events
            Console.WriteLine("Event Raised - " + WorkType.Golf);
        }

        public void DoWorkInOtherWay(int hours, WorkType workType)
        {
            WorkPerformedHandler del = WorkPerformed as WorkPerformedHandler;
            if (del != null)
            {
                del.Invoke(5, WorkType.GenerateReports);
            }
            //Raising Events
            Console.WriteLine("Event Raised - " + WorkType.Golf);
        }

        public virtual void OnWorkPerformed()
        {
            WorkPerformed?.Invoke(8, WorkType.GenerateReports);
        }
    }
    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}
