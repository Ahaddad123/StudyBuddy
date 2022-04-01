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
        public AddGradeFormController(AddGradeForm form, Course course)
        {
            this.view = form;
            this.course = course;
        }

        public void AddGrade(String name, double points)
        {
            course.GradeAssignment(name, points);
        }
    }
}
