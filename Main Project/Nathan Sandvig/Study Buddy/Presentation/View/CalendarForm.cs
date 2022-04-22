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
    public partial class CalendarForm : BaseForm, IView
    {
        private CalendarFormController controller;
        public int year { get; set; }
        public string monthName { get; set; }
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
            controller.DrawCalendar();
            dateLabel.Text = monthName + " " + year;
        }

        public void DrawBlank()
        {
            Blank blank = new Blank();
            dayContainer.Controls.Add(blank);
        }

        public void DrawDay(int dayOfWeek)
        {
            DayBox dayBox;
            dayBox = new DayBox();
            if (controller.isCurrentYear() && controller.isCurrentMonth() && dayOfWeek == controller.day)
            {
                dayBox.setToday();
            }
            dayBox.days(dayOfWeek);
            dayContainer.Controls.Add(dayBox);
            //Wip add assignment due dates
            int indexOflabel = 10;
            foreach(Course c in AccountController.account.courses)
            {
                foreach(Assignment assignment in c.assignments)
                {
                    
                    if(monthName == assignment.dueDate.Month.ToString() && dayOfWeek == assignment.dueDate.Day)
                    {
                        dayBox.addDueDate(dayOfWeek, assignment.name);
                        indexOflabel += 10;
                    }
                    
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            controller.ChangeMonth(-1);
            dateLabel.Text = monthName + " " + year;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            controller.ChangeMonth(1);
            dateLabel.Text = monthName + " " + year;
        }
    }
}
