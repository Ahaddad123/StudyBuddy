using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.BusinessLogic;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void TestAddGrade_positive()
        {
            Assignment assignment = new Assignment(100, "Exam 1", 20, DateTime.Today);
            assignment.addGrade(50);
            Assert.AreEqual(50, assignment.grade);
        }

        [TestMethod]
        public void TestAddGrade_negative()
        {
            Assignment assignment = new Assignment(100, "Exam 1", 20, DateTime.Today);
            assignment.addGrade(-5);
            Assert.AreEqual(-5, assignment.grade);
        }

        [TestMethod]
        public void TestAddGrade_zero()
        {
            Assignment assignment = new Assignment(100, "Exam 1", 20, DateTime.Today);
            assignment.addGrade(0);
            Assert.AreEqual(0, assignment.grade);
        }

        [TestMethod]
        public void TestGetDueDate()
        {
            Assignment assignment = new Assignment(100, "Exam 1", 20, new DateTime(1,1,1));
            assignment.dueDate = DateTime.Today;
            Assert.AreEqual(DateTime.Today, assignment.dueDate);
        }
    }
}
