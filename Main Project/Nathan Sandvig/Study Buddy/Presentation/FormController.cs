using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.DataAccess;
using Study_Buddy.BusinessLogic;
using System.Windows.Forms;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // This class controls the switching of forms in the application.
    // v2: Modified - Peter H. 3-19-22
    //---------------------------------------------------------------------
    internal static class FormController
    {
        public static void OpenCourseInfoForm(Form currentForm)
        {
            currentForm.Hide();
            CourseInfoForm form = new CourseInfoForm();
            form.StartPosition = FormStartPosition.Manual;
            //TODO, pass in actual course and studyLog
            CourseInfoFormController controller = new CourseInfoFormController(form, new DataAccess.Course(), new DataAccess.StudyLog());
            form.SetController(controller);
            controller.DrawGradeGraph();
            controller.DrawStudyLogGraph();
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenAddAssignmentForm(Form currentForm)
        {
            currentForm.Hide();
            AddAssignmentForm form = new AddAssignmentForm();
            form.StartPosition = FormStartPosition.Manual;
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenAddCourseForm(Form currentForm)
        {
            currentForm.Hide();
            AddCourseForm form = new AddCourseForm();
            form.StartPosition = FormStartPosition.Manual;
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenAddGradeForm(Form currentForm)
        {
            currentForm.Hide();
            AddGradeForm form = new AddGradeForm();
            form.StartPosition = FormStartPosition.Manual;
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenHomePageForm(Form currentForm)
        {
            currentForm.Hide();
            HomePageForm form = new HomePageForm();
            form.StartPosition = FormStartPosition.Manual;
            form.ShowDialog();
            currentForm.Close();
        }

        //TODO: This functionality needs to be moved to a controller class for the AddCourseForm
        public static void addCourse(Course course)
        {
            AccountController.account.addCourse(course);
        }

    }
}
