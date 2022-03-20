using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.DataAccess;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class StudyLogTests
    {
        [TestMethod]
        public void GetHours_Zero()
        {
            StudyLog testLog = new StudyLog();
            Assert.AreEqual(0, testLog.GetHours(1));
        }

        [TestMethod]
        public void GetHours_nonZero()
        {
            //StudyLog testLog = new StudyLog(1,3);
            //Assert.AreEqual(3, testLog.GetHours(1));
        }

        [TestMethod]
        public void AddHours_Zero()
        {
            StudyLog testLog = new StudyLog();
            testLog.AddTimeToLog(2.5, 1);
            Assert.AreEqual(2.5, testLog.GetHours(1));
        }

        [TestMethod]
        public void AddHours_GreaterThenZero()
        {
            StudyLog testLog = new StudyLog();
            testLog.AddTimeToLog(0.3, 1);
            testLog.AddTimeToLog(0.3, 1);
            Assert.AreEqual(0.6, testLog.GetHours(1));
        }

        [TestMethod]
        public void AddHourse_MultipleDays()
        {
            StudyLog testLog = new StudyLog();
            testLog.AddTimeToLog(0.3, 1);
            testLog.AddTimeToLog(0.3, 2);
            Assert.AreEqual(0.3, testLog.GetHours(1));
            Assert.AreEqual(0.3, testLog.GetHours(2));
        }
    }
}
