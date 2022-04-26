using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.DataAccess;
using Study_Buddy.BusinessLogic;
using Study_Buddy.Presentation.View;
using Study_Buddy.Presentation.Controller;

namespace Study_Buddy.Presentation
{
    public partial class ScheduleForm : BaseForm, IView
    {
        private ScheduleFormController controller;
        public ScheduleForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.title = "Schedule";
            this.Text = title;
            this.mainHeader.Text = title;
            this.nav1.SetCurrentForm(this);
        }

        //---------------------------------------------------------------------
        // Sets the form's controller
        // v1: Created the method - Peter H, 3-19-22
        //---------------------------------------------------------------------
        public void SetController(FormController controller)
        {
            this.controller = (ScheduleFormController)controller;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            double[] hoursStudied = new double[7];
            double studyGoal = 0;
            for(int i = 0; i < 7; i++)
            {
                hoursStudied[i] = 0;
            }
            for(int i = 0; i < this.tableLayoutPanel2.RowCount; i++)
            {
                Label label = new Label();
                int time = i + 6;
                if(time < 12)
                {
                    label.Text = time + "am";
                }
                else if (time == 12)
                {
                    label.Text = time + "pm";
                }
                else
                {
                    label.Text = time % 12 + "pm";
                }
                this.tableLayoutPanel2.Controls.Add(label, 0, i);
            }

            int red = 235;
            int green = 131;
            int blue = 131;
            for (int i = 0; i < controller.getCourses().Count; i++)
            {
                Course course = controller.getCourses()[i];
                Label label = controller.createCourseLabel(course, red, green, blue);
                int index = 0;
                foreach(List<DateTime> days in course.courseTimes)
                {
                    if(days != null)
                    {
                        this.tableLayoutPanel2.Controls.Add(label, index + 1, days.ElementAt(0).Hour - 6);
                        this.tableLayoutPanel2.SetRowSpan(label, days.ElementAt(1).Hour - days.ElementAt(0).Hour);
                    }
                    index++;
                }
                this.tableLayoutPanel2.Controls.Add(label, i + 1, i + 1); //need to update indices
                this.tableLayoutPanel2.SetRowSpan(label, 2); //need to update span
                if (i % 3 == 0)
                {
                    green = red;
                }
                else if (i % 3 == 1)
                {
                    red = blue;
                }
                else if (i % 3 == 2)
                {
                    blue = green;
                }

                DateTime today = DateTime.Today.Date;
                DateTime sunday = new DateTime(today.Year, today.Month, today.Day - (int)today.DayOfWeek);
                for (int j = 0; j < 7; j++)
                {
                    hoursStudied[(int)sunday.DayOfWeek] += course.GetHoursStudied(sunday.Date);
                    sunday = sunday.AddDays(1);
                }
                studyGoal += Math.Round(Algorithm.HoursForGrade(course, 95), 2);
            }
            studyGoal /= 7;
            studyGoal = Math.Round(studyGoal, 0);
            sunday.Text = hoursStudied[0] + "/" + studyGoal;
            monday.Text = hoursStudied[1] + "/" + studyGoal;
            tuesday.Text = hoursStudied[2] + "/" + studyGoal;
            wednesday.Text = hoursStudied[3] + "/" + studyGoal;
            thursday.Text = hoursStudied[4] + "/" + studyGoal;
            friday.Text = hoursStudied[5] + "/" + studyGoal;
            saturday.Text = hoursStudied[6] + "/" + studyGoal;
        }
    }
}
