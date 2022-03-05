using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Buddy.DataAccess
{
    public partial class addCourseForm : Form
    {
        public addCourseForm()
        {
            InitializeComponent();
        }

        private void addCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void butAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseTitle.Text;
            string courseCode = txtCourseCode.Text;
            int coursePriority = Int32.Parse(txtCoursePriority.Text);
            int courseCredit = Int32.Parse(txtCourseCredits.Text);
        }
    }
}
