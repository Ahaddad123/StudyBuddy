using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;
using Study_Buddy.DataAccess;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // Controller of the AddGradeForm
    //---------------------------------------------------------------------
    internal class AddGradeFormController : FormController
    {
        public Course course { get; set; } //course that we will add a grade for
        private Invoker invoker;           //invoker for undo and redo

        //---------------------------------------------------------------------
        // Paramatized constructor of controller
        // course: course of form
        // form: current form
        //---------------------------------------------------------------------
        public AddGradeFormController(AddGradeForm form, Course course)
        {
            this.view = form;
            this.course = course;
            invoker = new Invoker();
        }

        //---------------------------------------------------------------------
        // Addes grade to given assignment in course adds addgrade to done of
        // invoker
        // name: name of assignment that is being graded
        // points: points the user got for the assignment
        //---------------------------------------------------------------------
        public void AddGrade(String name, double points)
        {
            AddGrade addGrade = new AddGrade(course.name, name, points);
            invoker.Do(addGrade);
        }

        //---------------------------------------------------------------------
        // uses invoker to undo most recent command
        //---------------------------------------------------------------------
        public void Undo()
        {
            invoker.Undo();
        }

        //---------------------------------------------------------------------
        // uses invoker to redo an undone command
        //---------------------------------------------------------------------
        public void Redo()
        {
            invoker.Redo();
        }
    }
}
