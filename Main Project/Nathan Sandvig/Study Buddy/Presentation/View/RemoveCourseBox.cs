using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation.View
{
    public partial class RemoveCourseBox : UserControl
    {
        public RemoveCourseBox()
        {
            InitializeComponent();
        }

        private void removeCourseButton_Click(object sender, EventArgs e)
        {
            AccountController.account.removeCourse(courseListBox.Text);
            this.successMessage.Text = "Succesfully removed " + courseListBox.Text;
        }

        private void RemoveCourseBox_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        public void LoadCourses()
        {
            courseListBox.Items.Clear();
            foreach (Course c in AccountController.account.courses)
            {
                courseListBox.Items.Add(c.name);
            }

        }
    }
}
