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
    // NOTE that this class does not extend Controller and is confusingly 
    // named.
    // v2: Modified - Peter H. 3-19-22
    //---------------------------------------------------------------------
    internal static class FormSwitcher
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
            AddAssignmentFormController controller = new AddAssignmentFormController(form);
            form.SetController(controller);
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenAddCourseForm(Form currentForm)
        {
            currentForm.Hide();
            AddCourseForm form = new AddCourseForm();
            form.StartPosition = FormStartPosition.Manual;
            AddCourseFormController controller = new AddCourseFormController(form);
            form.SetController(controller);
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenAddGradeForm(Form currentForm, Course course)
        {
            currentForm.Hide();
            AddGradeForm form = new AddGradeForm();
            form.StartPosition = FormStartPosition.Manual;
            AddGradeFormController controller = new AddGradeFormController(form, course);
            form.SetController(controller);
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenHomePageForm(Form currentForm)
        {
            currentForm.Hide();
            HomePageForm form = new HomePageForm();
            form.StartPosition = FormStartPosition.Manual;
            HomePageFormController controller = new HomePageFormController(form);
            form.SetController(controller);
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenStudyLogForm(Form currentForm)
        {
            currentForm.Hide();
            StudyLogForm form = new StudyLogForm();
            form.StartPosition = FormStartPosition.Manual;
            StudyLogFormController controller = new StudyLogFormController(form);
            form.SetController(controller);
            form.ShowDialog();
            currentForm.Close();
        }
    }
}
