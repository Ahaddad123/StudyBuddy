using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    public class CourseSchedule
    {
        Account addCourseTimes = new Account();
        public Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times
        { get; set;}

        public CourseSchedule(Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times)
        {
            this.times = times;
        }

        public void addCourseTime(string courseName) {
            addCourseTimes.addTheCourseTimes(times, courseName);
        }
    }
}
