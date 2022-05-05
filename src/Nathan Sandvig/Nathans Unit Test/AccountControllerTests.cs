using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class AccountControllerTests
    {
        [TestMethod]
        public void TestScheduleCheck_FALSE()
        {
            AccountController.account = new Account();
            AccountController.account.database = new MockDatabase();
            Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> course1Times = new Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)>();
            course1Times.Add(DayOfWeek.Monday, (new DateTime(1, 1, 1, 8, 0, 0), new DateTime(1, 1, 1, 11, 0, 0)));
            Course course = new CourseBuilder().WithName("course1").WithSchedule(new CourseSchedule(course1Times)).Build();
            AccountController.account.courses.Add(course);
            Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times = new Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)>();
            times.Add(DayOfWeek.Monday, (new DateTime(1, 1, 1, 8, 0, 0), new DateTime(1, 1, 1, 11, 0, 0)));
            CourseSchedule courseSchedule = new CourseSchedule(times);
            Assert.IsFalse(AccountController.scheduleCheck(courseSchedule, "notCourse1"));
        }

        [TestMethod]
        public void TestScheduleCheck_TRUE()
        {
            AccountController.account = new Account();
            AccountController.account.database = new MockDatabase();
            Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> course1Times = new Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)>();
            course1Times.Add(DayOfWeek.Monday, (new DateTime(1, 1, 1, 8, 0, 0), new DateTime(1, 1, 1, 11, 0, 0)));
            Course course = new CourseBuilder().WithName("course1").WithSchedule(new CourseSchedule(course1Times)).Build();
            AccountController.account.courses.Add(course);
            Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times = new Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)>();
            times.Add(DayOfWeek.Monday, (new DateTime(1, 1, 1, 11, 0, 0), new DateTime(1, 1, 1, 12, 0, 0)));
            CourseSchedule courseSchedule = new CourseSchedule(times);
            Assert.IsTrue(AccountController.scheduleCheck(courseSchedule, "notCourse1"));
        }
    }
}
