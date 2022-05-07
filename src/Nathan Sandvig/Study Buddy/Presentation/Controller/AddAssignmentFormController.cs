using Study_Buddy.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation.Controller
{
    //---------------------------------------------------------------------
    // Controls the AddAssignmentForm
    //---------------------------------------------------------------------
    internal class AddAssignmentFormController : FormController
    {
        //---------------------------------------------------------------------
        // Constructor that sets the view to the AddAssignmentForm
        //---------------------------------------------------------------------
        public AddAssignmentFormController(AddAssignmentForm form)
        {
            this.view = form;
        }

        //---------------------------------------------------------------------
        // Adds an Assigment to a Course
        // courseName: name of the course to add the assignment to
        // newAssign: Assignment to add
        //---------------------------------------------------------------------
        public void AddAssignment(String courseName, Assignment newAssign)
        {
            //Add the assignment
            Course course = null;
            foreach(Course c in AccountController.account.courses)
            {
                if(c.name == courseName)
                {
                    course = c;
                }
            }
            AccountController.account.database.addAssignment(courseName, newAssign.name, newAssign.totalPoints.ToString(), newAssign.weight.ToString(), newAssign.totalPoints.ToString(), newAssign.dueDate.ToString());
            course.AddAssignment(newAssign);
        }
    }
}
