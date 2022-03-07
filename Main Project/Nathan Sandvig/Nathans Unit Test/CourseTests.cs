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
    }
}
