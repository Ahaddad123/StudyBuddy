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
        public Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times{ get; set;}

        public CourseSchedule(Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times)
        {
            this.times = times;
        }

<<<<<<< HEAD
        public void addCourseTime(string courseName) {
            addCourseTimes.addTheCourseTimes(times, courseName);
=======
        public void addCourseTime() 
        {
            addCourseTimes.addTheCourseTimes(times);
>>>>>>> 7575c0595ba6fc993a2766f4dec3ebc370afdf07
        }

        public double getCourseHours(DayOfWeek date)
        {
            return (times[date].endTime - times[date].startTime).TotalHours;
        }
    }
}
