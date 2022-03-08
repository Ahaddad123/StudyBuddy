using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.DataAccess;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void BuilderTest()
        {
            CourseBuilder courseBuilder = new CourseBuilder();
            Course course = courseBuilder.
                WithName("Intermediate Software Engineering").
                WithGrade(93.31).
                WithCode("SE 3330").
                WithPriority(1.0).
                WithCredits(3.0).
                Build();

            Assert.IsNotNull(course);
            Assert.AreEqual(course.name, "Intermediate Software Engineering");
            Assert.AreEqual(course.grade, 93.31);
            Assert.AreEqual(course.code, "SE 3330");
            Assert.AreEqual(course.priority, 1.0);
            Assert.AreEqual(course.credits, 3.0);
        }

        [TestMethod]
        public void AddAssignmentTest()
        {
            Course course = new Course();
            course.AddAssignment("testAssignment", 100, 30);

            Assert.IsTrue(course.RemoveAssignment("testAssignment"));
        }

        [TestMethod]
        public void RemoveAssignmentTest()
        {
            Course course = new Course();
            course.AddAssignment("testAssignment", 100, 30);
            course.RemoveAssignment("testAssignment");

            Assert.IsFalse(course.RemoveAssignment("testAssignment"));
        }

        [TestMethod]
        public void GradeAssignmentTest()
        {
            Course course = new Course();
            course.AddAssignment("testAssignment", 100, 100);

            course.GradeAssignment("testAssignment", 70);

            Assert.AreEqual(70.0, course.CalculateGrade());
        }

        [TestMethod]
        public void CalculateGradeTest_Empty()
        {
            Course course = new Course();
            Assert.AreEqual(100.0, course.CalculateGrade());
        }

        [TestMethod]
        public void CalculateGradeTest_Negative()
        {
            Course course = new Course();
            course.AddAssignment("testAssignment1", 100, 50);
            course.AddAssignment("testAssignment2", 100, 50);

            course.GradeAssignment("testAssignment1", -10);
            course.GradeAssignment("testAssignment2", -28);

            Assert.IsTrue(Math.Abs(-19.0 - course.CalculateGrade()) < 0.00000000000001);
        }

        [TestMethod]
        public void CalculateGradeTest_Zero()
        {
            Course course = new Course();
            course.AddAssignment("testAssignment1", 100, 50);
            course.AddAssignment("testAssignment2", 100, 50);

            course.GradeAssignment("testAssignment1", 10);
            course.GradeAssignment("testAssignment2", -10);

            Assert.AreEqual(0, course.CalculateGrade());
        }

        [TestMethod]
        public void CalculateGradeTest_Positive()
        {
            Course course = new Course();
            course.AddAssignment("testAssignment1", 100, 50);
            course.AddAssignment("testAssignment2", 100, 50);

            course.GradeAssignment("testAssignment1", 20);
            course.GradeAssignment("testAssignment2", 28);

            Assert.IsTrue(Math.Abs(24.0 - course.CalculateGrade()) < 0.00000000000001);
        }

        [TestMethod]
        public void CalculateGradeTest_Over100()
        {
            Course course = new Course();
            course.AddAssignment("testAssignment1", 100, 50);
            course.AddAssignment("testAssignment2", 100, 50);

            course.GradeAssignment("testAssignment1", 100);
            course.GradeAssignment("testAssignment2", 230);

            Assert.IsTrue(Math.Abs(165.0 - course.CalculateGrade()) < 0.00000000000001);
        }

        [TestMethod]
        public void LogHoursTest_Negative()
        {
            Course course = new Course();
            course.LogHours(-3.5);

            int date = DateTime.Now.Year * 10000 + DateTime.Now.Month * 100 + DateTime.Now.Day;

            Assert.AreEqual(0.0, course.GetHoursStudied(date));
        }

        [TestMethod]
        public void LogHoursTest_Zero()
        {
            Course course = new Course();
            course.LogHours(0.0);

            int date = DateTime.Now.Year * 10000 + DateTime.Now.Month * 100 + DateTime.Now.Day;

            Assert.AreEqual(0.0, course.GetHoursStudied(date));
        }

        [TestMethod]
        public void LogHoursTest_Positive()
        {
            Course course = new Course();
            course.LogHours(4.2);

            int date = DateTime.Now.Year * 10000 + DateTime.Now.Month * 100 + DateTime.Now.Day;

            Assert.AreEqual(4.2, course.GetHoursStudied(date));
        }

        [TestMethod]
        public void GetHoursStudiedTest()
        {
            Course course = new Course();
            course.LogHours(4.2);
            course.LogHours(5.1);

            int date = DateTime.Now.Year * 10000 + DateTime.Now.Month * 100 + DateTime.Now.Day;

            Assert.AreEqual(9.3, course.GetHoursStudied(date));
        }
    }
}
