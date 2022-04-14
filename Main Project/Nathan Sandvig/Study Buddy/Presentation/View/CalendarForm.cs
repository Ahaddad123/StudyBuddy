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

namespace Study_Buddy.Presentation
{
    public partial class CalendarForm : BaseForm, IView
    {
        private CalendarFormController controller;
        public CalendarForm()
        {
            InitializeComponent();
            this.title = "Calendar";
            this.Text = title;
            this.mainHeader.Text = title;
            this.nav1.SetCurrentForm(this);
        }

        public void SetController(FormController controller)
        {
            this.controller = (CalendarFormController)controller;
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;

            //get first day of month
            DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);

            //get count of days in month
            int days = DateTime.DaysInMonth(now.Year, now.Month);

            //convert startOfMonth to integer
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));

            //Fill in blanks for the week up until first day of month
            for (int i = 0; i < dayOfTheWeek; i++)
            {
                Blank blank = new Blank();
                dayContainer.Controls.Add(blank);
            }

            for (int i = 1; i <= days; i++)
            {
                DayBox dayBox = new DayBox();
                dayBox.days(i);
                dayContainer.Controls.Add(dayBox);
            }


        }
    }
}
