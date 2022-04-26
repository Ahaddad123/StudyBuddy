using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;
using System.Windows.Forms;
using Study_Buddy.Presentation.View;
using Study_Buddy.Presentation.Controller;

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
            CourseInfoFormController controller;
            if (AccountController.account.courses.Count == 0)
            {
                controller = new CourseInfoFormController(form, new Course(), new StudyLog());
            }
            else
            {
                controller = new CourseInfoFormController(form, AccountController.account.courses[0], AccountController.account.courses[0].hourLog);
            }
            form.SetController(controller);
            controller.SetCourseInfo();
            controller.DrawGradeGraph();
            controller.DrawStudyLogGraph();
            DateTime currTime = DateTime.Now;
            int currWeek = currTime.DayOfYear / 7;
            controller.ChangeCurrentWeekID(currWeek);
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
        public static void OpenUserInfoForm(Form currentForm)
        {
            currentForm.Hide();
            UserInfoForm form = new UserInfoForm();
            form.StartPosition = FormStartPosition.Manual;
            UserInfoFormController controller = new UserInfoFormController(form, new Account("Billy Bob", "BillyBobsPassword"));
            controller.DrawGPAGraph();
            controller.SetUserInfo();
            form.SetController(controller);
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenCalendarForm(Form currentForm)
        {
            currentForm.Hide();
            CalendarForm form = new CalendarForm();
            form.StartPosition = FormStartPosition.Manual;
            CalendarFormController controller = new CalendarFormController(form);
            form.SetController(controller);
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenScheduleForm(Form currentForm)
        {
            currentForm.Hide();
            ScheduleForm form = new ScheduleForm();
            form.StartPosition = FormStartPosition.Manual;
            ScheduleFormController controller = new ScheduleFormController(form);
            form.SetController(controller);
            form.ShowDialog();
            currentForm.Close();
        }

        //Below methods used for opening forms that do not inherit BaseForm
        public static void OpenRegistrationForm(Form currentForm)
        {
            currentForm.Hide();
            RegistrationForm form = new RegistrationForm();
            form.StartPosition = FormStartPosition.Manual;
            RegistrationFormController controller = new RegistrationFormController(form);
            form.SetController(controller);
            form.ShowDialog();
            currentForm.Close();
        }
        public static void OpenInitialSetupForm(Form currentForm)
        {
            currentForm.Hide();
            InitialSetupForm form = new InitialSetupForm();
            form.StartPosition = FormStartPosition.Manual;
            InitialSetupFormController controller = new InitialSetupFormController(form);
            form.SetController(controller);
            form.ShowDialog();
            currentForm.Close();
        }
    }
}
