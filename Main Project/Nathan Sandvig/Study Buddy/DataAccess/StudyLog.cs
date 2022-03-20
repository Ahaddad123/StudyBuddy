using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.DataAccess
{
    public class StudyLog
    {
        //wip find out how to impliment map
        Dictionary<int , Dictionary<int , double>> Log = new Dictionary<int , Dictionary<int, double>>();

        //---------------------------------------------------------------------
        // default constructor for studylog
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-19-22
        //---------------------------------------------------------------------
        public StudyLog()
        {
            Log = new Dictionary<int ,Dictionary<int, double>>();
        }

        //---------------------------------------------------------------------
        // constructor for studylog
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-19-22
        //---------------------------------------------------------------------
        public StudyLog(int week, int day, double hours)
        {
            Dictionary<int, double> dayLog = new Dictionary<int, double>()
            {
                {day, hours},
            };
            Log = new Dictionary<int , Dictionary<int, double>>()
            {
                {week,dayLog},
            };
        }

        //---------------------------------------------------------------------
        // Adds study time to a specified day
        // day:     date that the hours will be added to
        // newTime: time that will be added to the date
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-19-22
        //---------------------------------------------------------------------
        public void AddTimeToLog(double newTime, int day, int week)
        {
            /*
            if(log.ContainsKey(day))
            {
                log[day] = newTime + log[day];
            }
            else
            {
                log.Add(day, newTime);
            }
            */
            if(Log.ContainsKey(week))
            {
                Dictionary<int, double> checkLog = Log[week];
                if(checkLog.ContainsKey(day))
                {
                    checkLog[day] = newTime + checkLog[day];
                    Log[week] = checkLog;
                }
                else
                {
                    checkLog.Add(day, newTime);
                    Log[week] = checkLog;
                }
            }
            else
            {
                Dictionary<int, double> checkLog = new Dictionary<int, double>();
                checkLog.Add(day, newTime);
                Log.Add(week, checkLog);
            }
        }

        //---------------------------------------------------------------------
        // returns study hours for that date
        // day: date of hours being returned
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-20-22
        //---------------------------------------------------------------------
        public double GetHours(int day, int week)
         {
            /*
            if(log.ContainsKey(day))
            {
                return log[day];
            }
            else
            {
                return 0.0;
            }
            */
            if (Log.ContainsKey(week))
            {
                Dictionary<int, double> checkLog = Log[week];
                if (checkLog.ContainsKey(day))
                {
                    return checkLog[day];
                }
                else { return 0.0; }
            }
            else { return 0.0; }
         }
         
    }
}
