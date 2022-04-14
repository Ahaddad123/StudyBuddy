using Study_Buddy.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation.Controller
{
    internal class AddAssignmentFormController : FormController
    {
        public AddAssignmentFormController(AddAssignmentForm form)
        {
            this.view = form;
        }
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
            AccountController.account.addAssignment(courseName, newAssign.name, newAssign.grade.ToString(), newAssign.weight.ToString(), newAssign.dueDate.ToString());
            course.AddAssignment(newAssign);
        }
    }
}
