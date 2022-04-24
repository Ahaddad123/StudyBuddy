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
    public partial class AddCourseBox : UserControl
    {
        public AddCourseBox()
        {
            InitializeComponent();
            /*comboBoxMonStart.Items.AddRange(new Object[] { });
            comboBoxMonEnd.Items.AddRange(new Object[] { });
            comboBoxTueStart.Items.AddRange(new Object[] { });
            comboBoxTueEnd.Items.AddRange(new Object[] { });
            comboBoxWedStart.Items.AddRange(new Object[] { });
            comboBoxWedEnd.Items.AddRange(new Object[] { });
            comboBoxThuStart.Items.AddRange(new Object[] { });
            comboBoxThuEnd.Items.AddRange(new Object[] { });
            comboBoxFriStart.Items.AddRange(new Object[] { });
            comboBoxFriEnd.Items.AddRange(new Object[] { });
            comboBoxSatStart.Items.AddRange(new Object[] { });
            comboBoxSatEnd.Items.AddRange(new Object[] { });
            comboBoxSunStart.Items.AddRange(new Object[] { });
            comboBoxSunEnd.Items.AddRange(new Object[] { });*/

            TimeSpan startingTime = new TimeSpan(0, 0, 0);
            DateTime startingDate = new DateTime(DateTime.MinValue.Ticks);

            for (int x = 0; x < 48; x++)
            {
                int mins = 30 * x;
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

        private void checkBoxSun_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSun.Checked)
            {
                comboBoxSunStart.Visible = true;
                comboBoxSunEnd.Visible = true;
            }
            else
            {
                comboBoxSunStart.SelectedItem = null;
                comboBoxSunEnd.SelectedItem = null;
                comboBoxSunStart.Visible = false;
                comboBoxSunEnd.Visible = false;
            }
        }
        private void checkBoxMon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMon.Checked)
            {
                comboBoxMonStart.Visible = true;
                comboBoxMonEnd.Visible = true;
            }
            else
            {
                comboBoxMonStart.SelectedItem = null;
                comboBoxMonEnd.SelectedItem = null;
                comboBoxMonStart.Visible = false;
                comboBoxMonEnd.Visible = false;
            }
        }

        private void checkBoxTue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTue.Checked)
            {
                comboBoxTueStart.Visible = true;
                comboBoxTueEnd.Visible = true;
            }
            else
            {
                comboBoxTueStart.SelectedItem = null;
                comboBoxTueEnd.SelectedItem = null;
                comboBoxTueStart.Visible = false;
                comboBoxTueEnd.Visible = false;
            }
        }

        private void checkBoxWed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWed.Checked)
            {
                comboBoxWedStart.Visible = true;
                comboBoxWedEnd.Visible = true;
            }
            else
            {
                comboBoxWedStart.SelectedItem = null;
                comboBoxWedEnd.SelectedItem = null;
                comboBoxWedStart.Visible = false;
                comboBoxWedEnd.Visible = false;
            }
        }

        private void checkBoxThu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxThu.Checked)
            {
                comboBoxThuStart.Visible = true;
                comboBoxThuEnd.Visible = true;
            }
            else
            {
                comboBoxThuStart.SelectedItem = null;
                comboBoxThuEnd.SelectedItem = null;
                comboBoxThuStart.Visible = false;
                comboBoxThuEnd.Visible = false;
            }
        }

        private void checkBoxFri_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFri.Checked)
            {
                comboBoxFriStart.Visible = true;
                comboBoxFriEnd.Visible = true;
            }
            else
            {
                comboBoxFriStart.SelectedItem = null;
                comboBoxFriEnd.SelectedItem = null;
                comboBoxFriStart.Visible = false;
                comboBoxFriEnd.Visible = false;
            }
        }

        private void checkBoxSat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSat.Checked)
            {
                comboBoxSatStart.Visible = true;
                comboBoxSatEnd.Visible = true;
            }
            else
            {
                comboBoxSatStart.SelectedItem = null;
                comboBoxSatEnd.SelectedItem = null;
                comboBoxSatStart.Visible = false;
                comboBoxSatEnd.Visible = false;
            }
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

            //Check this out

            //Check if sunday checkbox is checked
            if (checkBoxSun.Checked)
            {
                //If sunday times have values
                if (!string.IsNullOrEmpty(comboBoxSunStart.Text) && !string.IsNullOrEmpty(comboBoxSunEnd.Text))
                {
                                  
                    //add course times for Sunday
                    if (DateTime.Parse(comboBoxSunStart.SelectedItem.ToString()) > DateTime.Parse(comboBoxSunEnd.SelectedItem.ToString()))
                    {
                        sunErrorMessageLabel.Text = "Invalid Sunday times";
                        valid = false;
                    }
                    else
                    {
                        List<DateTime> sunday = new List<DateTime>();
                        sunday.Add(DateTime.Parse(comboBoxSunStart.SelectedItem.ToString()));
                        sunday.Add(DateTime.Parse(comboBoxSunEnd.SelectedItem.ToString()));
                        dateTimes.Add(sunday);
                    }  
                }
                else
                {
                    sunErrorMessageLabel.Text = "Invalid Sunday times";
                }
            }

            //Check out if Monday checkbox is checked
            if (checkBoxMon.Checked)
            {
                //If sunday times have values
                if (!string.IsNullOrEmpty(comboBoxMonStart.Text) && !string.IsNullOrEmpty(comboBoxMonEnd.Text))
                {

                    //add course times for Sunday
                    if (DateTime.Parse(comboBoxMonStart.SelectedItem.ToString()) > DateTime.Parse(comboBoxMonEnd.SelectedItem.ToString()))
                    {
                        monErrorMessageLabel.Text = "Invalid Monday times";
                        valid = false;
                    }
                    else
                    {
                        List<DateTime> monday = new List<DateTime>();
                        monday.Add(DateTime.Parse(comboBoxMonStart.SelectedItem.ToString()));
                        monday.Add(DateTime.Parse(comboBoxMonEnd.SelectedItem.ToString()));
                        dateTimes.Add(monday);
                    }
                }
                else
                {
                    monErrorMessageLabel.Text = "Invalid Monday times";
                }
            }

            //Check out if Tuesday checkbox is checked
            if (checkBoxTue.Checked)
            {
                //If sunday times have values
                if (!string.IsNullOrEmpty(comboBoxTueStart.Text) && !string.IsNullOrEmpty(comboBoxTueEnd.Text))
                {

                    //add course times for Sunday
                    if (DateTime.Parse(comboBoxTueStart.SelectedItem.ToString()) > DateTime.Parse(comboBoxTueEnd.SelectedItem.ToString()))
                    {
                        tueErrorMessageLabel.Text = "Invalid Tuesday times";
                        valid = false;
                    }
                    else
                    {
                        List<DateTime> tuesday = new List<DateTime>();
                        tuesday.Add(DateTime.Parse(comboBoxTueStart.SelectedItem.ToString()));
                        tuesday.Add(DateTime.Parse(comboBoxTueEnd.SelectedItem.ToString()));
                        dateTimes.Add(tuesday);
                    }
                }
                else
                {
                    tueErrorMessageLabel.Text = "Invalid Tuesday times";
                }
            }

            //Check out if Wednesday checkbox is checked
            if (checkBoxWed.Checked)
            {
                //If sunday times have values
                if (!string.IsNullOrEmpty(comboBoxWedStart.Text) && !string.IsNullOrEmpty(comboBoxWedEnd.Text))
                {

                    //add course times for Sunday
                    if (DateTime.Parse(comboBoxWedStart.SelectedItem.ToString()) > DateTime.Parse(comboBoxWedEnd.SelectedItem.ToString()))
                    {
                        wedErrorMessageLabel.Text = "Invalid Wednesday times";
                        valid = false;
                    }
                    else
                    {
                        List<DateTime> wednesday = new List<DateTime>();
                        wednesday.Add(DateTime.Parse(comboBoxWedStart.SelectedItem.ToString()));
                        wednesday.Add(DateTime.Parse(comboBoxWedEnd.SelectedItem.ToString()));
                        dateTimes.Add(wednesday);
                    }
                }
                else
                {
                    wedErrorMessageLabel.Text = "Invalid Wednesday times";
                }
            }

            //Check out if Thursday checkbox is checked
            if (checkBoxThu.Checked)
            {
                //If sunday times have values
                if (!string.IsNullOrEmpty(comboBoxThuStart.Text) && !string.IsNullOrEmpty(comboBoxThuEnd.Text))
                {

                    //add course times for Sunday
                    if (DateTime.Parse(comboBoxThuStart.SelectedItem.ToString()) > DateTime.Parse(comboBoxThuEnd.SelectedItem.ToString()))
                    {
                        thuErrorMessageLabel.Text = "Invalid Thursday times";
                        valid = false;
                    }
                    else
                    {
                        List<DateTime> thursday = new List<DateTime>();
                        thursday.Add(DateTime.Parse(comboBoxThuStart.SelectedItem.ToString()));
                        thursday.Add(DateTime.Parse(comboBoxThuEnd.SelectedItem.ToString()));
                        dateTimes.Add(thursday);
                    }
                }
                else
                {
                    thuErrorMessageLabel.Text = "Invalid Thursday times";
                }
            }

            //Check out if Friday checkbox is checked
            if (checkBoxFri.Checked)
            {
                //If sunday times have values
                if (!string.IsNullOrEmpty(comboBoxFriStart.Text) && !string.IsNullOrEmpty(comboBoxFriEnd.Text))
                {

                    //add course times for Sunday
                    if (DateTime.Parse(comboBoxFriStart.SelectedItem.ToString()) > DateTime.Parse(comboBoxFriEnd.SelectedItem.ToString()))
                    {
                        friErrorMessageLabel.Text = "Invalid Friday times";
                        valid = false;
                    }
                    else
                    {
                        List<DateTime> friday = new List<DateTime>();
                        friday.Add(DateTime.Parse(comboBoxFriStart.SelectedItem.ToString()));
                        friday.Add(DateTime.Parse(comboBoxFriEnd.SelectedItem.ToString()));
                        dateTimes.Add(friday);
                    }
                }
                else
                {
                    friErrorMessageLabel.Text = "Invalid Friday times";
                }
            }

            //Check out if Saturday checkbox is checked
            if (checkBoxSat.Checked)
            {
                //If sunday times have values
                if (!string.IsNullOrEmpty(comboBoxSatStart.Text) && !string.IsNullOrEmpty(comboBoxSatEnd.Text))
                {

                    //add course times for Sunday
                    if (DateTime.Parse(comboBoxSatStart.SelectedItem.ToString()) > DateTime.Parse(comboBoxSatEnd.SelectedItem.ToString()))
                    {
                        satErrorMessageLabel.Text = "Invalid Saturday times";
                        valid = false;
                    }
                    else
                    {
                        List<DateTime> saturday = new List<DateTime>();
                        saturday.Add(DateTime.Parse(comboBoxSatStart.SelectedItem.ToString()));
                        saturday.Add(DateTime.Parse(comboBoxSatEnd.SelectedItem.ToString()));
                        dateTimes.Add(saturday);
                    }
                }
                else
                {
                    satErrorMessageLabel.Text = "Invalid Saturday times";
                }
            }

            //All the checkboxes checked out
            if (valid)
            {
                Course course = new CourseBuilder().WithName(txtCourseTitle.Text).WithCode(txtCourseCode.Text).WithCredits(courseCredit).WithPriority(coursePriority).WithCourseHours(dateTimes).Build();
                AccountController.account.addCourse(course);
                nameErrorMessageLabel.Text = "";
                CodeErrorMessageLabel.Text = "";
                PriorityErrorMessageLabel.Text = "";
                creditsErrorMessageLabel.Text = "";
                sunErrorMessageLabel.Text = "";
                monErrorMessageLabel.Text = "";
                tueErrorMessageLabel.Text = "";
                wedErrorMessageLabel.Text = "";
                thuErrorMessageLabel.Text = "";
                friErrorMessageLabel.Text = "";
                satErrorMessageLabel.Text = "";
                checkBoxSun.Checked = false;
                checkBoxMon.Checked = false;
                checkBoxTue.Checked = false;
                checkBoxWed.Checked = false;
                checkBoxThu.Checked = false;
                checkBoxFri.Checked = false;
                checkBoxSat.Checked = false;
                successLabel.Text = "Succesfully added " + course.name;
            }
        }
    }
}
