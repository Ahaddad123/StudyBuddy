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
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.title = "Study Log Form";
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
            this.controller = (StudyLogFormController)controller;
        }

        private void butAddHours_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            double hours = 0;
            DateTime date;
            Course course = new Course();
            Account test = new Account("", "");

            if(cmbCourses.SelectedIndex == -1)
            {
                valid = false;
                courseErrorMessageLabel.Text = "No course was selected";
            }

            date = DTPhourDate.Value;

            try
            {
                hours = Double.Parse(txtHours.Text);
            }
            catch
            {
                hoursErrorMessageLabel.Text = "Invalid Hours";
                valid = false;
            }

            if (hours < 0)
            {
                hoursErrorMessageLabel.Text = "Invalid Hours";
                valid = false;
            }

            if (valid)
            {
                // Add assignment
                // wip does not like courseName
                //controller.AddAssignment(courseName, txtNameAssign.Text,points,weight);
                string courses = cmbCourses.Text;
                string hourss = txtHours.Text;

                Account account = new Account();
                account.addStudyHours(courses, DTPhourDate, hourss);

                successMessageLabel.Text = hours + " hours added for " + course.name;
                hoursErrorMessageLabel.Text = "";
                courseErrorMessageLabel.Text = "";
                controller.AddHours(cmbCourses.Text,date,hours);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void StudyLogForm_Load(object sender, EventArgs e)
        {
            foreach (Course c in AccountController.account.courses)
            {
                cmbCourses.Items.Add(c.name);
            }
        }
    }
}
