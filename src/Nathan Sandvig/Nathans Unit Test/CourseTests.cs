using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.BusinessLogic;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void TestBuilder()
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
        public void TestAddAssignment_DoesNotExist()
        {
            Course course = new Course();
            Assignment assignment = new Assignment(100, "testAssignment", 30, DateTime.Today);
            course.AddAssignment(assignment);

            Assert.IsTrue(course.assignments.Contains(assignment));
            Assert.AreEqual(1, course.assignments.Count);
        }

        [TestMethod]
        public void TestAddAssignment_Exists()
        {
            Course course = new Course();
            Assignment assignment = new Assignment(100, "testAssignment", 30, DateTime.Today);
            course.AddAssignment(assignment);
            course.AddAssignment(assignment);

            Assert.IsTrue(course.assignments.Contains(assignment));
            Assert.AreEqual(1, course.assignments.Count);
        }

        [TestMethod]
        public void TestRemoveAssignment()
        {
            Course course = new Course();
            course.AddAssignment(new Assignment(100, "testAssignment", 30, DateTime.Today));
            course.RemoveAssignment("testAssignment");

            Assert.IsFalse(course.RemoveAssignment("testAssignment"));
        }

        [TestMethod]
        public void TestGradeAssignment()
        {
            Course course = new Course();
            course.AddAssignment(new Assignment(100, "testAssignment", 100, DateTime.Today));

            course.GradeAssignment("testAssignment", 70);

            Assert.AreEqual(70.0, course.CalculateGrade());
        }

        [TestMethod]
        public void TestCalculateGrade_Empty()
        {
            Course course = new Course();
            Assert.AreEqual(100.0, course.CalculateGrade());
        }

        [TestMethod]
        public void TestCalculateGrade_Negative()
        {
            Course course = new Course();
            course.AddAssignment(new Assignment(100, "testAssignment1", 50, DateTime.Today));
            course.AddAssignment(new Assignment(100, "testAssignment2", 50, DateTime.Today));

            course.GradeAssignment("testAssignment1", -10);
            course.GradeAssignment("testAssignment2", -28);

            Assert.IsTrue(Math.Abs(-19.0 - course.CalculateGrade()) < 0.00000000000001);
        }

        [TestMethod]
        public void TestCalculateGrade_Zero()
        {
            Course course = new Course();
            course.AddAssignment(new Assignment(100, "testAssignment1", 50, DateTime.Today));
            course.AddAssignment(new Assignment(100, "testAssignment2", 50, DateTime.Today));

            course.GradeAssignment("testAssignment1", 10);
            course.GradeAssignment("testAssignment2", -10);

            Assert.AreEqual(0, course.CalculateGrade());
        }

        [TestMethod]
        public void TestCalculateGrade_Positive()
        {
            Course course = new Course();
            course.AddAssignment(new Assignment(100, "testAssignment1", 50, DateTime.Today));
            course.AddAssignment(new Assignment(100, "testAssignment2", 50, DateTime.Today));

            course.GradeAssignment("testAssignment1", 20);
            course.GradeAssignment("testAssignment2", 28);

            Assert.IsTrue(Math.Abs(24.0 - course.CalculateGrade()) < 0.00000000000001);
        }

        [TestMethod]
        public void TestCalculateGrade_Over100()
        {
            Course course = new Course();
            course.AddAssignment(new Assignment(100, "testAssignment1", 50, DateTime.Today));
            course.AddAssignment(new Assignment(100, "testAssignment2", 50, DateTime.Today));

            course.GradeAssignment("testAssignment1", 100);
            course.GradeAssignment("testAssignment2", 230);

            Assert.IsTrue(Math.Abs(165.0 - course.CalculateGrade()) < 0.00000000000001);
        }

        [TestMethod]
        public void TestLogHours_Negative()
        {
            Course course = new Course();
            course.LogHours(-3.5, DateTime.Today);

            Assert.AreEqual(0.0, course.GetHoursStudied(DateTime.Today));
        }

        [TestMethod]
        public void TestLogHours_Zero()
        {
            Course course = new Course();
            course.LogHours(0.0, DateTime.Today);

            Assert.AreEqual(0.0, course.GetHoursStudied(DateTime.Today));
        }

        [TestMethod]
        public void TestLogHours_Positive()
        {
            Course course = new Course();
            course.LogHours(4.2, DateTime.Today);

            Assert.AreEqual(4.2, course.GetHoursStudied(DateTime.Today));
        }

        [TestMethod]
        public void TestGetHoursStudied_Empty()
        {
            Course course = new Course();

            Assert.AreEqual(0.0, course.GetHoursStudied(DateTime.Today));
        }

        [TestMethod]
        public void TestGetHoursStudied_Filled()
        {
            Course course = new Course();
            course.LogHours(4.2, DateTime.Today);
            course.LogHours(5.1, DateTime.Today);

            Assert.AreEqual(9.3, course.GetHoursStudied(DateTime.Today));
        }

        [TestMethod]
        public void TestRemoveHours_Valid()
        {
            int addHours = 3;
            int removeHours = 2;
            Course course = new Course();
            course.LogHours(addHours, DateTime.Today);

            course.RemoveHours(removeHours, DateTime.Today);

            Assert.AreEqual(addHours - removeHours, course.GetHoursStudied(DateTime.Today));
        }

        [TestMethod]
        public void TestRemoveHours_Invalid()
        {
            int addHours = 3;
            int removeHours = -1;
            Course course = new Course();
            course.LogHours(addHours, DateTime.Today);

            course.RemoveHours(removeHours, DateTime.Today);

            Assert.AreEqual(addHours, course.GetHoursStudied(DateTime.Today));
        }

        [TestMethod]
        public void TestDatesAndAverageGrades()
        {
            Course course = new Course();
            course.datesAndAverageGrades = new Dictionary<DateTime, double>();
        }
    }
}
