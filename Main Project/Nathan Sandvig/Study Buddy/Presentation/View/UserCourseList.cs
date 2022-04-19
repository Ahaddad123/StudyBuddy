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
        private Course currentCourse;
        public UserCourseList()
        {
            courses = AccountController.account.courses;
            InitializeComponent();
        }

        public String getName()
        {
            return AccountController.account.username;
        }

        public Button createCourseButton(Course course, int locationindex, int red, int green, int blue)
        {
            Button button = new Button();
            button.Text = course.name;
            button.Name = course.name + "Btn";
            button.BackColor = Color.FromArgb(red, green, blue);
            button.Location = new Point(40, locationindex);
            button.Width = Parent.Width;
            button.Height = 50;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Microsoft Sans Serif", 14);
            button.Click += new EventHandler(this.courseButtonClick);

            return button;
        }

        //Dynamic event handler for each dynamically generated button
        void courseButtonClick(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            MessageBox.Show(currentButton.Name.ToString());
        }

        private void UserCourseList_Load(object sender, EventArgs e)
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
