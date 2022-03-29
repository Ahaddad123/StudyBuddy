using Study_Buddy.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    internal class AddAssignmentFormController : FormController
    {
        public AddAssignmentFormController(AddAssignmentForm form)
        {
            this.view = form;
        }
        public void AddAssignment(Course info, string name, int totalPoints, int weight)
        {
            //Add the assignment
            info.AddAssignment(name, totalPoints, weight);
        }
    }
}
