using Study_Buddy.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation
{
    internal class StudyLogFormController : FormController
    {
        public StudyLogFormController(StudyLogForm form)
        {
            this.view = form;
        }

        public void AddHours(String courseName,DateTime date, double hours)
        {
            Course course = null;
            foreach (Course c in AccountController.account.courses)
            {
                if (c.name == courseName)
                {
                    course = c;
                }
            }
            course.LogHours(hours,date.Date);
        }
    }
}
