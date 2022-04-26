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
    public partial class UserCourseList : UserControl
    {
        private List<Course> courses;
        public Course currentCourse;

        public EventHandler StatusUpdated;
        public UserCourseList()
        {
            //Get courses from account
            //For whatever reason, the winform designer throws a hissy fit over this line of code, even though it runs perfectly fine.
            //Comment it out to make the designer work. 
            courses = new List<Course>();
            LoadCourses();
            //Current course defaults to first in list
            if (courses.Count > 0)
                currentCourse = courses[0];
            //Placeholder course in case none exists
            else
                currentCourse = new Course();
            InitializeComponent();
        }

        public void LoadCourses()
        {
            courses = AccountController.account.courses;
        }

        public Button createCourseButton(Course course, int locationindex, int red, int green, int blue)
        {
            Button button = new Button();
            //IMPORTANT- for purpose of changing current course, course name is stored in button text.
            //Seems hackish, but I don't know a better way of passing this info to a dynamically generated event handler
            //Sue me.
            button.Text = course.name;
            button.Name = course.name + "Btn";
            button.BackColor = Color.FromArgb(red, green, blue);
            button.Location = new Point(40, locationindex);
            button.Width = 250;
            button.Height = 50;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Arial", 14);
            button.ForeColor = Color.Navy;
            button.Click += new EventHandler(this.courseButtonClick);
            return button;
        }

        //Dynamic event handler for each dynamically generated button, changes the current course
        void courseButtonClick(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            //
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].name == currentButton.Text)
                    currentCourse = courses[i];
            }
            this.StatusUpdated(this, new EventArgs());
        }

        private void UserCourseList_Load(object sender, EventArgs e)
        {
            DrawCourses();
        }

        public void UnDrawCourses()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        public void ChangePanelWidth(int width)
        {
            this.flowLayoutPanel1.Width = width;
        }

        public void DrawCourses()
        {
            int red = 235;
            int green = 131;
            int blue = 131;
            int locationindex = 25;
            //For every course the account currently has
            for (int i = 0; i < courses.Count; i++)
            {
                //Create a label for the course and add it to the parent
                Course course = courses[i];
                Button button = createCourseButton(course, locationindex, red, green, blue);
                button.Width = flowLayoutPanel1.Width - 20;
                this.flowLayoutPanel1.Controls.Add(button);

                locationindex += 27;
                if (i % 3 == 0)
                {
                    green = red;
                }
                else if (i % 3 == 1)
                {
                    red = blue;
                }
                else if (i % 3 == 2)
                {
                    blue = green;
                }
            }
        }
    }
}
