using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.DataAccess;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class StudyLogTests
    {
        [TestMethod]
        public void AddHours_Zero()
        {
            StudyLog testLog = new StudyLog(1,0);
            testLog.AddTimeToLog(2.5, 1);
            Assert.AreEqual(2.5, testLog.GetHours(1));
        }

        [TestMethod]
        public void AddHours_GreaterThenZero()
        {
            StudyLog testLog = new StudyLog(1,0);
            testLog.AddTimeToLog(0.3, 1);
            testLog.AddTimeToLog(0.3, 1);
            Assert.AreEqual(0.6, testLog.GetHours(1));
        }

        [TestMethod]
        public void AddHourse_MultipleDays()
        {
            StudyLog testLog = new StudyLog(1, 0);
            StudyLog testLog2 = new StudyLog(2, 0);
            testLog.AddTimeToLog(0.3, 2);
            testLog2.AddTimeToLog(0.3, 3);
            Assert.AreEqual(0.3, testLog.GetHours(2));
        }
    }
}
