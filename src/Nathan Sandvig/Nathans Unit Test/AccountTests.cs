using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.BusinessLogic;
using System.Collections.Generic;


namespace Nathans_Unit_Test
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void testAddCourse_NotExists()
        {
            Account account = new Account("username", "password", "first", "last","3.7","UWP");
            account.database = new MockDatabase();
            Course course = new Course();
            List<Course> testList = new List<Course>();

            account.addCourse(course);
            testList.Add(course);

            Assert.AreEqual(1, account.courses.Count);
            Assert.AreEqual(testList[0], account.courses[0]);
        }

        [TestMethod]
        public void testAddCourse_Exists()
        {
            Account account = new Account("username", "password", "first", "last", "3.7", "UWP");
            account.database = new MockDatabase();
            Course course = new CourseBuilder().WithName("course").Build();
            Course course2 = new CourseBuilder().WithName("course").Build();
            List<Course> testList = new List<Course>();

            account.addCourse(course);
            account.addCourse(course2);
            testList.Add(course);
            testList.Add(course2);

            Assert.AreEqual(1, account.courses.Count);
            Assert.AreEqual(testList[0], account.courses[0]);
        }

        [TestMethod]
        public void testRemoveCourse_NotExists()
        {
            Account account = new Account("username", "password");
            account.database = new MockDatabase();
            CourseBuilder courseBuilder = new CourseBuilder();
            Course course1 = courseBuilder.WithName("test1").Build();
            Course course2 = courseBuilder.WithName("test2").Build();

            account.addCourse(course1);
            account.addCourse(course2);

            Assert.IsFalse(account.removeCourse("test3"));
            Assert.AreEqual(2, account.courses.Count);
        }

        [TestMethod]
        public void testRemoveCourse_Exists()
        {
            Account account = new Account("username", "password");
            account.database = new MockDatabase();
            CourseBuilder courseBuilder = new CourseBuilder();
            Course course1 = courseBuilder.WithName("test1").Build();
            Course course2 = courseBuilder.WithName("test2").Build();
            List<Course> testList = new List<Course>();

            account.addCourse(course1);
            account.addCourse(course2);
            testList.Add(course1);

            Assert.IsTrue(account.removeCourse("test2"));
            Assert.AreEqual(1, account.courses.Count);
            Assert.AreEqual(testList[0], account.courses[0]);
        }

        [TestMethod]
        public void testPopulateCourseList()
        {
            int numCourses = 5;
            Account account = new Account("username", "password");
            account.database = new MockDatabase();
            List<String> courseList = new List<String>();
            for(int i = 0; i < numCourses; i++)
            {
                courseList.Add("courseName" + i);
                courseList.Add(3.ToString());
                courseList.Add(i.ToString());
            }

            account.populateCourseList(courseList);

            Assert.AreEqual(numCourses, account.courses.Count);
        }

        [TestMethod]
        public void testPopulateStudyHours()
        {
            int numHours1 = 1;
            int numHours2 = 2;
            Account account = new Account("username", "password");
            account.database = new MockDatabase();
            CourseBuilder courseBuilder = new CourseBuilder();
            Course course1 = courseBuilder.WithName("test1").Build();
            Course course2 = courseBuilder.WithName("test2").Build();
            account.courses.Add(course1);
            account.courses.Add(course2);
            List<String> studyHoursList = new List<String>();
            studyHoursList.Add(numHours1.ToString());
            studyHoursList.Add(course1.name);
            studyHoursList.Add(DateTime.Today.ToString());
            studyHoursList.Add(numHours2.ToString());
            studyHoursList.Add(course2.name);
            studyHoursList.Add(DateTime.Today.ToString());

            account.populateStudyHours(studyHoursList);

            Assert.AreEqual(numHours1, account.getCourseByName(course1.name).GetHoursStudied(DateTime.Today));
            Assert.AreEqual(numHours2, account.getCourseByName(course2.name).GetHoursStudied(DateTime.Today));
        }

        [TestMethod]
        public void testPopulateSchedules()
        {
            int startTime1 = 8;
            int endTime1 = 9;
            int startTime2 = 1;
            int endTime2 = 4;
            Account account = new Account("username", "password");
            account.database = new MockDatabase();
            CourseBuilder courseBuilder = new CourseBuilder();
            Course course1 = courseBuilder.WithName("test1").Build();
            Course course2 = courseBuilder.WithName("test2").Build();
            account.courses.Add(course1);
            account.courses.Add(course2);
            List<String> schedulesList = new List<String>();
            schedulesList.Add(course1.name);
            for(int i = 0; i < 7; i++)
            {
                schedulesList.Add(new DateTime(1,1,1,startTime1,0,0).ToString());
                schedulesList.Add(new DateTime(1, 1, 1, endTime1, 0, 0).ToString());
            }
            schedulesList.Add(course2.name);
            for (int i = 0; i < 7; i++)
            {
                schedulesList.Add(new DateTime(1, 1, 1, startTime2, 0, 0).ToString());
                schedulesList.Add(new DateTime(1, 1, 1, endTime2, 0, 0).ToString());
            }

            account.populateSchedules(schedulesList);
            
            foreach(DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Assert.AreEqual(endTime1 - startTime1, account.getCourseByName(course1.name).schedule.getCourseHours(day));
                Assert.AreEqual(endTime2 - startTime2, account.getCourseByName(course2.name).schedule.getCourseHours(day));
                Assert.AreEqual(startTime1, account.getCourseByName(course1.name).schedule.times[day].startTime.Hour);
                Assert.AreEqual(endTime1, account.getCourseByName(course1.name).schedule.times[day].endTime.Hour);
                Assert.AreEqual(startTime2, account.getCourseByName(course2.name).schedule.times[day].startTime.Hour);
                Assert.AreEqual(endTime2, account.getCourseByName(course2.name).schedule.times[day].endTime.Hour);
            }  
        }

        [TestMethod]
        public void testPopulateStudentInfo()
        {
            Account account = new Account("username", "password");
            account.database = new MockDatabase();
            List<String> studentInfoList = new List<String>();
            studentInfoList.Add("firstName");
            studentInfoList.Add("lastName");
            studentInfoList.Add("3.7");
            studentInfoList.Add("schoolName");

            account.populateStudentInfo(studentInfoList);

            Assert.AreEqual("firstName", account.firstName);
            Assert.AreEqual("lastName", account.lastName);
            Assert.AreEqual("3.7", account.GPA1);
            Assert.AreEqual("schoolName", account.schoolName);
        }
    }

}
