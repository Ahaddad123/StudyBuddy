using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;
using System.Globalization;

namespace Study_Buddy.Presentation.Model
{

    //---------------------------------------------------------------------
    // This class is the model for a graph of study hours in a week for
    // a given course.  Currently only graphs default values as the backend
    // is not yet implemented.
    // v1: Created the class - Peter H, 3-7-22
    //---------------------------------------------------------------------
    internal class StudyLogGraph
    {

        //---------------------------------------------------------------------
        // Private data members
        // DAYS_IN_WEEK : the number of days in a week
        // studyLog : The studyLog which is being modeled
        // weeks : A dictionary with a int key corresponding to the weekID
        // and a value that is a dictionary representing the day of the week
        // (key) and hours studied in a day (value).
        // hours : a list of hours to be graphed
        // daysOfWeek : a list of Days of the week to be graphed, represented
        // as a string
        //---------------------------------------------------------------------
        private const int DAYS_IN_WEEK = 7;
        private StudyLog studyLog;
        private Dictionary<int, Dictionary<DayOfWeek, int>> weeks;
        private List<int> hours;
        private List<string> daysOfWeek;


        //---------------------------------------------------------------------
        // Parameterized constructor.  Initializes members and sets default 
        // week to week 0.
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public StudyLogGraph(StudyLog studyLog)
        {
            weeks = new Dictionary<int, Dictionary<DayOfWeek, int>>();
            this.studyLog = studyLog;
            hours = new List<int>();
            daysOfWeek = new List<string>();
            //GenerateTestData();
            GatherRealData();
            DateTime currWeek = DateTime.Now;
            int weekID = currWeek.DayOfYear / DAYS_IN_WEEK;
            //System.Globalization.Calendar.GetWeekOfYear(currWeek, CalendarWeekRule.);
            
            SelectWeek(weekID);
        }

        //---------------------------------------------------------------------
        // Return the value of weeks at the specified weekID 
        // weekID : the specified week for which study data corresponds to
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        private Dictionary<DayOfWeek, int> getDataByWeek(int weekID)
        {
            return weeks[weekID];
        }


        //---------------------------------------------------------------------
        // Returns the number of weeks for which data is logged
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public int GetNumWeeks()
        {
            return weeks.Count;
        }

        //---------------------------------------------------------------------
        // Copies data for a given week from the overall dictionary, weeks,
        // into the lists, hours and days of week for easier and
        // better formatted access.
        // weekID : the specified week for which study data corresponds to
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        // Returns the days of weeks to be displayed as X values on a chart
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public List<string> GetXValues()
        {
            return daysOfWeek;
        }

        //---------------------------------------------------------------------
        // Returns the hours studied to be displayed as Y values on a chart
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public List<int> GetYValues()
        {
            return hours;
        }

        //---------------------------------------------------------------------
        // Generates default study hours data to fill in 2 weeks of data.
        // This method exists primarily for demonstration purposes and will be 
        // eliminated once the backend is fully implemented, so that we may 
        // graph actual data.
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        // Gathers the data from the study log of the selected course.
        // The date coloected is the hours studied on each day from the start
        // of the year untill the current date
        // v1: Created the method - Andrew V, 4-24-22
        //---------------------------------------------------------------------
        public void GatherRealData()
        {
            DateTime currDate = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime endDate = DateTime.Now;
            int curWeek = 0;

            while(currDate < endDate)
            {
                Dictionary<DayOfWeek, int> daysAndHoursStudied = new Dictionary<DayOfWeek, int>();

                //For every day in week, add hours studied
                for (int j = 0; j < 7; j++)
                {
                    int hours = (int)studyLog.GetHours(currDate);
                    daysAndHoursStudied.Add(currDate.DayOfWeek, hours);
                    //Increment date by 1
                    currDate = currDate.AddDays(1);
                }
                //Add new entry into weeks
                weeks.Add(curWeek, daysAndHoursStudied);

                //Increment weekID
                curWeek++;
            }
        }
    }
}
