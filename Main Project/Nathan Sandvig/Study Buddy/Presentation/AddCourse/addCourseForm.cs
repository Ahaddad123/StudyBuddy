﻿using System;
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

namespace Study_Buddy.Presentation
{
    public partial class AddCourseForm : Form, IView
    {
        private AddCourseFormController controller;
        public AddCourseForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.mainPanel.MaximumSize = new System.Drawing.Size(1080, 720);
            this.mainPanel.Size = new System.Drawing.Size(1080, 720);
            this.nav1.SetCurrentForm(this);
        }

        //---------------------------------------------------------------------
        // Sets the form's controller
        // v1: Created the method - Peter H, 3-19-22
        //---------------------------------------------------------------------
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
