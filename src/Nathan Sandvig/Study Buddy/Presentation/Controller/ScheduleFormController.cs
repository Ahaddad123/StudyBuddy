using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation.Controller
{
    //---------------------------------------------------------------------
    // Controls the ScheduleForm
    //---------------------------------------------------------------------
    internal class ScheduleFormController : FormController
    {
        //---------------------------------------------------------------------
        // Sets the view to the ScheduleForm
        //---------------------------------------------------------------------
        public ScheduleFormController(ScheduleForm form)
        {
            this.view = form;
        }

        //---------------------------------------------------------------------
        // Gets the list of courses in the Account
        // return: list of courses in the Account
        //---------------------------------------------------------------------
        public List<Course> getCourses()
        {
            return AccountController.account.courses;
        }

        //---------------------------------------------------------------------
        // Creates the label for the course in the schedule
        // courseName: name of the course to be shown on the label
        // red: red value in the RGB color to set the background of the label to
        // green: green value in the RGB color to set the background of the label to
        // blue: blue value in the RGB color to set the background of the label to
        //---------------------------------------------------------------------
        public Label createCourseLabel(String courseName, int red, int green, int blue)
        {
            Label label = new Label();
            label.Text = courseName;
            label.BackColor = Color.FromArgb(red, green, blue);
            label.AutoSize = true;
            label.Dock = DockStyle.Fill;
            return label;
        }
    }
}
