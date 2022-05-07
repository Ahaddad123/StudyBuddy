using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    //---------------------------------------------------------------------
    // Holds the days and hours in a week a course is held.
    //---------------------------------------------------------------------
    public class CourseSchedule
    {
        public Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times{ get; set;}

        //---------------------------------------------------------------------
        // Constructor of the CourseSchedule that initializes the map of times
        //---------------------------------------------------------------------
        public CourseSchedule(Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times)
        {
            this.times = times;
        }

        //---------------------------------------------------------------------
        // Default constructor of CourseSchedule
        //---------------------------------------------------------------------
        public CourseSchedule()
        {
            times = new Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)>();
        }

        //---------------------------------------------------------------------
        // Gets the duration of time a course is held for a specific day
        // date: day of the week to get the course duration for
        //---------------------------------------------------------------------
        public double getCourseHours(DayOfWeek date)
        {
            double hours = 0.0;
            if (times.ContainsKey(date))
                hours = (times[date].endTime - times[date].startTime).TotalHours;
            return hours;
        }
    }
}
