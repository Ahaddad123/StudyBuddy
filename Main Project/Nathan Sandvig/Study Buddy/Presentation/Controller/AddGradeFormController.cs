using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;
using Study_Buddy.DataAccess;

namespace Study_Buddy.Presentation
{
    internal class AddGradeFormController : FormController
    {
        public Course course { get; set; }
        private Invoker invoker;
        public AddGradeFormController(AddGradeForm form, Course course)
        {
            this.view = form;
            this.course = course;
            invoker = new Invoker();
        }

        public void AddGrade(String name, double points)
        {
            AddGrade addGrade = new AddGrade(course.name, name, points);
            invoker.Do(addGrade);
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
