using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.Presentation;
using Study_Buddy.Presentation.Controller;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation.View
{
    public partial class InitialSetupForm : Form, IView
    {
        private InitialSetupFormController controller;

        protected String title = "";
        public InitialSetupForm()
        {
            InitializeComponent();
            
            this.userCourseList1.ChangePanelWidth(this.courseListPanel.Width);
            //Draw courses on the userCourseList
            this.userCourseList1.DrawCourses(AccountController.account.courses);

            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.addCourseBox1.StatusUpdated += new EventHandler(ChildControlEvent_AddCourseBoxAddCourseButtonClicked);
            this.userCourseList1.StatusUpdated += new EventHandler(ChildControlEvent_CourseListButtonClicked);
        }

        public void ChildControlEvent_CourseListButtonClicked(object sender, EventArgs e)
        {

        }
        public void ChildControlEvent_AddCourseBoxAddCourseButtonClicked(object sender, EventArgs e)
        {
            this.userCourseList1.ClearCourseButtons();
            this.userCourseList1.DrawCourses(AccountController.account.courses);
        }

        public void SetController(FormController controller)
        {
            this.controller = (InitialSetupFormController)controller;
        }


        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenInitialSetupForm(this);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenHomePageForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear the old addCourse info
            this.addCourseBox1.Clear();
        }
    }
}
