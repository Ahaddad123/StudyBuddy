using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spike1_GraphUI
{
    internal class GraphData
    {
        //weeks holds int keys representing the week and dictionary values representing the date(key) and hours studied on that day (value).
        private Dictionary<int, Dictionary<DayOfWeek, int>> weeks;
        private Dictionary<int, Dictionary<DayOfWeek, int>> Weeks
        {
            get
            {
                return weeks;
            }
            set
            {
                weeks = value;
            }
        }

        public GraphData()
        {
            this.weeks = new Dictionary<int, Dictionary<DayOfWeek, int>>();
        }

        public void insertTestData()
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
                Dictionary<DayOfWeek, int> hoursStudied = new Dictionary<DayOfWeek, int>();

                //For every day in week, add hours studied
                for (int j = 0; j < 7; j++)
                {
                    int hours = random.Next(1, 6);
                    hoursStudied.Add(dateTime.DayOfWeek, hours);
                    //Increment date by 1
                    dateTime = dateTime.AddDays(1);
                }
                //Add new entry into weeks
                weeks.Add(weekID, hoursStudied);

                //Increment weekID
                weekID++;
            }
        }

        //Return the value of weeks at the specified weekID
        public Dictionary<DayOfWeek, int> getDataByWeek(int weekID)
        {
            return weeks[weekID];
        }

        /*private Dictionary<DateTime, int> hoursStudied;
        public Dictionary<DateTime, int> HoursStudied
        {
            get
            {
                return hoursStudied;
            }
        }*/

    }
}
