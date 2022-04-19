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
        private Stack<AddStudyHours> done = new Stack<AddStudyHours>();
        private Stack<AddStudyHours> undone = new Stack<AddStudyHours>();
        public StudyLogFormController(StudyLogForm form)
        {
            this.view = form;
        }

        public void AddHours(String courseName,DateTime date, double hours)
        {
            AddStudyHours addStudyHours = new AddStudyHours(courseName, date, hours);
            addStudyHours.execute();
            done.Push(addStudyHours);
        }

        public void Undo()
        {
            AddStudyHours addStudyHours = done.Pop();
            addStudyHours.unexecute();
            undone.Push(addStudyHours);
        }

        public void Redo()
        {
            AddStudyHours addStudyHours = undone.Pop();
            addStudyHours.execute();
            done.Push(addStudyHours);
        }
    }
}
