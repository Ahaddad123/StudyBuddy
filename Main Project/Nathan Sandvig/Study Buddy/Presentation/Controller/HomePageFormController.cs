using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.DataAccess;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation
{
    internal class HomePageFormController : FormController
    {
        public HomePageFormController(HomePageForm form)
        {
            this.view = form;
            view.SetController(this);
        }

        public List<Course> getCourses()
        {
            return AccountController.account.courses;
        }

        public String getName()
        {
            return AccountController.account.username;
        }

        public Label createCourseLabel(Course course, int locationindex, int red, int green, int blue)
        {
            Label label = new Label();
            label.Text = course.name;
            label.BackColor = Color.FromArgb(red, green, blue);
            label.Location = new Point(40, locationindex);
            label.Size = new Size(250, 25);
            label.Font = new Font("Microsoft Sans Serif", 13);
            return label;
        }

        public Label createHoursLabel(Course course, double hoursStudied, int locationindex, int red, int green, int blue)
        {
            Label label = new Label();
            label.Text = hoursStudied + "/" + "study goal";
            label.BackColor = Color.FromArgb(red, green, blue);
            label.Location = new Point(290, locationindex);
            label.Size = new Size(250, 25);
            label.Font = new Font("Microsoft Sans Serif", 13);
            label.TextAlign = ContentAlignment.TopRight;
            return label;
        }

        public Button createAddGradeButton(Course course, int locationindex, EventHandler eventHandler)
        {
            Button button = new Button();
            button.BackColor = Color.LightGray;
            button.Location = new Point(550, locationindex);
            button.Size = new Size(200, 25);
            button.Text = "Add grade for this course";
            button.Font = new Font("Microsoft Sans Serif", 10);
            button.Click += eventHandler;
            button.Tag = course;
            button.Margin = new Padding(0);
            return button;
        }
    }
}
