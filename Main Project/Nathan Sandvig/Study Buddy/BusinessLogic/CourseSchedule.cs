using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    public class CourseSchedule
    {
        public Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times{ get; set;}

        public CourseSchedule(Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times)
        {
            this.times = times;
        }

        public CourseSchedule()
        {
            times = new Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)>();
        }

        public double getCourseHours(DayOfWeek date)
        {
            return (times[date].endTime - times[date].startTime).TotalHours;
        }
    }
}
