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
        private Form currentForm { get; set; }
        public Nav(Form currentForm)
        {
            InitializeComponent();
            this.currentForm = currentForm;
            this.MaximumSize = new System.Drawing.Size(315, 780);
            this.Size = new System.Drawing.Size(315, 780);
            this.panelSubMenu.MaximumSize = new System.Drawing.Size(315, 780);
            this.panelSubMenu.Size = new System.Drawing.Size(315, 780);
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenHomePageForm(currentForm);
        }

        private void btnAddAssignment_Click_1(object sender, EventArgs e)
        {
            FormSwitcher.OpenAddAssignmentForm(currentForm);
        }

        private void btnLogHours_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenStudyLogForm(currentForm);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
        }

        private void btnVisualizeMyData_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenCourseInfoForm(currentForm);
        }

        private void btnMySchedule_Click(object sender, EventArgs e)
        {
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
        }

        private void btnAddDropCourse_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenAddCourseForm(currentForm);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
        }

    }
}
