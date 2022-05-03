using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    public class StudyLog
    {
        public Dictionary<DateTime, double> Log { get; set; }

        //---------------------------------------------------------------------
        // default constructor for studylog
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-19-22
        //---------------------------------------------------------------------
        public StudyLog()
        {
            Log = new Dictionary<DateTime, double>();
        }

        //---------------------------------------------------------------------
        // constructor for studylog
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-19-22
        //---------------------------------------------------------------------
        public StudyLog(DateTime date, double hours)
        {
            Log = new Dictionary<DateTime, double>();
            Log.Add(date.Date, hours);
        }

        //---------------------------------------------------------------------
        // Adds study time to a specified day
        // day:     date that the hours will be added to
        // newTime: time that will be added to the date
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-19-22
        //---------------------------------------------------------------------
        public void AddTimeToLog(double newTime, DateTime date)
        {
            //Checks to see if the date is in the log
            if(Log.ContainsKey(date.Date))
            {
                //adds the newTime to log at date
                Log[date.Date] = Log[date.Date] + newTime;
            }
            else
            {
                //added date with the given time to log
                Log.Add(date.Date, newTime);
            }
        }

        //---------------------------------------------------------------------
        // removes study time from a specified day
        // day:     date that the hours will be added to
        // newTime: time that will be added to the date
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-19-22
        //---------------------------------------------------------------------
        public void RemoveTimeFromLog(double newTime, DateTime date)
        {
            //checks to see if date is in the log
            if (Log.ContainsKey(date.Date))
            {
                //removes the specified hours from the log at the given date
                Log[date.Date] = Log[date.Date] - newTime;
            }
        }

        //---------------------------------------------------------------------
        // returns study hours for that date
        // day: date of hours being returned
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-20-22
        //---------------------------------------------------------------------
        public double GetHours(DateTime date)
         {
            //checks to see if date is in the log
            if (Log.ContainsKey(date.Date))
            {
                //returns the hours at the given date
                return Log[date.Date];
            }
            else { return 0.0; }
         }
         
    }
}
