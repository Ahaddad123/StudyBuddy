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
    //---------------------------------------------------------------------
    // This class is the persistent vertical navigation bar that allows 
    // a user to change forms.
    // Note that Nav is 315 x 737 px (Forms are 1366 x 768px but have to
    // account for 31px being stolen by the stupid titlebar...)
    //---------------------------------------------------------------------
    public partial class Nav : UserControl
    {

        //---------------------------------------------------------------------
        // Private Data Members:
        // currentForm : tracks the form that is currently opened
        //---------------------------------------------------------------------
        private Form currentForm;

        //---------------------------------------------------------------------
        // Default constructor
        //---------------------------------------------------------------------
        public Nav()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        // Changes the current form
        // currentForm : the new currentForm
        //---------------------------------------------------------------------
        public void SetCurrentForm(Form currentForm)
        {
            this.currentForm = currentForm;
        }

        //---------------------------------------------------------------------
        // Event handler for clicking the "Home" button
        //---------------------------------------------------------------------
        private void btnHome_Click(object sender, EventArgs e)
        { 
            FormSwitcher.OpenHomePageForm(currentForm);
        }

        //---------------------------------------------------------------------
        // Event handler for clicking the "My Info" button
        //---------------------------------------------------------------------
        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenUserInfoForm(currentForm);
        }

        //---------------------------------------------------------------------
        // Event handler for clicking the "Log Hours" button
        //---------------------------------------------------------------------
        private void btnLogHours_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenStudyLogForm(currentForm);
        }

        //---------------------------------------------------------------------
        // Event handler for clicking the "Calendar" button
        //---------------------------------------------------------------------
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenCalendarForm(currentForm);
        }

        //---------------------------------------------------------------------
        // Event handler for clicking the "My Course Info" button
        //---------------------------------------------------------------------
        private void btnMyCourseInfo_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenCourseInfoForm(currentForm);
        }

        //---------------------------------------------------------------------
        // Event handler for clicking the "My Schedule" button
        //---------------------------------------------------------------------
        private void btnMySchedule_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenScheduleForm(currentForm);
        }

        //---------------------------------------------------------------------
        // Event handler for clicking the "Manage My Courses" button
        //---------------------------------------------------------------------
        private void btnManageMyCourses_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenAddCourseForm(currentForm);
        }

        //---------------------------------------------------------------------
        // Event handler for clicking the "Add Assignment" button
        //---------------------------------------------------------------------
        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenAddAssignmentForm(currentForm);
        }
    }
}
