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

namespace Study_Buddy.Presentation
{
    public partial class CourseInfoForm : Form, GraphView
    {
        private DataAccess.Course course;
        private DataAccess.StudyLog studyLog;
        private CourseInfoFormController controller;
        private string gradesSeriesID;
        private string hoursSeriesID;

        public CourseInfoForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.gradesChart.Width = (800);
            this.hoursLoggedChart.Width = (800);

            //Default for now, need to pass actual data
            this.course = new DataAccess.Course();
            this.studyLog = new DataAccess.StudyLog();

            this.courseName.Text = course.name;
            gradesSeriesID = "Your grades for " + course.name;
            hoursSeriesID = "Your study hours for week 0";
            gradesChart.Series.Add(gradesSeriesID);

        }

        public void SetController(Controller controller)
        {
            this.controller = (CourseInfoFormController)controller;
        }


        //grades chart
        public void DrawGradeGraph(List<DateTime> datesX, List<double> averageGradesY)
        {
            gradesChart.Series[gradesSeriesID].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            gradesChart.Series[gradesSeriesID].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            gradesChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            gradesChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            gradesChart.ChartAreas[0].AxisX.Interval = 30;  //TODO Figure out how to label this properly

            for (int i = 0; i < datesX.Count; i++)
            {
                gradesChart.Series[gradesSeriesID].Points.AddXY(datesX[i], averageGradesY[i]);
            }
        }

        //study log chart
        public void DrawStudyLogGraph(int weekID, List<string> datesX, List<int> hoursY)
        {
            hoursSeriesID = "Your study hours for week " + weekID;
            hoursLoggedChart.Series.Add(hoursSeriesID);

            if (hoursLoggedChart.Series.Count > 1)
                hoursLoggedChart.Series.RemoveAt(0);
            hoursLoggedChart.Series[hoursSeriesID].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            hoursLoggedChart.Series[hoursSeriesID].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            hoursLoggedChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            hoursLoggedChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            hoursLoggedChart.ChartAreas[0].AxisX.Interval = 1;  //TODO Figure out how to label this properly

            for (int i = 0; i < datesX.Count; i++)
            {
                hoursLoggedChart.Series[hoursSeriesID].Points.AddXY(datesX[i], hoursY[i]);
            }
        }

        private void WeekPlus_Click(object sender, EventArgs e)
        {
            controller.ChangeCurrentWeekID(1);
        }

        private void WeekMinus_Click(object sender, EventArgs e)
        {

            controller.ChangeCurrentWeekID(-1);
        }
    }
}
