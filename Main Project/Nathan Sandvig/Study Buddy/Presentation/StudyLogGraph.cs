using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    internal class StudyLogGraph
    {
        const int DAYS_IN_WEEK = 7;
        private DataAccess.StudyLog studyLog;
        private Dictionary<int, Dictionary<DayOfWeek, int>> weeks;

        private List<int> hours;
        private List<string> daysOfWeek;


        public StudyLogGraph(DataAccess.StudyLog studyLog)
        {
            weeks = new Dictionary<int, Dictionary<DayOfWeek, int>>();
            this.studyLog = studyLog;
            hours = new List<int>();
            daysOfWeek = new List<string>();
            GenerateTestData();
            SelectWeek(0);
        }

        //Return the value of weeks at the specified weekID
        private Dictionary<DayOfWeek, int> getDataByWeek(int weekID)
        {
            return weeks[weekID];
        }

        public int GetNumWeeks()
        {
            return weeks.Count;
        }

        public void SelectWeek(int weekID)
        {
            if (weekID < weeks.Count && weekID >= 0)
            {
                //Remove old data from lists
                daysOfWeek.Clear();
                hours.Clear();
                Dictionary<DayOfWeek, int> studyHoursPerDay = getDataByWeek(weekID);
                for (int i = 0; i < DAYS_IN_WEEK; i++)
                {
                    //Iterate through days of week 0 - 6
                    DayOfWeek dayOfWeek = (DayOfWeek)i;
                    //Store day of week in days of week
                    this.daysOfWeek.Add(dayOfWeek.ToString());
                    //Store hours according to day of week
                    this.hours.Add(studyHoursPerDay[dayOfWeek]);
                }
            }
        }

        public List<string> GetXValues()
        {
            return daysOfWeek;   
        }

        public List<int> GetYValues()
        {
            return hours;
        }

        public void GenerateTestData()
        {
            Random random = new Random();

            //Default numWeeks to 2
            int numWeeks = 2;

            //Set first entry to 2 weeks ago
            DateTime dateTime = DateTime.Now.AddDays(-14);
            int weekID = 0;

            for (int i = 0; i < numWeeks; i++)
            {
                //Creat dictionary holding hours studied in a week
                Dictionary<DayOfWeek, int> daysAndHoursStudied = new Dictionary<DayOfWeek, int>();

                //For every day in week, add hours studied
                for (int j = 0; j < 7; j++)
                {
                    int hours = random.Next(1, 6);
                    daysAndHoursStudied.Add(dateTime.DayOfWeek, hours);
                    //Increment date by 1
                    dateTime = dateTime.AddDays(1);
                }
                //Add new entry into weeks
                weeks.Add(weekID, daysAndHoursStudied);

                //Increment weekID
                weekID++;
            }
        }
    }
}
