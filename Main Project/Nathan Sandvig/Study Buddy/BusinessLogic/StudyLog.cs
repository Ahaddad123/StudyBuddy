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
        Dictionary<DateTime, double> Log = new Dictionary<DateTime, double>();

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
            Log.Add(date, hours);
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
            if(Log.ContainsKey(date))
            {
                Log[date] = Log[date] + newTime;
            }
            else
            {
                Log.Add(date, newTime);
            }
        }

        public void RemoveTimeFromLog(double newTime, DateTime date)
        {
            if (Log.ContainsKey(date))
            {
                Log[date] = Log[date] - newTime;
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
            if (Log.ContainsKey(date))
            {
                return Log[date];
            }
            else { return 0.0; }
         }
         
    }
}
