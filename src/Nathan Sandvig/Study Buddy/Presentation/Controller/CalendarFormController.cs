using Study_Buddy.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation.Controller
{
    //---------------------------------------------------------------------
    // This class controls a calendar form.
    //---------------------------------------------------------------------
    internal class CalendarFormController : FormController
    {
        //---------------------------------------------------------------------
        // Variables to be used for controller
        // day: current day being displayed on calender
        // month: current month being displayed on calender
        // year: current year being displayed on calender
        // monthName: Name of the current month on calendar
        // courses: courses of the current acount
        //---------------------------------------------------------------------
        public int day { get; set; }   
        public int month { get; set; }
        private int year { get; set; }
        private String monthName;
        public List<Course> courses { get; set; } = new List<Course>();

        //---------------------------------------------------------------------
        // Parameraterized constructer for controller
        // form: current form of calender
        //---------------------------------------------------------------------
        public CalendarFormController(CalendarForm form)
        {
            this.view = form;

            //Set current day, month and year
            DateTime now = DateTime.Now;
            day = now.Day;
            month = now.Month;
            year = now.Year;

            //Set the courses
            foreach(Course c in AccountController.account.courses)
            {
                courses.Add(c);
            }

            //Get month Name as string
            monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
        }

        //---------------------------------------------------------------------
        // Draws the calender of the current month
        //---------------------------------------------------------------------
        public void DrawCalendar()
        {

            //Get month Name as string
            monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            ((CalendarForm)view).monthName = monthName;
            ((CalendarForm)view).year = year;

            //get first day of month
            DateTime startOfMonth = new DateTime(year, month, 1);

            //get count of days in month
            int days = DateTime.DaysInMonth(year, month);

            //convert startOfMonth to integer
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));

            //Fill in blanks for the week up until first day of month
            for (int i = 0; i < dayOfTheWeek; i++)
            {
                ((CalendarForm)view).DrawBlank();
            }

            for (int i = 1; i <= days; i++)
            {
                ((CalendarForm)view).DrawDay(i);
            }
        }

        //---------------------------------------------------------------------
        // changes the value of month with the parameter given
        // change: value that will be used to change month
        //---------------------------------------------------------------------
        public void ChangeMonth(int change)
        {
            month = month + change;
            //If decrementing from January, set month to December and decrement year
            if (month == 0)
            {
                month = 12;
                year--;
            }

            //If incrementing from December, set month to January and increment year
            else if (month == 13)
            {
                month = 1;
                year++;
            }
            DrawCalendar();
        }


        //---------------------------------------------------------------------
        // Checks to see if the value of month is the same as todays month
        //---------------------------------------------------------------------
        public bool isCurrentMonth()
        {
            if (DateTime.Now.Month == month)
            {
                return true;
            }
            return false;
        }

        //---------------------------------------------------------------------
        // checks to see if the value of year is the same a todays year
        //---------------------------------------------------------------------
        public bool isCurrentYear()
        {
            if (DateTime.Now.Year == year)
            {
                return true;
            }
            return false;
        }
    }
}
