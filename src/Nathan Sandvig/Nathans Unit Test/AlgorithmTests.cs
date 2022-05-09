using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.BusinessLogic;
using System.Collections.Generic;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void PrivateMemberInitializationTest()
        {
            Algorithm.Reset();
            CourseBuilder courseBuilder = new CourseBuilder();
            Course course = courseBuilder.Build();
            double grade = Algorithm.HoursForGrade(course, 90.0);
            Assert.AreEqual(6.0, grade);
        }

        [TestMethod]
        public void ImportCourseDataTest()
        {
            Algorithm.Reset();
            CourseBuilder courseBuilder = new CourseBuilder();
            Course course = courseBuilder.WithName("test course").Build();
            Assignment assignment = new Assignment(100, "test assignment", 20, DateTime.Now.AddDays(5));
            assignment.addGrade(100);
            course.AddAssignment(assignment);
            assignment = new Assignment(100, "test assignment", 20, DateTime.Now.AddDays(10));
            assignment.addGrade(80);
            course.AddAssignment(assignment);
            course.LogHours(4, DateTime.Now.AddDays(4));
            course.LogHours(3, DateTime.Now.AddDays(6));
            double grade = Algorithm.HoursForGrade(course, 90.0);
            Assert.AreEqual(2.0, grade);
        }
    }
}
