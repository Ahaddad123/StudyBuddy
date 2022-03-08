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

        //---------------------------------------------------------------------
        // default constructor for studylog
        // v1: Created the method - Andrew V, 3-7-22
        //---------------------------------------------------------------------
        public StudyLog()
        {
            log = new Dictionary<int , double>();
        }

        //---------------------------------------------------------------------
        // constructor for studylog
        // v1: Created the method - Andrew V, 3-7-22
        //---------------------------------------------------------------------
        public StudyLog(int day, double hours)
        {
            log = new Dictionary<int, double>()
            {
                {day, hours},
            };
        }

        //---------------------------------------------------------------------
        // Adds study time to a specified day
        // day:     date that the hours will be added to
        // newTime: time that will be added to the date
        // v1: Created the method - Andrew V, 3-7-22
        //---------------------------------------------------------------------
        public void AddTimeToLog(double newTime, int day)
        {
            if(log[day] != 0)
            {
                newTime = newTime + log[day];
            }
            log.Add(day, newTime);
        }

        //---------------------------------------------------------------------
        // returns study hours for that date
        // day: date of hours being returned
        // v1: Created the method - Andrew V, 3-7-22
        //---------------------------------------------------------------------
        public double GetHours(int day)
         {
            return log[day];
         }
         
    }
}
