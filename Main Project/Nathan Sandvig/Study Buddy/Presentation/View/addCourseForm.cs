using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.DataAccess;
using Study_Buddy.BusinessLogic;
using Study_Buddy.Presentation.View;

namespace Study_Buddy.Presentation
{
    public partial class AddCourseForm : BaseForm, IView
    {
        private AddCourseFormController controller;
        public AddCourseForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.mainPanel.MaximumSize = new System.Drawing.Size(1080, 720);
            this.mainPanel.Size = new System.Drawing.Size(1080, 720);
            this.title = "Add/Remove Course";
            this.Text = title;
            this.mainHeader.Text = title;
            this.nav1.SetCurrentForm(this);
            this.mainPanel.Controls.Add(this.editCourseBox1);

            this.addCourseBox1.StatusUpdated += new EventHandler(ChildControlEvent_AddCourseBoxAddCourseButtonClicked);
            this.removeCourseBox1.LoadCourses(AccountController.account.courses);
            this.removeCourseBox1.StatusUpdated += new EventHandler(Event_RemoveCourseButtonClick);
            this.editCourseBox1.StatusUpdated += new EventHandler(Event_EditCourseButtonClick);
            this.editCourseBox1.LoadCourses(AccountController.account.courses);
        }

        public void Event_EditCourseButtonClick(Object sender, EventArgs e)
        {
            //TODO: move this logic to parent form
            Course course = AccountController.account.getCourseByName(sender.ToString());
            this.editCourseBox1.UpdateData(course);
        }

        public void ChildControlEvent_AddCourseBoxAddCourseButtonClicked(Object sender, EventArgs e)
        {
            
        }

        public void Event_RemoveCourseButtonClick(object sender, EventArgs e)
        {
            AccountController.account.removeCourse((String)sender);
            this.removeCourseBox1.LoadCourses(AccountController.account.courses);
        }

        //---------------------------------------------------------------------
        // Sets the form's controller
        // v1: Created the method - Peter H, 3-19-22
        //---------------------------------------------------------------------
        public void SetController(FormController controller)
        {
            this.controller = (AddCourseFormController)controller;
        }


        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            this.btnAddCourse.BackColor = Color.White;
            this.btnAddCourse.ForeColor = Color.Navy;
            this.btnRemoveCourse.BackColor = Color.Navy;
            this.btnRemoveCourse.ForeColor = Color.White;
            this.btnEditCourse.BackColor = Color.Navy;
            this.btnEditCourse.ForeColor = Color.White;
            this.addCourseBox1.Visible = true;
            this.removeCourseBox1.Visible = false;
            this.editCourseBox1.Visible = false;
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            this.btnRemoveCourse.BackColor = Color.White;
            this.btnRemoveCourse.ForeColor = Color.Navy;
            this.btnAddCourse.BackColor = Color.Navy;
            this.btnAddCourse.ForeColor = Color.White;
            this.btnEditCourse.BackColor = Color.Navy;
            this.btnEditCourse.ForeColor = Color.White;
            this.removeCourseBox1.Visible = true;
            this.addCourseBox1.Visible = false;
            this.editCourseBox1.Visible= false;
            //IMPORTANT - Make sure course list is updated
            this.removeCourseBox1.LoadCourses(AccountController.account.courses);
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            this.btnRemoveCourse.BackColor = Color.Navy;
            this.btnRemoveCourse.ForeColor = Color.White;
            this.btnAddCourse.BackColor = Color.Navy;
            this.btnAddCourse.ForeColor = Color.White;
            this.btnEditCourse.BackColor = Color.White;
            this.btnEditCourse.ForeColor = Color.Navy;
            this.removeCourseBox1.Visible = false;
            this.addCourseBox1.Visible = false;
            this.editCourseBox1.Visible = true;
            this.editCourseBox1.LoadCourses(AccountController.account.courses);
        }
    }
}
