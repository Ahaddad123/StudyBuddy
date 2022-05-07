using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Study_Buddy.BusinessLogic;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class StudyLogTests
    {
        [TestMethod]
        public void TestGetHours_Zero()
        {
            StudyLog testLog = new StudyLog();
            Assert.AreEqual(0, testLog.GetHours(DateTime.Today));
        }

        [TestMethod]
        public void TestGetHours_nonZero()
        {
            StudyLog testLog = new StudyLog(DateTime.Today, 1);
            Assert.AreEqual(1, testLog.GetHours(DateTime.Today));
        }

        [TestMethod]
        public void TestAddHours_Zero()
        {
            StudyLog testLog = new StudyLog();
            testLog.AddTimeToLog(2.5, DateTime.Today);
            Assert.AreEqual(2.5, testLog.GetHours(DateTime.Today));
        }

        [TestMethod]
        public void TestAddHours_GreaterThenZero()
        {
            StudyLog testLog = new StudyLog();
            testLog.AddTimeToLog(0.3, DateTime.Today);
            testLog.AddTimeToLog(0.3, DateTime.Today);
            Assert.AreEqual(0.6, testLog.GetHours(DateTime.Today));
        }

        [TestMethod]
        public void TestAddHourse_MultipleDays()
        {
            StudyLog testLog = new StudyLog();
            DateTime today = DateTime.Today;
            DateTime yesterday = new DateTime(today.Year, today.Month, today.Day - 1);
            testLog.AddTimeToLog(0.3, today);
            testLog.AddTimeToLog(0.3, yesterday);
            Assert.AreEqual(0.3, testLog.GetHours(today));
            Assert.AreEqual(0.3, testLog.GetHours(yesterday));
        }
    }
}
