using Study_Buddy.BusinessLogic;
using Study_Buddy.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // Controls the AddCourseForm
    //---------------------------------------------------------------------
    internal class AddCourseFormController : FormController
    {
        //---------------------------------------------------------------------
        // Constructor that sets the view to the AddCourseForm
        //---------------------------------------------------------------------
        public AddCourseFormController(AddCourseForm form)
        {
            this.view = form;
        }
    }
}
