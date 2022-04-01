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
            this.mainPanel.MaximumSize = new System.Drawing.Size(1080, 720);
            this.mainPanel.Size = new System.Drawing.Size(1080, 720);
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
            Account account = AccountController.account;
            this.name.Text = account.username;
            //this.gpa.Text = account.gpa;
            int red = 235;
            int green = 131;
            int blue = 131;
            int locationindex = 180;
            for (int i = 0; i < account.courses.Count; i++)
            {
                //Course course = controller.getCourses()[i];
                Course course = account.courses[i];
                Label label = new Label();
                label.Text = course.name;
                label.BackColor = Color.FromArgb(red, green, blue);
                label.Location = new Point(40, locationindex);
                label.Size = new Size(250, 25);
                label.Font = new Font("Microsoft Sans Serif", 13);
                this.mainPanel.Controls.Add(label);
                double hoursStudied = 0;
                for (int j = 0; j <= (int)DateTime.Today.DayOfWeek; j++)
                {
                    hoursStudied += course.GetHoursStudied(j, 0);
                }
                Label label2 = new Label();
                label2.Text = hoursStudied + "/" + "study goal";
                label2.BackColor = Color.FromArgb(red, green, blue);
                label2.Location = new Point(290, locationindex);
                label2.Size = new Size(250, 25);
                label2.Font = new Font("Microsoft Sans Serif", 13);
                label2.TextAlign = ContentAlignment.TopRight;
                this.mainPanel.Controls.Add(label2);

                Button button = new Button();
                button.BackColor = Color.LightGray;
                button.Location = new Point(550, locationindex);
                button.Size = new Size(200, 25);
                button.Text = "Add grade for this course";
                button.Font = new Font("Microsoft Sans Serif", 10);
                button.Click += new EventHandler(this.addGradeButton_Click);
                button.Tag = course;
                button.Margin = new Padding(0);
                this.mainPanel.Controls.Add(button);

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
    }
}
