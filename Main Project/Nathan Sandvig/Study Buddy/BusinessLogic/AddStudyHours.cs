using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    internal class AddStudyHours : ICommand
    {
        private string course;
        private DateTime date;
        private double hours;

        public AddStudyHours(string course, DateTime date, double hours)
        {
            this.course = course;
            this.date = date;
            this.hours = hours;
        }

        public void execute()
        {
            AccountController.account.addStudyHours(course, date, hours);
        }

        public void unexecute()
        {
            AccountController.account.removeStudyHours(course, date, hours);
        }
    }
}
