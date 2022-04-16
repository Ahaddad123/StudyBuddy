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
            List<List<DateTime>> dateTimes = new List<List<DateTime>>();
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
            //add course times for Sunday
            if (dtpSunStart.Value > dtpSunEnd.Value)
            {
                //creditsErrorMessageLabel.Text = "Invalid sunday times";
                valid = false;
            }
            else
            {
                List<DateTime> sundae = new List<DateTime>();
                sundae.Add(dtpSunStart.Value);
                sundae.Add(dtpSunEnd.Value);
                dateTimes.Add(sundae);
            }
            //add course times for monday
            if (dtpMonStart.Value > dtpMonEnd.Value)
            {
                //creditsErrorMessageLabel.Text = "Invalid monday times";
                valid = false;
            }
            else
            {
                List<DateTime> mondae = new List<DateTime>();
                mondae.Add(dtpMonStart.Value);
                mondae.Add(dtpMonEnd.Value);
                dateTimes.Add(mondae);
            }
            //add course times for tuesday
            if (dtpTueStart.Value > dtpTueEnd.Value)
            {
                //creditsErrorMessageLabel.Text = "Invalid tuesday times";
                valid = false;
            }
            else
            {
                List<DateTime> tuedae = new List<DateTime>();
                tuedae.Add(dtpTueStart.Value);
                tuedae.Add(dtpTueEnd.Value);
                dateTimes.Add(tuedae);
            }
            //add course times for wensday
            if (dtpWenStart.Value > dtpWenEnd.Value)
            {
                //creditsErrorMessageLabel.Text = "Invalid wensday times";
                valid = false;
            }
            else
            {
                List<DateTime> wendae = new List<DateTime>();
                wendae.Add(dtpWenStart.Value);
                wendae.Add(dtpWenEnd.Value);
                dateTimes.Add(wendae);
            }
            //add course times for Thursday
            if (dtpThuStart.Value > dtpThuEnd.Value)
            {
                //creditsErrorMessageLabel.Text = "Invalid Thursday times";
                valid = false;
            }
            else
            {
                List<DateTime> thudae = new List<DateTime>();
                thudae.Add(dtpThuStart.Value);
                thudae.Add(dtpThuEnd.Value);
                dateTimes.Add(thudae);
            }
            //add course times for Friday
            if (dtpFriStart.Value > dtpFriEnd.Value)
            {
                //creditsErrorMessageLabel.Text = "Invalid friday times";
                valid = false;
            }
            else
            {
                List<DateTime> fridae = new List<DateTime>();
                fridae.Add(dtpMonStart.Value);
                fridae.Add(dtpMonEnd.Value);
                dateTimes.Add(fridae);
            }
            //add course times for Saturday
            if (dtpSatStart.Value > dtpSatEnd.Value)
            {
                //creditsErrorMessageLabel.Text = "Invalid saterday times";
                valid = false;
            }
            else
            {
                List<DateTime> satdae = new List<DateTime>();
                satdae.Add(dtpSatStart.Value);
                satdae.Add(dtpSatEnd.Value);
                dateTimes.Add(satdae);
            }

            if (valid)
            {
                Course course = new CourseBuilder().WithName(txtCourseTitle.Text).WithCode(txtCourseCode.Text).WithCredits(courseCredit).WithPriority(coursePriority).WithCourseHours(dateTimes).Build();
                //TODO: Call this in the AddCourseFormController
                controller.addCourse(course);
                MessageBox.Show("Succesfully added " + course.name);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
