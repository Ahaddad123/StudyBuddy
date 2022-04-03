using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.BusinessLogic;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void AddGradeTest_positive()
        {
            //Assignment assignment = new Assignment(100, "Exam 1", 20);
            //assignment.addGrade(50);
            //Assert.AreEqual(50, assignment.grade);
        }

        [TestMethod]
        public void AddGradeTest_negative()
        {
            //Assignment assignment = new Assignment(100, "Exam 1", 20);
            //assignment.addGrade(-5);
            //Assert.AreEqual(-5, assignment.grade);
        }

        [TestMethod]
        public void AddGradeTest_zero()
        {
            //Assignment assignment = new Assignment(100, "Exam 1", 20);
            //assignment.addGrade(0);
            //Assert.AreEqual(0, assignment.grade);
        }
    }
}
