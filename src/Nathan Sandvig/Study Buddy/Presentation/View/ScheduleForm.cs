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
            double[] studyGoal = new double[7];
            for(int i = 0; i < 7; i++)
            {
                hoursStudied[i] = 0;
                studyGoal[i] = 0;
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
                for(int j = 0; j < 7; j++)
                {
                    DayOfWeek day = (DayOfWeek)j;
                    if (course.schedule.times.ContainsKey(day))
                    {
                        Label label = controller.createCourseLabel(course.name, red, green, blue);
                        this.tableLayoutPanel2.Controls.Add(label, j + 1, course.schedule.times[day].startTime.Hour-6);
                        this.tableLayoutPanel2.SetRowSpan(label, course.schedule.times[day].endTime.Hour - course.schedule.times[day].startTime.Hour);
                    }
                }
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
                for (int j = 0; j < 7; j++)
                    studyGoal[j] += Math.Round(Algorithm.HoursForGrade(course, 95), 2) / 7;
            }
            DayOfWeek dayOf = DayOfWeek.Sunday;
            for (int i = 0; i < 7; i++)
            {
                double courseHours = 0.0;
                for (int j = 0; j < controller.getCourses().Count; j++)
                    courseHours += controller.getCourses()[j].schedule.getCourseHours(dayOf);
                if (studyGoal[i] > 14 - courseHours)
                    studyGoal[i] = 14 - courseHours;
                studyGoal[i] = Math.Round(studyGoal[i], 0);
                if (i != 6)
                    dayOf++;
            }
            sunday.Text = hoursStudied[0] + "/" + studyGoal[0];
            monday.Text = hoursStudied[1] + "/" + studyGoal[1];
            tuesday.Text = hoursStudied[2] + "/" + studyGoal[2];
            wednesday.Text = hoursStudied[3] + "/" + studyGoal[3];
            thursday.Text = hoursStudied[4] + "/" + studyGoal[4];
            friday.Text = hoursStudied[5] + "/" + studyGoal[5];
            saturday.Text = hoursStudied[6] + "/" + studyGoal[6];
        }
    }
}
