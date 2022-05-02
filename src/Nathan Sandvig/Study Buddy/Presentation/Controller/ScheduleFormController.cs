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
    internal class ScheduleFormController : FormController
    {
        public ScheduleFormController(ScheduleForm form)
        {
            this.view = form;
        }

        public List<Course> getCourses()
        {
            return AccountController.account.courses;
        }

        public Label createCourseLabel(Course course, int red, int green, int blue)
        {
            Label label = new Label();
            label.Text = course.name;
            label.BackColor = Color.FromArgb(red, green, blue);
            label.AutoSize = true;
            label.Dock = DockStyle.Fill;
            return label;
        }
    }
}
