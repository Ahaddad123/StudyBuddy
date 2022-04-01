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

        public void AddHours(Course info,int week,int day, double hours)
        {
            info.LogHours(hours,day,week);
        }
    }
}
