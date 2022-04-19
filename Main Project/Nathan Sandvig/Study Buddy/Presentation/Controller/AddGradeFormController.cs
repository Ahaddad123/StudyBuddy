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
        private Stack<AddGrade> done = new Stack<AddGrade>();
        private Stack<AddGrade> undone = new Stack<AddGrade>();
        public AddGradeFormController(AddGradeForm form, Course course)
        {
            this.view = form;
            this.course = course;
        }

        public void AddGrade(String name, double points)
        {
            AddGrade addGrade = new AddGrade(course.name, name, points);
            addGrade.execute();
            done.Push(addGrade);
        }

        public void Undo()
        {
            AddGrade addGrade = done.Pop();
            addGrade.unexecute();
            undone.Push(addGrade);
        }

        public void Redo()
        {
            AddGrade addGrade = undone.Pop();
            addGrade.execute();
            done.Push(addGrade);
        }
    }
}
