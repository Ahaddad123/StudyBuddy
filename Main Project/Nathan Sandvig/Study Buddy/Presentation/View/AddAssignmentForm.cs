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
    public partial class AddAssignmentForm : BaseForm, IView
    {
        private AddAssignmentFormController controller;
        public AddAssignmentForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.mainPanel.MaximumSize = new System.Drawing.Size(1080, 720);
            this.mainPanel.Size = new System.Drawing.Size(1080, 720);
            this.title = "Add Assignment";
            this.Text = title;
            this.mainHeader.Text = title;
            this.nav1.SetCurrentForm(this);
        }

        public void SetController(FormController controller)
        {
            this.controller = (AddAssignmentFormController)controller;
        }

        private void butAddAssig_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            int points = 0;
            int weight = 0;
            DateTime duedate;
            //Course courseName = new Course();
            //Course testC = new Course();
            //Account test = new Account("","",1);
            //test.addCourse(testC);
            if (txtNameAssign.Text.Equals(""))
            {
                MessageBox.Show("Invalid Name");
                valid = false;
            }
            try
            {
                points = Int32.Parse(txtPointsAssign.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Total Points");
                valid = false;
            }
            try
            {
                weight = Int32.Parse(txtPriority.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Weight");
                valid = false;
            }

            if(cmbCourses.SelectedIndex == -1)
            {
                valid = false;
                MessageBox.Show("No Course selected");
            }
            duedate = dtpAssignDate.Value;
            if (points < 0)
            {
                MessageBox.Show("Invalid Total Points");
                valid = false;
            }
            if (weight < 0)
            {
                MessageBox.Show("Invalid Weight");
                valid = false;
            }

            if (valid)
            {
                // Add assignment
                // wip does not like courseName
                //controller.AddAssignment(courseName, txtNameAssign.Text,points,weight);
                MessageBox.Show("Assignment added");
                Assignment addassign = new Assignment(points, txtNameAssign.Text, weight, duedate);
                controller.AddAssignment(cmbCourses.Text, addassign);
            }
        }

        private void AddAssignmentForm_Load(object sender, EventArgs e)
        {
            foreach (Course c in AccountController.account.courses)
            {
                cmbCourses.Items.Add(c.name);
            }
        }
    }
}
