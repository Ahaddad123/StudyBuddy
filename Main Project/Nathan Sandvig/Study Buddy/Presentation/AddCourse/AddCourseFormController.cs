using Study_Buddy.BusinessLogic;
using Study_Buddy.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    internal class AddCourseFormController : Controller
    {
        public AddCourseFormController(AddCourseForm form)
        {
            this.view = form;
        }
        public void addCourse(Course course)
        {
            AccountController.account.addCourse(course);
        }
    }
}
