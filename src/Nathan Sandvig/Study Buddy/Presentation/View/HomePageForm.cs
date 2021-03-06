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
    //---------------------------------------------------------------------
    // Windows Form to display the home page information
    //---------------------------------------------------------------------
    public partial class HomePageForm : BaseForm, IView
    {
        private HomePageFormController controller;

        //---------------------------------------------------------------------
        // Initializes the structure of the HomePageForm
        //---------------------------------------------------------------------
        public HomePageForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.title = "Home Page";
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
            this.controller = (HomePageFormController)controller;
        }

        //---------------------------------------------------------------------
        // Event for when the HomePageForm is loaded.
        // Adds the necessary labels and buttons for each course in Account
        //---------------------------------------------------------------------
        private void HomePageForm_Load(object sender, EventArgs e)
        {
            this.name.Text = controller.getName();
            int red = 235;
            int green = 131;
            int blue = 131;
            int locationindex = 52;

            //Create labels for courses
            for (int i = 0; i < controller.getCourses().Count; i++)
            {
                Course course = controller.getCourses()[i];
                Label label = controller.createCourseLabel(course.name, locationindex, red, green, blue);
                this.panel1.Controls.Add(label);
                double hoursStudied = 0;
                DateTime today = DateTime.Today.Date;
                DateTime sunday = new DateTime(today.Year, today.Month, today.Day - (int)today.DayOfWeek);
                for(int j = 0; j < 7; j++)
                {
                    hoursStudied += course.GetHoursStudied(sunday.Date);
                    sunday = sunday.AddDays(1);
                }
                Label label2 = controller.createHoursLabel(course, hoursStudied, locationindex, red, green, blue);
                this.panel1.Controls.Add(label2);

                Button button = controller.createAddGradeButton(course, locationindex, new EventHandler(this.addGradeButton_Click));
                this.toolTip1.SetToolTip(button, "Add grade for " + label.Text);
                this.panel1.Controls.Add(button);

                locationindex += 52;
                if(i%3 == 0)
                {
                    green = red;
                } else if (i%3 == 1)
                {
                    red = blue;
                } else if (i%3 == 2)
                {
                    blue = green;
                }
            }
        }

        //---------------------------------------------------------------------
        // Event for when an add grade button is clicked.
        // Opens the AddGradeForm for the specified course.
        //---------------------------------------------------------------------
        private void addGradeButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            FormSwitcher.OpenAddGradeForm(this, (Course)button.Tag);
        }

        //---------------------------------------------------------------------
        // Event for when the view my info button is clicked.
        // Opens the UserInfoForm
        //---------------------------------------------------------------------
        private void btnViewMyInfo_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenUserInfoForm(this);
        }

        //---------------------------------------------------------------------
        // Event for when the exit button is clicked.
        // Closes the program.
        //---------------------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void viewMyInfoBtn_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenUserInfoForm(this);
        }
    }
}
