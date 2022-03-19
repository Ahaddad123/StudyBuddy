using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.DataAccess;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation
{
    internal class HomePageFormController : FormController
    {
        public HomePageFormController(HomePageForm form)
        {
            this.view = form;
            view.SetController(this);
        }

        public List<Course> getCourses()
        {
            return AccountController.account.courses;
        }
    }
}
