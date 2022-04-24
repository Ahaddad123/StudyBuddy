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
            this.addCourseBox1.Visible = true;
            this.removeCourseBox1.Visible = false;
            //this.editCourseBox1.Visible = false;
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            this.btnRemoveCourse.BackColor = Color.White;
            this.btnRemoveCourse.ForeColor = Color.Navy;
            this.btnAddCourse.BackColor = Color.Navy;
            this.btnAddCourse.ForeColor = Color.White;
            this.removeCourseBox1.Visible = true;
            this.addCourseBox1.Visible = false;
            //IMPORTANT - Make sure course list is updated
            this.removeCourseBox1.LoadCourses();
            //this.editCourseBox1.Visible = false;
        }


        //TDO: Add method for editing course
    }
}
