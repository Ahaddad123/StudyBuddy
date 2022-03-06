using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spike1_GraphUI
{
    internal class GraphController
    {
        private Dictionary<DateTime, int> hoursStudied;
        public Dictionary<DateTime, int> HoursStudied
        {
            get
            {
                return hoursStudied;
            }
        }

        public void setHoursStudied(DateTime date, int hours)
        {
            hoursStudied.Add(date, hours);
        }

        public GraphController()
        {
            hoursStudied = new Dictionary<DateTime, int>();
        }

        public void drawGraph()
        {

        }

    }
}
