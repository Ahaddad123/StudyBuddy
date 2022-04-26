using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Buddy.Presentation
{
    public partial class Nav : UserControl
    {
        //Nav is 315 x 737 px (Forms are 1266 x 768px but have to account for 31px being stolen by the stupid titlebar...)
        private Form currentForm { get; set; }
        public Nav()
        {
            this.currentForm = currentForm;
            //this.MaximumSize = new System.Drawing.Size(315, 768);
            //this.Size = new System.Drawing.Size(315, 768);
            InitializeComponent();
        }
        
        public void SetCurrentForm(Form currentForm)
        {
            this.currentForm = currentForm;
        }

        private void btnHome_Click(object sender, EventArgs e)
        { 
            FormSwitcher.OpenHomePageForm(currentForm);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogHours_Click(object sender, EventArgs e)
        {

            FormSwitcher.OpenStudyLogForm(currentForm);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenCalendarForm(currentForm);
        }

        private void btnVisualizeMyData_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenCourseInfoForm(currentForm);

        }

        private void btnMySchedule_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenScheduleForm(currentForm);
        }


        private void btnAddDropCourse_Click(object sender, EventArgs e)
        {

            FormSwitcher.OpenAddCourseForm(currentForm);
        }

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenAddAssignmentForm(currentForm);

        }
    }
}
