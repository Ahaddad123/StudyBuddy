using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spike1_GraphUI
{
    internal class GraphController
    {
        private GraphData graphData;
        private GraphData GraphData
        {
            get { return graphData; }
            set { graphData = value; }
        }

        public GraphController()
        {
            graphData = new GraphData();
        }

        //Return the value of weeks at the specified weekID
        public Dictionary<DayOfWeek, int> getDataByWeek(int weekID)
        {
            return graphData.getDataByWeek(weekID);
        }

        public void setGraphData()
        {
            graphData.insertTestData();
        }

        public void drawGraph()
        {

        }

    }
}
