using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spike1_GraphUI
{
    public partial class StudyHoursForm : Form
    {
        private GraphController graphController;

        public StudyHoursForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 780);
            this.Size = new System.Drawing.Size(1366, 780);
            this.studdyBuddyNav11.MinimumSize = new System.Drawing.Size(245, 780);
            this.studdyBuddyNav11.MaximumSize = new System.Drawing.Size(245, 780);
            fillChartDefault();

            graphController = new GraphController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateData();
            fillChartDefault();
        }
        private void updateData()
        {
            //Get input from form
            DateTime date= dateTimePicker1.Value;
            int hoursStudied = Convert.ToInt32(labelHoursStudied.Text);

            //Pass to graphController
            graphController.setHoursStudied(date, hoursStudied);
            //string hoursString = graphController.HoursStudied.TryGetValue(3).ToString();
            //string hoursString = graphController.HoursStudied.;
            MessageBox.Show("Studied " + hoursStudied.ToString() + " hours on " + date.Date.ToString("yyyy - MM - dd"));

            updateChart();

        }

        private void fillChartDefault()
        {
            //Get default values to display- should come from DB.
            chart1.Series["Hours Studied"].Points.AddXY("Sunday", "2");
            chart1.Series["Hours Studied"].Points.AddXY("Monday", "5");
            chart1.Series["Hours Studied"].Points.AddXY("Tuesday", "8");
            chart1.Series["Hours Studied"].Points.AddXY("Wednesday", "0");
            chart1.Series["Hours Studied"].Points.AddXY("Thursday", "1");
            chart1.Series["Hours Studied"].Points.AddXY("Friday", "3");
            chart1.Series["Hours Studied"].Points.AddXY("Saturday", "2");
        }

        private void updateChart()
        {
            for (int i = 0; i < chart1.Series.Count; i++)
                chart1.Series["Hours Studied"].Points.RemoveAt(i);
        }


    }
}
