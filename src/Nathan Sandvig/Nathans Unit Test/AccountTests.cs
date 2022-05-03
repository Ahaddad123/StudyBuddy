﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.BusinessLogic;
using System.Collections.Generic;


namespace Nathans_Unit_Test
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void CheckCreateAccount()
        {
            Account account = new Account("josh123", "joshpassword");
            //account.CheckCreateAccount("josh123", "joshpassword");
            //Assert.AreEqual(false, account.CheckCreateAccount("josh123", "joshpassword"));

        }
        [TestMethod]
        public void CheckLogin() {
            Account account = new Account("josh123", "joshpassword");
            //account.Login("nathan123", "nathanpassword");
            //Assert.AreEqual(false, account.Login("nathan123", "nathanpassword"));
        }
        [TestMethod]
        public void AddCourseTest()
        {
            Account account = new Account("username", "password");
            Course course = new Course();
            List<Course> testList = new List<Course>();

            account.populateCourses(course);
            testList.Add(course);

            Assert.AreEqual(1, account.courses.Count);
            Assert.AreEqual(testList[0], account.courses[0]);
        }

        [TestMethod]
        public void RemoveCourseTest_NotExists()
        {
            Account account = new Account("username", "password");
            CourseBuilder courseBuilder = new CourseBuilder();
            Course course1 = courseBuilder.WithName("test1").Build();
            Course course2 = courseBuilder.WithName("test2").Build();

            account.populateCourses(course1);
            account.populateCourses(course2);

            Assert.IsFalse(account.removeCourse("test3"));
            Assert.AreEqual(2, account.courses.Count);
        }
        [TestMethod]
        public void RemoveCourseTest_Exists()
        {
            Account account = new Account("username", "password");
            account.database = new MockDatabase();
            CourseBuilder courseBuilder = new CourseBuilder();
            Course course1 = courseBuilder.WithName("test1").Build();
            Course course2 = courseBuilder.WithName("test2").Build();
            List<Course> testList = new List<Course>();

            account.populateCourses(course1);
            account.populateCourses(course2);
            testList.Add(course1);

            Assert.IsTrue(account.removeCourse("test2"));
            Assert.AreEqual(1, account.courses.Count);
            Assert.AreEqual(testList[0], account.courses[0]);
        }
    }

}