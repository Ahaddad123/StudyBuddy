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

namespace Study_Buddy.Presentation
{
    public partial class AddCourseForm : BaseForm, IView
    {
        private AddCourseFormController controller;
        public AddCourseForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.mainPanel.MaximumSize = new System.Drawing.Size(1080, 720);
            this.mainPanel.Size = new System.Drawing.Size(1080, 720);
            this.title = "Add/Remove Course";
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
                nameErrorMessageLabel.Text = "Invalid Name";
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
                PriorityErrorMessageLabel.Text = "Invalid Priority";
                valid = false;
            }
            try
            {
                courseCredit = Double.Parse(txtCourseCredits.Text);
            }
            catch (Exception ex)
            {
                creditsErrorMessageLabel.Text = "Invalid Credits";
                valid = false;
            }
            if (coursePriority < 0)
            {
                PriorityErrorMessageLabel.Text = "Invalid Priority";
                valid = false;
            }
            if (courseCredit < 0)
            {
                creditsErrorMessageLabel.Text = "Invalid Credits";
                valid = false;
            }
            //add course times for Sunday
            /*if (dtpSunStart.Value > dtpSunEnd.Value)
            {
                creditsErrorMessageLabel.Text = "Invalid sunday times";
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
                creditsErrorMessageLabel.Text = "Invalid monday times";
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
                creditsErrorMessageLabel.Text = "Invalid tuesday times";
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
                creditsErrorMessageLabel.Text = "Invalid wensday times";
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
                creditsErrorMessageLabel.Text = "Invalid Thursday times";
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
                creditsErrorMessageLabel.Text = "Invalid friday times";
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
                creditsErrorMessageLabel.Text = "Invalid saterday times";
                valid = false;
            }
            else
            {
                List<DateTime> satdae = new List<DateTime>();
                satdae.Add(dtpSatStart.Value);
                satdae.Add(dtpSatEnd.Value);
                dateTimes.Add(satdae);
            }*/

            if (valid)
            {
                Course course = new CourseBuilder().WithName(txtCourseTitle.Text).WithCode(txtCourseCode.Text).WithCredits(courseCredit).WithPriority(coursePriority).WithCourseHours(dateTimes).Build();
                //TODO: Call this in the AddCourseFormController
                controller.addCourse(course);
                nameErrorMessageLabel.Text = "";
                CodeErrorMessageLabel.Text = "";
                PriorityErrorMessageLabel.Text = "";
                creditsErrorMessageLabel.Text = "";
                successLabel.Text = "Succesfully added " + course.name;
            }
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            foreach (Course c in AccountController.account.courses)
            {
                courseListBox.Items.Add(c.name);
            }
        }

        private void removeCourseButton_Click(object sender, EventArgs e)
        {
            AccountController.account.removeCourse(courseListBox.Text);
        }
    }
}
