using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    //---------------------------------------------------------------------
    // Concrete command for undoing and redoing adding study hours.
    //---------------------------------------------------------------------
    internal class AddStudyHours : ICommand
    {
        private string course;
        private DateTime date;
        private double hours;

        //---------------------------------------------------------------------
        // Constructor for the AddStudyHours concrete command.
        // course: name of the course that the study hours are being added to.
        // date: the date the study hours were completed.
        // hours: number of hours to be added.
        //---------------------------------------------------------------------
        public AddStudyHours(string course, DateTime date, double hours)
        {
            this.course = course;
            this.date = date;
            this.hours = hours;
        }

        //---------------------------------------------------------------------
        // Adds the study hours to the course through AccountController.
        // AccountController is the receiver in this Command pattern.
        //---------------------------------------------------------------------
        public void execute()
        {
            AccountController.account.addStudyHours(course, date, hours);
        }

        //---------------------------------------------------------------------
        // Removes the study hours to the course through AccountController.
        // AccountController is the receiver in this Command pattern.
        //---------------------------------------------------------------------
        public void unexecute()
        {
            AccountController.account.removeStudyHours(course, date, hours);
        }
    }
}
