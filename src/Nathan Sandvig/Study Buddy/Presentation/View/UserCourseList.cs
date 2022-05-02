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
    // This class draws a list of the user's courses, represented as buttons
    // Note that all events are passed to the parent form to be handled.
    //---------------------------------------------------------------------
    public partial class UserCourseList : UserControl
    {
        //---------------------------------------------------------------------
        // Private Data Members : 
        // StatusUpdated : A handler created when a dynamically
        // generated button is clicked.  Is "bubbled" to the parent form for handling
        // the button click event
        //---------------------------------------------------------------------
        public EventHandler StatusUpdated { get; set; }


        //---------------------------------------------------------------------
        // Default constructor
        //---------------------------------------------------------------------
        public UserCourseList()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        // Dynamically creates a button for each course and adds to the 
        // main layout panel.
        // course : the course the button is for
        // yValue : the vertical placement of the button (important if more than
        // 1 button is in list)
        // red : the R value of the button color
        // green : the G value of the button color
        // blue : the B value of the button color
        //---------------------------------------------------------------------
        public Button createCourseButton(Course course, int yValue, int red, int green, int blue)
        {
            Button button = new Button();
            //IMPORTANT- for purpose of changing current course, course name is stored in button text.
            //This is rather "hackish", but I don't know a better way of passing this info to a
            //dynamically generated event handler.  Sue me.
            button.Text = course.name;
            button.Name = course.name + "Btn";
            button.BackColor = Color.FromArgb(red, green, blue);
            button.Location = new Point(40, yValue);
            button.Width = 250;
            button.Height = 50;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Arial", 14);
            button.ForeColor = Color.Navy;
            //Dynamically generate event handler
            button.Click += new EventHandler(this.courseButton_Click);
            return button;
        }


        //---------------------------------------------------------------------
        // Removes all elements from the Controls.
        //---------------------------------------------------------------------
        public void ClearCourseButtons()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        //---------------------------------------------------------------------
        // Sets the width of the main layout panel.  (Used to fit control to
        // parent form)
        // width : the width the panel is being set to
        //---------------------------------------------------------------------
        public void ChangePanelWidth(int width)
        {
            this.flowLayoutPanel1.Width = width;
        }

        //---------------------------------------------------------------------
        // Draws all courses
        // courses : The list of courses being drawn
        //---------------------------------------------------------------------
        public void DrawCourses(List<Course> courses)
        {
            int red = 235;
            int green = 131;
            int blue = 131;
            int yValue = 25;
            //For every course the account currently has
            for (int i = 0; i < courses.Count; i++)
            {
                //Create a label for the course and add it to the parent
                Course course = courses[i];
                Button button = createCourseButton(course, yValue, red, green, blue);
                button.Width = flowLayoutPanel1.Width - 20;
                this.flowLayoutPanel1.Controls.Add(button);

                yValue += 27;

                //Update RGB values
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

        //---------------------------------------------------------------------
        // Dynamic event handler for each dynamically generated button, changes
        // the current course
        //---------------------------------------------------------------------
        void courseButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            this.StatusUpdated(currentButton, new EventArgs());
        }
    }
}
