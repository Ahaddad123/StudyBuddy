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

            cmbMonStart.Items.AddRange(new Object[] { });
            cmbMonEnd.Items.AddRange(new Object[] { });
            cmbTueStart.Items.AddRange(new Object[] { });
            cmbTueEnd.Items.AddRange(new Object[] { });
            cmbWenStart.Items.AddRange(new Object[] { });
            cmbWenEnd.Items.AddRange(new Object[] { });
            cmbThuStart.Items.AddRange(new Object[] { });
            cmbThuEnd.Items.AddRange(new Object[] { });
            cmbFriStart.Items.AddRange(new Object[] { });
            cmbFriEnd.Items.AddRange(new Object[] { });
            cmbSatStart.Items.AddRange(new Object[] { });
            cmbSatEnd.Items.AddRange(new Object[] { });
            cmbSunStart.Items.AddRange(new Object[] { });
            cmbSunEnd.Items.AddRange(new Object[] { });

            TimeSpan startingTime = new TimeSpan(0, 0, 0);
            DateTime startingDate = new DateTime(DateTime.MinValue.Ticks);

            for (int x = 0; x < 48; x++)
            {
                int mins = 30 * x;
                TimeSpan addedTime = new TimeSpan(0, mins, 0);
                TimeSpan algTime = startingTime.Add(addedTime);
                DateTime resDate = startingDate + algTime;
                cmbMonStart.Items.Add(resDate.TimeOfDay);
                cmbMonEnd.Items.Add(resDate.TimeOfDay);
                cmbTueStart.Items.Add(resDate.TimeOfDay);
                cmbTueEnd.Items.Add(resDate.TimeOfDay);
                cmbWenStart.Items.Add(resDate.TimeOfDay);
                cmbWenEnd.Items.Add(resDate.TimeOfDay);
                cmbThuStart.Items.Add(resDate.TimeOfDay);
                cmbThuEnd.Items.Add(resDate.TimeOfDay);
                cmbFriStart.Items.Add(resDate.TimeOfDay);
                cmbFriEnd.Items.Add(resDate.TimeOfDay);
                cmbSatStart.Items.Add(resDate.TimeOfDay);
                cmbSatEnd.Items.Add(resDate.TimeOfDay);
                cmbSunStart.Items.Add(resDate.TimeOfDay);
                cmbSunEnd.Items.Add(resDate.TimeOfDay);
            }
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
            if ((double)cmbSunStart.SelectedValue > (double)cmbSunEnd.SelectedValue)
            {
                creditsErrorMessageLabel.Text = "Invalid sunday times";
                valid = false;
            }
            else
            {
                List<DateTime> sunday = new List<DateTime>();
                sunday.Add((DateTime)cmbSunStart.SelectedValue);
                sunday.Add((DateTime)cmbSunEnd.SelectedValue);
                dateTimes.Add(sunday);
            }
            //add course times for monday
            if ((double)cmbMonStart.SelectedValue > (double)cmbMonEnd.SelectedValue)
            {
                creditsErrorMessageLabel.Text = "Invalid monday times";
                valid = false;
            }
            else
            {
                List<DateTime> monday = new List<DateTime>();
                monday.Add((DateTime)cmbMonStart.SelectedValue);
                monday.Add((DateTime)cmbMonEnd.SelectedValue);
                dateTimes.Add(monday);
            }
            //add course times for tuesday
            if ((double)cmbTueStart.SelectedValue > (double)cmbTueEnd.SelectedValue)
            {
                creditsErrorMessageLabel.Text = "Invalid tuesday times";
                valid = false;
            }
            else
            {
                List<DateTime> tueday = new List<DateTime>();
                tueday.Add((DateTime)cmbTueStart.SelectedValue);
                tueday.Add((DateTime)cmbTueEnd.SelectedValue);
                dateTimes.Add(tueday);
            }
            //add course times for wensday
            if ((double)cmbWenStart.SelectedValue > (double)cmbWenEnd.SelectedValue)
            {
                creditsErrorMessageLabel.Text = "Invalid wensday times";
                valid = false;
            }
            else
            {
                List<DateTime> wenday = new List<DateTime>();
                wenday.Add((DateTime)cmbWenStart.SelectedValue);
                wenday.Add((DateTime)cmbWenEnd.SelectedValue);
                dateTimes.Add(wenday);
            }
            //add course times for Thursday
            if ((double)cmbThuStart.SelectedValue > (double)cmbThuEnd.SelectedValue)
            {
                creditsErrorMessageLabel.Text = "Invalid Thursday times";
                valid = false;
            }
            else
            {
                List<DateTime> thuday = new List<DateTime>();
                thuday.Add((DateTime)cmbThuStart.SelectedValue);
                thuday.Add((DateTime)cmbThuEnd.SelectedValue);
                dateTimes.Add(thuday);
            }
            //add course times for Friday
            if ((double)cmbFriStart.SelectedValue > (double)cmbFriEnd.SelectedValue)
            {
                creditsErrorMessageLabel.Text = "Invalid friday times";
                valid = false;
            }
            else
            {
                List<DateTime> friday = new List<DateTime>();
                friday.Add((DateTime)cmbMonStart.SelectedValue);
                friday.Add((DateTime)cmbMonEnd.SelectedValue);
                dateTimes.Add(friday);
            }
            //add course times for Saturday
            if ((double)cmbSatStart.SelectedValue > (double)cmbSatEnd.SelectedValue)
            {
                creditsErrorMessageLabel.Text = "Invalid saterday times";
                valid = false;
            }
            else
            {
                List<DateTime> satday = new List<DateTime>();
                satday.Add((DateTime)cmbSatStart.SelectedValue);
                satday.Add((DateTime)cmbSatEnd.SelectedValue);
                dateTimes.Add(satday);
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
