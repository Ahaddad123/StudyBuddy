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
        public EventHandler StatusUpdated;
        public RemoveCourseBox()
        {
            InitializeComponent();
            this.groupBox2.Size = new System.Drawing.Size(1000, 545);
        }

        private void removeCourseButton_Click(object sender, EventArgs e)
        {
            this.StatusUpdated(this.courseListBox.Text, new EventArgs());
            this.courseListBox.Text = "";
            this.successMessage.Text = "Succesfully removed " + courseListBox.Text;
        }


        public void LoadCourses(List<Course> courses)
        {
            courseListBox.Items.Clear();
            foreach (Course c in courses)
            {
                courseListBox.Items.Add(c.name);
            }

        }
    }
}
