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
        Dictionary<int , double> log = new Dictionary<int , double>();
        Dictionary<int , Dictionary<int , double>> newLog = new Dictionary<int , Dictionary<int, double>>();

        //---------------------------------------------------------------------
        // default constructor for studylog
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-7-22
        //---------------------------------------------------------------------
        public StudyLog()
        {
            newLog = new Dictionary<int ,Dictionary<int, double>>();
        }

        //---------------------------------------------------------------------
        // constructor for studylog
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-7-22
        //---------------------------------------------------------------------
        public StudyLog(int week, int day, double hours)
        {
            log = new Dictionary<int, double>()
            {
                {day, hours},
            };
            newLog = new Dictionary<int , Dictionary<int, double>>()
            {
                {week,log},
            };
        }

        //---------------------------------------------------------------------
        // Adds study time to a specified day
        // day:     date that the hours will be added to
        // newTime: time that will be added to the date
        // v1: Created the method - Andrew V, 3-7-22
        // v2: Modified for new log structure - Andrew V, 3-7-22
        //---------------------------------------------------------------------
        public void AddTimeToLog(double newTime, int day)
        {
            if(log.ContainsKey(day))
            {
                log[day] = newTime + log[day];
            }
            else
            {
                log.Add(day, newTime);
            }
        }

        //---------------------------------------------------------------------
        // returns study hours for that date
        // day: date of hours being returned
        // v1: Created the method - Andrew V, 3-7-22
        //---------------------------------------------------------------------
        public double GetHours(int day)
         {
            if(log.ContainsKey(day))
            {
                return log[day];
            }
            else
            {
                return 0.0;
            }
         }
         
    }
}
