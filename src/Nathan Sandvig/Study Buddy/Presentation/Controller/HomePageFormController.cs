using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.DataAccess;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // Controls the HomePageForm
    //---------------------------------------------------------------------
    internal class HomePageFormController : FormController
    {
        //---------------------------------------------------------------------
        // Constructor that sets the view to the HomePageForm
        //---------------------------------------------------------------------
        public HomePageFormController(HomePageForm form)
        {
            this.view = form;
            view.SetController(this);
        }

        //---------------------------------------------------------------------
        // Gets the list of courses from the Account
        // return: list of courses
        //---------------------------------------------------------------------
        public List<Course> getCourses()
        {
            return AccountController.account.courses;
        }

        //---------------------------------------------------------------------
        // Gets the student name from the Account
        // return: student name
        //---------------------------------------------------------------------
        public String getName()
        {
            List<String> info = AccountController.account.database.readStudentInfo();
            return info[0] + " " + info[1];
        }

        //---------------------------------------------------------------------
        // Gets the overall student gpa from the Account
        // return: overall student gpa
        //---------------------------------------------------------------------
        public String getGPA()
        {
            return AccountController.account.database.readStudentInfo()[2];
        }

        public Label CreateMainCoursesLabel(int locationindex)
        {
            Label label = new Label();
            label.Text = "Your study hours this week";
            label.BackColor = Color.RoyalBlue;
            label.ForeColor = Color.White;
            label.Location = new Point(40, locationindex);
            label.Size = new Size(502, 50);
            label.Font = new Font("Arial", 16);
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }


        //---------------------------------------------------------------------
        // Creates the label with the course name on the HomePageForm
        // courseName: name of the course to be shown on the label
        // locationindex: y index of the label on the form
        // red: red value in the RGB color to set the background of the label to
        // green: green value in the RGB color to set the background of the label to
        // blue: blue value in the RGB color to set the background of the label to
        //---------------------------------------------------------------------
        public Label createCourseLabel(String courseName, int locationindex, int red, int green, int blue)
        {
            Label label = new Label();
            label.Text = courseName;
            label.BackColor = Color.FromArgb(red, green, blue);
            label.ForeColor = Color.Navy;
            label.Location = new Point(0, locationindex);
            label.Size = new Size(250, 50);
            label.Font = new Font("Arial", 13);
            label.TextAlign = ContentAlignment.MiddleLeft;
            return label;
        }

        //---------------------------------------------------------------------
        // Creates the label with the number of hours studied and study goal
        //      that week for a course
        // course: course to get the study goal from
        // hoursStudied: number of hours studied in a week for a course
        // locationindex: y index of the label on the form
        // red: red value in the RGB color to set the background of the label to
        // green: green value in the RGB color to set the background of the label to
        // blue: blue value in the RGB color to set the background of the label to
        //---------------------------------------------------------------------
        public Label createHoursLabel(Course course, double hoursStudied, int locationindex, int red, int green, int blue)
        {
            Label label = new Label();
            double studyGoal = Math.Round(Algorithm.HoursForGrade(course, 95), 2);
            label.Text = hoursStudied + "/" + studyGoal;
            label.BackColor = Color.FromArgb(red, green, blue);
            label.ForeColor = Color.Navy;
            label.Location = new Point(250, locationindex);
            label.Size = new Size(250, 50);
            label.Font = new Font("Arial", 13);
            label.TextAlign = ContentAlignment.MiddleRight;
            return label;
        }

        //---------------------------------------------------------------------
        // Creates the button to add a grade to a course on the HomePageForm
        // course : course the button is for
        // locationindex: y index of the button on the form
        // eventHandler: event to add to the button to go to correct AddGradeForm
        //---------------------------------------------------------------------
        public Button createAddGradeButton(Course course, int locationindex, EventHandler eventHandler)
        {
            Button button = new Button();
            button.BackColor = Color.White;
            button.ForeColor = Color.RoyalBlue;
            button.Location = new Point(502, locationindex);
            button.Size = new Size(150, 50);
            button.Text = "+";
            button.Font = new Font("Arial", 20);
            button.Click += eventHandler;
            button.Tag = course;
            button.Margin = new Padding(0);
            button.FlatStyle = FlatStyle.Flat;
            return button;
        }
    }
}
