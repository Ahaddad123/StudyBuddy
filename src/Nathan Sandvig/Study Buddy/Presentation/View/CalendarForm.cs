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
using Study_Buddy.Presentation.Controller;
using System.Globalization;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // This class represents the view of a calendar of the user's events.
    //---------------------------------------------------------------------
    public partial class CalendarForm : BaseForm, IView
    {
        //---------------------------------------------------------------------
        // Private data members :
        // controller : the form's controller
        //
        // Properties:
        // year : the current year being displayed
        // monthName : string representation of the current month being displayed.
        //---------------------------------------------------------------------
        private CalendarFormController controller;
        public int year { get; set; }
        public string monthName { get; set; }

        //---------------------------------------------------------------------
        // Default constructor
        //---------------------------------------------------------------------
        public CalendarForm()
        {
            InitializeComponent();
            this.title = "Calendar";
            this.Text = title;
            this.mainHeader.Text = title;
            this.nav1.SetCurrentForm(this);
        }

        //---------------------------------------------------------------------
        // sets the controller to the parameter
        //---------------------------------------------------------------------
        public void SetController(FormController controller)
        {
            this.controller = (CalendarFormController)controller;
        }

        //---------------------------------------------------------------------
        // Event handler for the form's load event.  Displays the calendar and 
        // date information.
        //---------------------------------------------------------------------
        private void CalendarForm_Load(object sender, EventArgs e)
        {
            controller.DrawCalendar();
            dateLabel.Text = monthName + " " + year;
        }

        //---------------------------------------------------------------------
        // Draws a box representing a blank day of week if not in the current month.
        // Also describes what I do when called on in class.
        //---------------------------------------------------------------------
        public void DrawBlank()
        {
            Blank blank = new Blank();
            dayContainer.Controls.Add(blank);
        }

        //---------------------------------------------------------------------
        // Draws a box representing a day of the week if in the current month.
        // dayOfWeek : integer value representing day of week 
        //---------------------------------------------------------------------
        public void DrawDay(int dayOfWeek)
        {
            //Instantiate new DayBox
            DayBox dayBox;
            dayBox = new DayBox();

            //Draw day with inverted colors to highlight the current day
            if (controller.isCurrentYear() && controller.isCurrentMonth() && dayOfWeek == controller.day)
            {
                dayBox.setToday();
            }
            //Set the day of week
            dayBox.Days(dayOfWeek);

            //Handle creation of assignemnt labels
            int yValue = 13;
            foreach (Course c in controller.courses)
            {
                foreach (Assignment assignment in c.assignments)
                {

                    if (controller.month == assignment.dueDate.Month && dayOfWeek == assignment.dueDate.Day)
                    {
                        Color color = Color.Navy;
                        if (assignment.dueDate.Day.Equals(DateTime.Today.Day))
                        {
                            color = Color.White;
                        }
                        Label label = dayBox.AddDueDate(yValue, assignment.name, color);
                        dayBox.Controls.Add(label);
                        yValue += 15;
                    }

                }
            }
            //Add the day to the calendar
            dayContainer.Controls.Add(dayBox);
        }

        //---------------------------------------------------------------------
        // Handles "<-" button click.  Displays previous month.
        //---------------------------------------------------------------------
        private void btnPrev_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            controller.ChangeMonth(-1);
            dateLabel.Text = monthName + " " + year;
        }

        //---------------------------------------------------------------------
        // Handles "->" button click.  Displays next month.
        //---------------------------------------------------------------------
        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            controller.ChangeMonth(1);
            dateLabel.Text = monthName + " " + year;
        }
    }
}
