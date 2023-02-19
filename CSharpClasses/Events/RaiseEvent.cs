﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpClasses.Events
{
    //Step1: Define one delegate
    public delegate void PerformedHandler(int hours, WorkType workType);
    public class RaiseEvent
    {
        //Step2: Define one event to notify the work progress using the custom delegate
        public event PerformedHandler WorkPerformed;
        //Step2: Define another event to notify when the work is completed using buil-in EventHandler delegate
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, WorkType workType)
        {
            //Do Work here and notify the consumer that work has been performed
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
                Thread.Sleep(3000);
            }
            //Notify the consumer that work has been completed
            OnWorkCompleted();
        }
        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //Raising Events only if Listeners are attached
            //Approach1
            //if(WorkPerformed != null)
            //{
            //    WorkPerformed(8, WorkType.GenerateReports);
            //}
            //Approach2
            //WorkPerformed?.Invoke(8, WorkType.GenerateReports);
            //Approach3
            //WorkPerformedHandler del1 = WorkPerformed as WorkPerformedHandler;
            //if(del1 != null)
            //{
            //    del1(8, WorkType.GenerateReports);
            //}
            //Approach4
            if (WorkPerformed is PerformedHandler del2)
            {
                del2(8, WorkType.GenerateReports);
            }
        }
        protected virtual void OnWorkCompleted()
        {
            //Raising the Event
            //Approach1
            //EventHandler delegate takes two parameters i.e. object sender, EventArgs e
            //Sender is the current class i.e. this keyword and we do not need to pass any data
            //So, we need to pass Empty EventArgs
            //WorkCompleted?.Invoke(this, EventArgs.Empty);
            //Approach2
            if (WorkCompleted is EventHandler del)
            {
                del(this, EventArgs.Empty);
            }
            //Note: You can also use other two Approached
        }
    }
}
