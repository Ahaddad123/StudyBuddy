using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    public class CourseSchedule
    {
        public Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times { get; set; }
        public CourseSchedule(Dictionary<DayOfWeek, (String startTime, String endTime)> times )
        {
            if (times.ContainsKey(DayOfWeek.Sunday))
            { 
                String sundayStart = times[DayOfWeek.Sunday].startTime;
                String sundayEnd = times[DayOfWeek.Sunday].endTime;
            }

            if (times.ContainsKey(DayOfWeek.Monday))
            {
                String mondayStart = times[DayOfWeek.Monday].startTime;
                String mondayEnd = times[DayOfWeek.Monday].endTime;
            }

            if (times.ContainsKey(DayOfWeek.Tuesday))
            {
                String tuesdayStart = times[DayOfWeek.Tuesday].startTime;
                String tuesdayEnd = times[DayOfWeek.Tuesday].endTime;
            }

            if (times.ContainsKey(DayOfWeek.Wednesday))
            {
                String wednesdayStart = times[DayOfWeek.Wednesday].startTime;
                String wednesdayEnd = times[DayOfWeek.Wednesday].endTime;
            }

            if (times.ContainsKey(DayOfWeek.Thursday))
            {
                String thursdayStart = times[DayOfWeek.Thursday].startTime;
                String thursdayEnd = times[DayOfWeek.Thursday].endTime;
            }

            if (times.ContainsKey(DayOfWeek.Friday))
            {
                String fridayStart = times[DayOfWeek.Friday].startTime;
                String fridayEnd = times[DayOfWeek.Friday].endTime;
            }

            if (times.ContainsKey(DayOfWeek.Saturday))
            {
                String saturdayStart = times[DayOfWeek.Saturday].startTime;
                String saturdayEnd = times[DayOfWeek.Saturday].endTime;
            }
        }
    }
}
