using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.DataAccess;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation
{
    internal static class FormController
    {
        public static void openForm(System.Windows.Forms.Form form)
        {
            //Eventually, all forms should implement some sort of View interface for MVC
            if (typeof(CourseInfoForm).IsInstanceOfType(form))
            {
                CourseInfoForm form1 = ((CourseInfoForm)form);
                //TODO, pass in actual course and studyLog
                CourseInfoFormController controller = new CourseInfoFormController(form1, new DataAccess.Course(), new DataAccess.StudyLog());
                ((CourseInfoForm)form).SetController(controller);
                controller.DrawGradeGraph();
                controller.DrawStudyLogGraph();
            }
            form.ShowDialog();
        }

        public static void addCourse(Course course)
        {
            AccountController.account.addCourse(course);
        }

        public static List<Course> getCourses()
        {
            return AccountController.account.courses;
        }
    }
}
