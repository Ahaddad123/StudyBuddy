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

namespace Study_Buddy.Presentation.View
{
    public partial class AddCoursePopupForm : Form
    {
        private AddCourseFormController controller;
        public AddCoursePopupForm()
        {
            InitializeComponent();
        }

        private void AddCoursePopupForm_Load(object sender, EventArgs e)
        {

        }

        public void SetController(FormController controller)
        {
            this.controller = (AddCourseFormController)controller;
        }

        private void butAddCourse_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            double coursePriority = 0;
            double courseCredit = 0;
            if (txtCourseTitle.Text.Equals(""))
            {
                MessageBox.Show("Invalid Name");
                valid = false;
            }
            try
            {
                if (!txtCoursePriority.Text.Equals(""))
                {
                    coursePriority = Double.Parse(txtCoursePriority.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Priority");
                valid = false;
            }
            try
            {
                courseCredit = Double.Parse(txtCourseCredits.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Credits");
                valid = false;
            }
            if (coursePriority < 0)
            {
                MessageBox.Show("Invalid Priority");
                valid = false;
            }
            if (courseCredit < 0)
            {
                MessageBox.Show("Invalid Credits");
                valid = false;
            }

            if (valid)
            {
                Course course = new CourseBuilder().WithName(txtCourseTitle.Text).WithCode(txtCourseCode.Text).WithCredits(courseCredit).WithPriority(coursePriority).Build();
                //TODO: Call this in the AddCourseFormController
                controller.addCourse(course);
                MessageBox.Show("Succesfully added " + course.name);
            }
        }
    }
}
