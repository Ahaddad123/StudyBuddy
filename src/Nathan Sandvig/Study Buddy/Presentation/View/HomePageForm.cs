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
    public partial class HomePageForm : BaseForm, IView
    {
        private HomePageFormController controller;
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

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            this.name.Text = controller.getName();
            this.gpa.Text += " " + controller.getGPA();
            int red = 235;
            int green = 131;
            int blue = 131;
            int locationindex = 25;
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
                this.panel1.Controls.Add(button);

                locationindex += 27;
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

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            FormSwitcher.OpenAddGradeForm(this, (Course)button.Tag);
        }

        private void btnViewMyInfo_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenUserInfoForm(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }
    }
}
