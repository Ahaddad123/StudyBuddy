using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    internal class AddGrade : ICommand
    {
        private string course;
        private string assignment;
        private double grade;

        public AddGrade(string course, string assignment, double grade)
        {
            this.course = course;
            this.assignment = assignment;
            this.grade = grade;
        }

        public void execute()
        {
            AccountController.account.addGrade(course, assignment, grade);
        }

        public void unexecute()
        {
            AccountController.account.removeGrade(course, assignment);
        }
    }
}
