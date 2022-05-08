using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation.View
{
    //---------------------------------------------------------------------
    // Windows Form UserControl to add a course
    //---------------------------------------------------------------------
    public partial class AddCourseBox : UserControl
    {
        //---------------------------------------------------------------------
        // Properties:
        // times : a dictionary mapping a weekday to a tuple of start and end times
        // StatusUpdated : An event handler created when a dynamically
        // generated button is clicked.  Is "bubbled" to the parent form for
        // handling the button click event
        //---------------------------------------------------------------------
        private Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times;
        public EventHandler StatusUpdated;

        //---------------------------------------------------------------------
        // Initializes the structure of the AddCourseBox
        //---------------------------------------------------------------------
        public AddCourseBox()
        {
            InitializeComponent();
            times = new Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)>();
            PopulateTimes();
        }

        //---------------------------------------------------------------------
        //Populates time combo boxes with possible times at 1 hour intervals
        //---------------------------------------------------------------------
        private void PopulateTimes()
        {
            TimeSpan startingTime = new TimeSpan(0, 0, 0);
            DateTime startingDate = new DateTime(DateTime.MinValue.Ticks);

            for (int x = 6; x < 26; x++)
            {
                int mins = 60 * x;
                TimeSpan addedTime = new TimeSpan(0, mins, 0);
                TimeSpan algTime = startingTime.Add(addedTime);
                DateTime resDate = startingDate + algTime;

                comboBoxMonStart.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxMonEnd.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxTueStart.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxTueEnd.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxWedStart.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxWedEnd.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxThuStart.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxThuEnd.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxFriStart.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxFriEnd.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxSatStart.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxSatEnd.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxSunStart.Items.Add(resDate.ToString("hh:mm tt"));
                comboBoxSunEnd.Items.Add(resDate.ToString("hh:mm tt"));
            }
        }

        //---------------------------------------------------------------------
        // User checked or unchecked the Sunday checkbox.
        //---------------------------------------------------------------------
        private void checkBoxSun_CheckedChanged(object sender, EventArgs e)
        {
            //Display comboboxes
            if (checkBoxSun.Checked)
            {
                comboBoxSunStart.Visible = true;
                comboBoxSunEnd.Visible = true;
            }
            //Don't display comboboxes
            else
            {
                comboBoxSunStart.SelectedItem = null;
                comboBoxSunEnd.SelectedItem = null;
                comboBoxSunStart.Visible = false;
                comboBoxSunEnd.Visible = false;
            }
        }

        //---------------------------------------------------------------------
        // User checked or unchecked the Monday checkbox.
        //---------------------------------------------------------------------
        private void checkBoxMon_CheckedChanged(object sender, EventArgs e)
        {
            //Display comboboxes
            if (checkBoxMon.Checked)
            {
                comboBoxMonStart.Visible = true;
                comboBoxMonEnd.Visible = true;
            }
            //Don't display comboboxes
            else
            {
                comboBoxMonStart.SelectedItem = null;
                comboBoxMonEnd.SelectedItem = null;
                comboBoxMonStart.Visible = false;
                comboBoxMonEnd.Visible = false;
            }
        }

        //---------------------------------------------------------------------
        // User checked or unchecked the Tuesday checkbox.
        //---------------------------------------------------------------------
        private void checkBoxTue_CheckedChanged(object sender, EventArgs e)
        {
            //Display comboboxes
            if (checkBoxTue.Checked)
            {
                comboBoxTueStart.Visible = true;
                comboBoxTueEnd.Visible = true;
            }
            //Don't display comboboxes
            else
            {
                comboBoxTueStart.SelectedItem = null;
                comboBoxTueEnd.SelectedItem = null;
                comboBoxTueStart.Visible = false;
                comboBoxTueEnd.Visible = false;
            }
        }

        //---------------------------------------------------------------------
        // User checked or unchecked the Wednesday checkbox.
        //---------------------------------------------------------------------
        private void checkBoxWed_CheckedChanged(object sender, EventArgs e)
        {
            //Display comboboxes
            if (checkBoxWed.Checked)
            {
                comboBoxWedStart.Visible = true;
                comboBoxWedEnd.Visible = true;
            }
            //Don't display comboboxes
            else
            {
                comboBoxWedStart.SelectedItem = null;
                comboBoxWedEnd.SelectedItem = null;
                comboBoxWedStart.Visible = false;
                comboBoxWedEnd.Visible = false;
            }
        }

        //---------------------------------------------------------------------
        // User checked or unchecked the Thursday checkbox.
        //---------------------------------------------------------------------

        private void checkBoxThu_CheckedChanged(object sender, EventArgs e)
        {
            //Display comboboxes
            if (checkBoxThu.Checked)
            {
                comboBoxThuStart.Visible = true;
                comboBoxThuEnd.Visible = true;
            }
            //Don't display comboboxes
            else
            {
                comboBoxThuStart.SelectedItem = null;
                comboBoxThuEnd.SelectedItem = null;
                comboBoxThuStart.Visible = false;
                comboBoxThuEnd.Visible = false;
            }
        }

        //---------------------------------------------------------------------
        // User checked or unchecked the Friday checkbox.
        //---------------------------------------------------------------------
        private void checkBoxFri_CheckedChanged(object sender, EventArgs e)
        {
            //Display comboboxes
            if (checkBoxFri.Checked)
            {
                comboBoxFriStart.Visible = true;
                comboBoxFriEnd.Visible = true;
            }
            //Don't display comboboxes
            else
            {
                comboBoxFriStart.SelectedItem = null;
                comboBoxFriEnd.SelectedItem = null;
                comboBoxFriStart.Visible = false;
                comboBoxFriEnd.Visible = false;
            }
        }

        //---------------------------------------------------------------------
        // User checked or unchecked the Saturday checkbox.
        //---------------------------------------------------------------------
        private void checkBoxSat_CheckedChanged(object sender, EventArgs e)
        {
            //Display comboboxes
            if (checkBoxSat.Checked)
            {
                comboBoxSatStart.Visible = true;
                comboBoxSatEnd.Visible = true;
            }
            //Don't display comboboxes
            else
            {
                comboBoxSatStart.SelectedItem = null;
                comboBoxSatEnd.SelectedItem = null;
                comboBoxSatStart.Visible = false;
                comboBoxSatEnd.Visible = false;
            }
        }


        //---------------------------------------------------------------------
        // Event handler for adding a course.
        //---------------------------------------------------------------------
        private void butAddCourse_Click(object sender, EventArgs e)
        {

            Boolean valid = true;
            double coursePriority = 0;
            double courseCredit = 0;
            List<List<DateTime>> dateTimes = new List<List<DateTime>>();

            //Check that name is not empty
            if (txtCourseTitle.Text.Equals(""))
            {
                nameErrorMessageLabel.Text = "Invalid Name";
                valid = false;
            }
            //Check that credits are valid
            try
            {
                courseCredit = Double.Parse(txtCourseCredits.Text);
            }
            //user entered non-numeric value
            catch (Exception ex)
            {
                creditsErrorMessageLabel.Text = "Invalid Credits";
                valid = false;
            }
            //user entered non-numeric value
            if (courseCredit < 0)
            {
                creditsErrorMessageLabel.Text = "Invalid Credits";
                valid = false;
            }

            //Check this out

            //Check if sunday checkbox is checked
            if (checkBoxSun.Checked)
            {
                //Check that both times have values
                if (!string.IsNullOrEmpty(comboBoxSunStart.Text) && !string.IsNullOrEmpty(comboBoxSunEnd.Text))
                {
                    //check if end time is less than or equal to start time
                    if (DateTime.Parse(comboBoxSunStart.SelectedItem.ToString()) >= DateTime.Parse(comboBoxSunEnd.SelectedItem.ToString()))
                    {
                        sunErrorMessageLabel.Text = "Invalid Sunday times";
                        valid = false;
                    }
                    //times were valid
                    else
                    {
                        times.Add(DayOfWeek.Sunday, (DateTime.Parse(comboBoxSunStart.SelectedItem.ToString()), DateTime.Parse(comboBoxSunEnd.SelectedItem.ToString())));
                        List<DateTime> sunday = new List<DateTime>();
                        sunday.Add(DateTime.Parse(comboBoxSunStart.SelectedItem.ToString()));
                        sunday.Add(DateTime.Parse(comboBoxSunEnd.SelectedItem.ToString()));
                        dateTimes.Add(sunday);
                    }
                }
                //one or both times were empty
                else
                {
                    sunErrorMessageLabel.Text = "Invalid Sunday times";
                    valid = false;
                }
            }

            //Check out if Monday checkbox is checked
            if (checkBoxMon.Checked)
            {
                //Check that both times have values
                if (!string.IsNullOrEmpty(comboBoxMonStart.Text) && !string.IsNullOrEmpty(comboBoxMonEnd.Text))
                {
                    //check if end time is less than or equal to start time
                    if (DateTime.Parse(comboBoxMonStart.SelectedItem.ToString()) >= DateTime.Parse(comboBoxMonEnd.SelectedItem.ToString()))
                    {
                        monErrorMessageLabel.Text = "Invalid Monday times";
                        valid = false;
                    }
                    //times were valid
                    else
                    {
                        times.Add(DayOfWeek.Monday, (DateTime.Parse(comboBoxMonStart.SelectedItem.ToString()), DateTime.Parse(comboBoxMonEnd.SelectedItem.ToString())));

                        List<DateTime> monday = new List<DateTime>();
                        monday.Add(DateTime.Parse(comboBoxMonStart.SelectedItem.ToString()));
                        monday.Add(DateTime.Parse(comboBoxMonEnd.SelectedItem.ToString()));
                        dateTimes.Add(monday);
                    }
                }
                //one or both times were empty
                else
                {
                    monErrorMessageLabel.Text = "Invalid Monday times";
                    valid = false;
                }
            }

            //Check out if Tuesday checkbox is checked
            if (checkBoxTue.Checked)
            {
                //Check that both times have values
                if (!string.IsNullOrEmpty(comboBoxTueStart.Text) && !string.IsNullOrEmpty(comboBoxTueEnd.Text))
                {
                    //check if end time is less than or equal to start time
                    if (DateTime.Parse(comboBoxTueStart.SelectedItem.ToString()) >= DateTime.Parse(comboBoxTueEnd.SelectedItem.ToString()))
                    {
                        tueErrorMessageLabel.Text = "Invalid Tuesday times";
                        valid = false;
                    }
                    //times were valid
                    else
                    {
                        times.Add(DayOfWeek.Tuesday, (DateTime.Parse(comboBoxTueStart.SelectedItem.ToString()), DateTime.Parse(comboBoxTueEnd.SelectedItem.ToString())));
                        
                        List<DateTime> tuesday = new List<DateTime>();
                        tuesday.Add(DateTime.Parse(comboBoxTueStart.SelectedItem.ToString()));
                        tuesday.Add(DateTime.Parse(comboBoxTueEnd.SelectedItem.ToString()));
                        dateTimes.Add(tuesday);
                    }
                }
                //one or both times were empty
                else
                {
                    tueErrorMessageLabel.Text = "Invalid Tuesday times";
                    valid = false;
                }
            }

            //Check out if Wednesday checkbox is checked
            if (checkBoxWed.Checked)
            {
                //Check that both times have values
                if (!string.IsNullOrEmpty(comboBoxWedStart.Text) && !string.IsNullOrEmpty(comboBoxWedEnd.Text))
                {
                    //check if end time is less than or equal to start time
                    if (DateTime.Parse(comboBoxWedStart.SelectedItem.ToString()) >= DateTime.Parse(comboBoxWedEnd.SelectedItem.ToString()))
                    {
                        wedErrorMessageLabel.Text = "Invalid Wednesday times";
                        valid = false;
                    }
                    //times were valid
                    else
                    {
                        times.Add(DayOfWeek.Wednesday, (DateTime.Parse(comboBoxWedStart.SelectedItem.ToString()), DateTime.Parse(comboBoxWedEnd.SelectedItem.ToString())));

                        List<DateTime> wednesday = new List<DateTime>();
                        wednesday.Add(DateTime.Parse(comboBoxWedStart.SelectedItem.ToString()));
                        wednesday.Add(DateTime.Parse(comboBoxWedEnd.SelectedItem.ToString()));
                        dateTimes.Add(wednesday);
                    }
                }
                //one or both times were empty
                else
                {
                    wedErrorMessageLabel.Text = "Invalid Wednesday times";
                    valid = false;
                }
            }

            //Check out if Thursday checkbox is checked
            if (checkBoxThu.Checked)
            {
                //Check that both times have values
                if (!string.IsNullOrEmpty(comboBoxThuStart.Text) && !string.IsNullOrEmpty(comboBoxThuEnd.Text))
                {
                    //check if end time is less than or equal to start time
                    if (DateTime.Parse(comboBoxThuStart.SelectedItem.ToString()) >= DateTime.Parse(comboBoxThuEnd.SelectedItem.ToString()))
                    {
                        thuErrorMessageLabel.Text = "Invalid Thursday times";
                        valid = false;
                    }
                    //times were valid
                    else
                    {
                        times.Add(DayOfWeek.Thursday, (DateTime.Parse(comboBoxThuStart.SelectedItem.ToString()), DateTime.Parse(comboBoxThuEnd.SelectedItem.ToString())));
                        
                        List<DateTime> thursday = new List<DateTime>();
                        thursday.Add(DateTime.Parse(comboBoxThuStart.SelectedItem.ToString()));
                        thursday.Add(DateTime.Parse(comboBoxThuEnd.SelectedItem.ToString()));
                        dateTimes.Add(thursday);
                    }
                }
                //one or both times were empty
                else
                {
                    thuErrorMessageLabel.Text = "Invalid Thursday times";
                    valid = false;
                }
            }

            //Check out if Friday checkbox is checked
            if (checkBoxFri.Checked)
            {
                //Check that both times have values
                if (!string.IsNullOrEmpty(comboBoxFriStart.Text) && !string.IsNullOrEmpty(comboBoxFriEnd.Text))
                {
                    //check if end time is less than or equal to start time
                    if (DateTime.Parse(comboBoxFriStart.SelectedItem.ToString()) >= DateTime.Parse(comboBoxFriEnd.SelectedItem.ToString()))
                    {
                        friErrorMessageLabel.Text = "Invalid Friday times";
                        valid = false;
                    }
                    //times were valid
                    else
                    {
                        times.Add(DayOfWeek.Friday, (DateTime.Parse(comboBoxFriStart.SelectedItem.ToString()), DateTime.Parse(comboBoxFriEnd.SelectedItem.ToString())));

                        List<DateTime> friday = new List<DateTime>();
                        friday.Add(DateTime.Parse(comboBoxFriStart.SelectedItem.ToString()));
                        friday.Add(DateTime.Parse(comboBoxFriEnd.SelectedItem.ToString()));
                        dateTimes.Add(friday);
                    }
                }
                //one or both times were empty
                else
                {
                    friErrorMessageLabel.Text = "Invalid Friday times";
                    valid = false;
                }
            }

            //Check out if Saturday checkbox is checked
            if (checkBoxSat.Checked)
            {
                //Check that both times have values
                if (!string.IsNullOrEmpty(comboBoxSatStart.Text) && !string.IsNullOrEmpty(comboBoxSatEnd.Text))
                {
                    //check if end time is less than or equal to start time
                    if (DateTime.Parse(comboBoxSatStart.SelectedItem.ToString()) >= DateTime.Parse(comboBoxSatEnd.SelectedItem.ToString()))
                    {
                        satErrorMessageLabel.Text = "Invalid Saturday times";
                        valid = false;
                    }
                    //times were valid
                    else
                    {
                        times.Add(DayOfWeek.Saturday, (DateTime.Parse(comboBoxSatStart.SelectedItem.ToString()), DateTime.Parse(comboBoxSatEnd.SelectedItem.ToString())));

                        List<DateTime> saturday = new List<DateTime>();
                        saturday.Add(DateTime.Parse(comboBoxSatStart.SelectedItem.ToString()));
                        saturday.Add(DateTime.Parse(comboBoxSatEnd.SelectedItem.ToString()));
                        dateTimes.Add(saturday);
                    }
                }
                //one or both times were empty
                else
                {
                    satErrorMessageLabel.Text = "Invalid Saturday times";
                    valid = false;
                }
            }

            //All the checkboxes checked out
            if (valid)
            {
                //Create a temporary course schedule
                string courseName = txtCourseTitle.Text;
                CourseSchedule course1 = new CourseSchedule(times);

                //Check if there are time conflicts with other courses
                Boolean validTimes = AccountController.scheduleCheck(course1, courseName);

                //No conflicts
                if (validTimes)
                {
                    //Add course
                    Course course = new CourseBuilder().WithName(txtCourseTitle.Text).WithCode(txtCourseCode.Text).WithCredits(courseCredit).WithPriority(coursePriority).WithSchedule(new CourseSchedule(times)).Build();
                    AccountController.account.addCourse(course);
                    AccountController.account.database.addTimesCourse(times, course.name);

                    //Inform user and reset control
                    successLabel.Text = "Succesfully added " + course.name;
                    Clear();
                    times = new Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)>();
                    this.StatusUpdated(sender, new EventArgs());
                }
                //There are conflicts
                else
                {
                    //Inform user
                    successLabel.ForeColor = Color.Red;
                    successLabel.Text = "Course cannot be at the same time as another course.";
                    times = new Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)>();
                    this.StatusUpdated(sender, new EventArgs());
                }
            }
        }

        //---------------------------------------------------------------------
        // Clears the form's data after a course is successfully edited.
        //---------------------------------------------------------------------
        public void Clear()
        {
            txtCourseCode.Text = "";
            txtCourseCredits.Text = "";
            txtCourseTitle.Text = "";
            nameErrorMessageLabel.Text = "";
            CodeErrorMessageLabel.Text = "";
            creditsErrorMessageLabel.Text = "";
            sunErrorMessageLabel.Text = "";
            monErrorMessageLabel.Text = "";
            tueErrorMessageLabel.Text = "";
            wedErrorMessageLabel.Text = "";
            thuErrorMessageLabel.Text = "";
            friErrorMessageLabel.Text = "";
            satErrorMessageLabel.Text = "";
            successLabel.Text = "";
            successLabel.ForeColor = Color.White;
            checkBoxSun.Checked = false;
            checkBoxMon.Checked = false;
            checkBoxTue.Checked = false;
            checkBoxWed.Checked = false;
            checkBoxThu.Checked = false;
            checkBoxFri.Checked = false;
            checkBoxSat.Checked = false;

        }
    }
}
