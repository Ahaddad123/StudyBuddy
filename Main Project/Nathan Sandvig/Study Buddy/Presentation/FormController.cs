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
            form.ShowDialog();
        }

        public static void addCourse(Course course)
        {
            AccountController.account.courses.Add(course);
        }
    }
}
