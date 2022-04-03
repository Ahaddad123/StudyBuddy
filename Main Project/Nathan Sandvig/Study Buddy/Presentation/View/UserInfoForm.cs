using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.Presentation.Controller;
using Study_Buddy.Presentation.Model;

namespace Study_Buddy.Presentation.View
{
    public partial class UserInfoForm : BaseForm, IGraphView
    {
        private UserInfoFormController controller;
        private string gpaSeriesID;
        public UserInfoForm()
        {
            InitializeComponent();
            this.title = "Your Information";
            this.Text = title;
            this.mainHeader.Text = title;
            this.nav1.SetCurrentForm(this);
            this.gpaSeriesID = "Your GPA";
            gpaChart.Series.Add(gpaSeriesID);
        }

        public void SetUserInfo(string name, string school, double gpa)
        {
            this.userName.Text = name;
            this.userSchool.Text = school;
            this.userGPA.Text = "Your GPA: " + gpa.ToString();

        }

        public void DrawGPAGraph(List<DateTime> datesX, List<double> averageGradesY)
        {
            //Initialize and format the chart
            gpaChart.Series[gpaSeriesID].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            gpaChart.Series[gpaSeriesID].MarkerStyle =
                System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            gpaChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            gpaChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            gpaChart.ChartAreas[0].AxisX.Interval = 30;  //TODO Figure out how to label this properly

            //Add members of data series to chart
            for (int i = 0; i < datesX.Count; i++)
            {
                gpaChart.Series[gpaSeriesID].Points.AddXY(datesX[i], averageGradesY[i]);
            }
        }

        public void DrawGradeGraph(List<DateTime> xValues, List<double> yValues)
        {
            throw new NotImplementedException();
        }

        public void DrawStudyLogGraph(int weekID, List<string> xValues, List<int> yValues)
        {
            throw new NotImplementedException();
        }

        public void SetController(GraphController formController)
        {
            this.controller = (UserInfoFormController)formController;
        }
    }
}
