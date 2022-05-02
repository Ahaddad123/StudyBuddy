using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    //---------------------------------------------------------------------
    // Concrete command for undoing and redoing adding a grade.
    //---------------------------------------------------------------------
    internal class AddGrade : ICommand
    {
        private string course;
        private string assignment;
        private double grade;

        //---------------------------------------------------------------------
        // Constructor for the AddGrade concrete command.
        // course: name of the course that the grade is being added to.
        // assignment: name of the assignment that the grade is being added to.
        // grade: grade to be added.
        //---------------------------------------------------------------------
        public AddGrade(string course, string assignment, double grade)
        {
            this.course = course;
            this.assignment = assignment;
            this.grade = grade;
        }

        //---------------------------------------------------------------------
        // Adds the grade to the assignment through AccountController.
        // AccountController is the receiver in this Command pattern.
        //---------------------------------------------------------------------
        public void execute()
        {
            AccountController.account.addGrade(course, assignment, grade);
        }

        //---------------------------------------------------------------------
        // Removes the grade to the assignment through AccountController.
        // AccountController is the receiver in this Command pattern.
        //---------------------------------------------------------------------
        public void unexecute()
        {
            AccountController.account.removeGrade(course, assignment);
        }
    }
}
