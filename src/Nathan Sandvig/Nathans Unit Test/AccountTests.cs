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

        /*[TestMethod]
        public void testPopulateCourseList()
        {
            Account account = new Account("username", "password");
            account.database = new MockDatabase();
            List<String> courseList = new List<String>();
            for(int i = 0; i < 5; i++)
            {
                courseList.Add("courseName" + i);
                courseList.Add(3.ToString());
                courseList.Add(i.ToString());
            }

        }*/
    }

}
