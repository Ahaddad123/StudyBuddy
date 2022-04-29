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
        private Invoker invoker;
        public StudyLogFormController(StudyLogForm form)
        {
            this.view = form;
            invoker = new Invoker();
        }

        public void AddHours(String courseName,DateTime date, double hours)
        {
            AddStudyHours addStudyHours = new AddStudyHours(courseName, date.Date, hours);
            invoker.Do(addStudyHours);
        }

        public void Undo()
        {
            invoker.Undo();
        }

        public void Redo()
        {
            invoker.Redo(); 
        }
    }
}
