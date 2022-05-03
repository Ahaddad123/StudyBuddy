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
    //---------------------------------------------------------------------
    // This class displays user info including username, school, current GPA
    // and a graph of semester GPA over entire semester.
    //---------------------------------------------------------------------
    public partial class UserInfoForm : BaseForm, IView
    {
        //---------------------------------------------------------------------
        // Private data members:
        // controller : the form's controller 
        // gpaSeriesID : the series ID of the series on the gpaChart
        //---------------------------------------------------------------------
        private UserInfoFormController controller;
        private string gpaSeriesID;

        //---------------------------------------------------------------------
        // Default constructor.  Initializes components and other members 
        // to starting values.
        //---------------------------------------------------------------------
        public UserInfoForm()
        {
            InitializeComponent();
            this.title = "Your Information";
            this.Text = title;
            this.mainHeader.Text = title;
            this.nav1.SetCurrentForm(this);
            this.gpaSeriesID = "Your GPA this semester";
            gpaChart.Series.Add(gpaSeriesID);
        }

        //---------------------------------------------------------------------
        // Displays name, school and gpa passed from controller.
        // userName : the username of the user
        // school : the user's school/university
        // gpa : the user's overall grade point average (not including 
        // this semester, at least as of 4-27-2022)
        //---------------------------------------------------------------------
        public void DisplayUserInfo(string firstName, string lastName, string school, string gpa)
        {
            this.fullName.Text = firstName + " " + lastName;
            this.userSchool.Text = school;
            this.userGPA.Text = "Your Current GPA: " + gpa;
        }
        //---------------------------------------------------------------------
        // Draws a graph of the user's GPA from the provided data.
        // datesX: the dates to be graphed on the X axis
        // averageGradesY : the avg GPA on a given date to be graphed on the Y axis
        //---------------------------------------------------------------------
        public void DrawGPAGraph(List<DateTime> datesX, List<double> averageGradesY)
        {
            //Initialize and format the chart
            gpaChart.Series[gpaSeriesID].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            gpaChart.Series[gpaSeriesID].MarkerStyle =
                System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
            gpaChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            gpaChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            gpaChart.ChartAreas[0].AxisX.Interval = 30;  //TODO: Figure out how to label this properly
            gpaChart.ChartAreas[0].AxisY.Maximum = 4;

            //Add members of data series to chart
            for (int i = 0; i < datesX.Count; i++)
            {
                gpaChart.Series[gpaSeriesID].Points.AddXY(datesX[i], averageGradesY[i]);
            }
        }

        //---------------------------------------------------------------------
        // Sets the form's controller
        // formController : the controller being set
        //---------------------------------------------------------------------
        public void SetController(FormController formController)
        {
            this.controller = (UserInfoFormController)formController;
        }

        private void userGPA_Click(object sender, EventArgs e)
        {

        }
    }
}
