using Study_Buddy.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // Controller of the StudyLogForm
    //---------------------------------------------------------------------
    internal class StudyLogFormController : FormController
    {
        private Invoker invoker;
        //---------------------------------------------------------------------
        // Paramatized constructor of controller
        // form: current form
        //---------------------------------------------------------------------
        public StudyLogFormController(StudyLogForm form)
        {
            this.view = form;
            invoker = new Invoker();
        }

        //---------------------------------------------------------------------
        // Addes study hours to given course and updates invoker for undo/redo purposes
        // courseName: name of course
        // date: date to add the study hours to
        // hours: number of hours to add
        //---------------------------------------------------------------------
        public void AddHours(String courseName,DateTime date, double hours)
        {
            AddStudyHours addStudyHours = new AddStudyHours(courseName, date.Date, hours);
            invoker.Do(addStudyHours);
        }

        //---------------------------------------------------------------------
        // Undoes the last added study hours
        //---------------------------------------------------------------------
        public void Undo()
        {
            invoker.Undo();
        }

        //---------------------------------------------------------------------
        // Redos the last undone added study hours
        //---------------------------------------------------------------------
        public void Redo()
        {
            invoker.Redo(); 
        }
    }
}
