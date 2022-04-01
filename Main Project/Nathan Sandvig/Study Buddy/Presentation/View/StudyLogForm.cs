using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.BusinessLogic;
using Study_Buddy.Presentation.View;

namespace Study_Buddy.Presentation
{
    public partial class StudyLogForm : BaseForm, IView
    {
        private StudyLogFormController controller;
        public StudyLogForm()
        {
            this.title = "Study Log Form";
            this.Text = title;
            this.mainHeader.Text = title;
        }

        //---------------------------------------------------------------------
        // Sets the form's controller
        // v1: Created the method - Peter H, 3-19-22
        //---------------------------------------------------------------------
        public void SetController(FormController controller)
        {
            this.controller = (StudyLogFormController)controller;
        }

        private void butAddHours_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            double hours = 0;
            int week = 0;
            int day = 0;
            Course course = new Course();
            Account test = new Account("","",0);

            if (cmbCourses.SelectedIndex < 1)
            {
                /*
                try
                {
                    List<Course> testCourses = test.courses;
                    course = testCourses[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error choosing Course");
                    valid = false;
                }
                */
            }
            else
            {
                MessageBox.Show("No Course was selected");
                valid = false;
            }

            try
            {
                week = Int32.Parse(txtWeekNum.Text);
            }
            catch
            {
                MessageBox.Show("Invalid week value");
                valid = false;
            }

            try
            {
                day = Int32.Parse(txtDayDate.Text);
            }
            catch
            {
                MessageBox.Show("Invalid day value");
                valid = false;
            }

            try
            {
                hours = Double.Parse(txtHours.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Hours");
                valid = false;
            }

            if(week < 0)
            {
                MessageBox.Show("Invalid week value");
                valid = false;
            }
            else if(day < 0)
            {
                MessageBox.Show("Invalid day value");
                valid = false;
            }
            else if(hours < 0)
            {
                MessageBox.Show("Invalid Hours");
                valid = false;
            }

            if (valid)
            {
                // Add assignment
                // wip does not like courseName
                //controller.AddAssignment(courseName, txtNameAssign.Text,points,weight);
                MessageBox.Show("hours added");
                controller.AddHours(course,day,week,hours);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
