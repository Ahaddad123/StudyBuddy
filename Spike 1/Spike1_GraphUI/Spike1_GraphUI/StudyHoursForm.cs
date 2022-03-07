using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Spike1_GraphUI
{
    public partial class StudyHoursForm : Form
    {
        const int DAYS_IN_WEEK = 7;
        private GraphController graphController;
        private string[] daysOfWeek;
        private int[] hours;

        public StudyHoursForm()
        {
            InitializeComponent();
            daysOfWeek = new string[DAYS_IN_WEEK];
            hours = new int[DAYS_IN_WEEK];

            this.MaximumSize = new System.Drawing.Size(1366, 780);
            this.Size = new System.Drawing.Size(1366, 780);
            this.studdyBuddyNav11.MinimumSize = new System.Drawing.Size(245, 780);
            this.studdyBuddyNav11.MaximumSize = new System.Drawing.Size(245, 780);
            chart1.Titles.Add("Hours Studied");
           

            graphController = new GraphController();
            graphController.setGraphData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //testData();
            //fillChartDefault();
        }
        private void graphDataBtn_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            //Set default values in GraphData
            int weekId = this.WeekComboBox.SelectedIndex;
            Dictionary<DayOfWeek, int> studyHoursPerDay = graphController.getDataByWeek(weekId);

            int intID = WeekComboBox.SelectedIndex;
            for (int i = 0; i < DAYS_IN_WEEK; i++)
            {
                //Iterate through days of week 0 - 6
                DayOfWeek dayOfWeek = (DayOfWeek)i;
                //Store day of week in days of week
                this.daysOfWeek[i] = dayOfWeek.ToString();
                //Store hours according to day of week
                this.hours[i] = studyHoursPerDay[dayOfWeek];
            }

            //Edit labels
            string seriesID = "Week " + weekId;
            chart1.Series.Add(seriesID);
            chart1.Series[seriesID].AxisLabel = "Week" + weekId;

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                chart1.Series[seriesID].Points.AddXY(daysOfWeek[i], hours[i]);
            }
        }
    }
}
