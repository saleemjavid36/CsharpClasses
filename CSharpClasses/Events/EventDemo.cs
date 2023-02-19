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
            //Raising Events
        }
    }
    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}
