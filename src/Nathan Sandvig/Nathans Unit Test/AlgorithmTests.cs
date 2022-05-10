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
            Assignment assignment = new Assignment(100, "test assignment1", 20, DateTime.Now.AddDays(10));
            assignment.addGrade(80);
            course.AddAssignment(assignment);
            Assignment assignment2 = new Assignment(100, "test assignment2", 20, DateTime.Now.AddDays(5));
            assignment2.addGrade(100);
            course.AddAssignment(assignment2);
            Assignment assignment3 = new Assignment(100, "test assignment3", 20, DateTime.Now.AddDays(15));
            assignment3.addGrade(90);
            course.AddAssignment(assignment3);
            course.LogHours(5, DateTime.Now.AddDays(4));
            course.LogHours(3, DateTime.Now.AddDays(6));
            course.LogHours(3.5, DateTime.Now.AddDays(12));
            double grade = Algorithm.HoursForGrade(course, 90.0);
            Assert.IsTrue(Math.Abs(grade - 4.7) < 0.01);
        }
    }
}
