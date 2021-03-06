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
using Study_Buddy.BusinessLogic;
using Study_Buddy.Presentation.Model;

namespace Study_Buddy.Presentation.View
{
    //---------------------------------------------------------------------
    // This form displays information pertinent to a course, including
    // graphs of study hours and grades in that course.
    // v1: Created the class - Peter H, 3-7-22
    //---------------------------------------------------------------------
    public partial class CourseInfoForm : BaseForm, IView
    {
        //---------------------------------------------------------------------
        // Private data members:
        // controller : the form's controller 
        // course : the course whose information is being displayed
        // gradeSeriesID : the seriesID of the series on the gradesChart
        // hoursSeriesID : the seriesID of the current series being
        // displayed on the hoursLogged chart
        //---------------------------------------------------------------------
        private CourseInfoFormController controller;
        public string currentCourseName { get; set; }
        private string gradesSeriesID;
        private string hoursSeriesID;

        //---------------------------------------------------------------------
        // Default constructor.  Initializes components and other members 
        // to starting values.
        // v1: Created the method - Peter H, 3-6-22
        //---------------------------------------------------------------------
        public CourseInfoForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1366, 768);
            this.userCourseList1.ChangePanelWidth(this.courseListPanel.Width);

            //Draw courses on the userCourseList
            this.userCourseList1.DrawCourses(AccountController.account.courses);
            this.userCourseList1.StatusUpdated += new EventHandler(Event_UserCourseListButtonClicked);
            this.nav1.SetCurrentForm(this);
        }

        //---------------------------------------------------------------------
        // Displays the information for the passed course.
        //---------------------------------------------------------------------
        public void DisplayCourseInfo(string newCourseName)
        {
            //Display info for currentCourse
            this.currentCourseName = newCourseName;
            this.title = newCourseName;
            this.Text = title;
            this.mainHeader.Text = title;

            //Clear the charts 
            ClearCharts();

            //Sets chart series info for passed course
            gradesSeriesID = "Grades for " + newCourseName;
            hoursSeriesID = "Week 1";
            gradesChart.Series.Add(gradesSeriesID);
        }

        public void ClearCharts()
        {
            gradesChart.Series.Clear();
            hoursLoggedChart.Series.Clear();
        }


        //---------------------------------------------------------------------
        // Sets the form's controller
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public void SetController(FormController controller)
        {
            this.controller = (CourseInfoFormController)controller;
        }


        //---------------------------------------------------------------------
        // Draws the grade graph with the passed data
        // datesX: the dates to be graphed on the X axis
        // averageGradesY : the grades to be graphed on the Y axis
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public void DrawGradeGraph(List<DateTime> datesX, List<double> averageGradesY)
        {
            //Initialize and format the chart
            gradesChart.Series[gradesSeriesID].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            gradesChart.Series[gradesSeriesID].MarkerStyle =
                System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
            gradesChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            gradesChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            gradesChart.ChartAreas[0].AxisX.Interval = 30;  //TODO Figure out how to label this properly
            gradesChart.ChartAreas[0].AxisY.Maximum = 100;

            //Add members of data series to chart
            for (int i = 0; i < datesX.Count; i++)
            {
                gradesChart.Series[gradesSeriesID].Points.AddXY(datesX[i], averageGradesY[i]);
            }
        }

        //---------------------------------------------------------------------
        // Draws the study log graph for the specified week with the passed data
        // weekID : The week for which data is being graphed.
        // datesX: the dates to be graphed on the X axis
        // hoursY : the hours to be graphed on the Y axis
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public void DrawStudyLogGraph(int weekID, List<string> datesX, List<int> hoursY)
        {
            //Initialize and format the chart
            hoursSeriesID = "Week " + (weekID + 1); //Don't start count at 0
            hoursLoggedChart.Series.Add(hoursSeriesID);

            //If changing the sereies being graphed, remove the old one
            if (hoursLoggedChart.Series.Count > 1)
                hoursLoggedChart.Series.RemoveAt(0);
            hoursLoggedChart.Series[hoursSeriesID].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            hoursLoggedChart.Series[hoursSeriesID].MarkerStyle =
                System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
            hoursLoggedChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            hoursLoggedChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            hoursLoggedChart.ChartAreas[0].AxisX.Interval = 1;  //TODO Figure out how to label this properly

            hoursLoggedChart.ChartAreas[0].AxisY.Maximum = 24;

            //Add members of data series to chart
            for (int i = 0; i < datesX.Count; i++)
            {
                hoursLoggedChart.Series[hoursSeriesID].Points.AddXY(datesX[i], hoursY[i]);
            }
        }

        //---------------------------------------------------------------------
        // Handles the event of a userCourseListButton being clicked.
        // Changes the current course for whom information is being displayed.
        //---------------------------------------------------------------------
        public void Event_UserCourseListButtonClicked(object sender, EventArgs e)
        {
            //Extract course name from button
            string courseName = ((Button)sender).Text;
            //Send course to controller
            this.controller.UpdateCurrentCourse(courseName);
            //Set display to match current course
            this.title = courseName;
            this.mainHeader.Text = courseName;
        }

        //---------------------------------------------------------------------
        // Handles clicking the WeekPlus button.  Sends an increment of 1 
        // to the controller.
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        private void WeekPlus_Click(object sender, EventArgs e)
        {
            controller.ChangeCurrentWeekID(1);
        }

        //---------------------------------------------------------------------
        // Handles clicking the WeekMinus button.  Sends an decrement of 1 
        // to the controller.
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        private void WeekMinus_Click(object sender, EventArgs e)
        {
            controller.ChangeCurrentWeekID(-1);
        }


    }
}
