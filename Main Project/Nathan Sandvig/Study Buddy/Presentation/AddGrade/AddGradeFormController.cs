using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    internal class AddGradeFormController : Controller
    {
        public AddGradeFormController(AddGradeForm form)
        {
            this.view = form;
        }

        public void AddGrade()
        {
            //Pretend to add a grade
        }
    }
}
