using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation.Controller
{
    internal class CalendarFormController : FormController
    {
        private int day, month, year;
        private String monthName;
        public CalendarFormController(CalendarForm form)
        {
            this.view = form;

            //Set current day, month and year
            DateTime now = DateTime.Now;
            day = now.Day;
            month = now.Month;
            year = now.Year;

            //Get month Name as string
            monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

        }

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
    }
}
