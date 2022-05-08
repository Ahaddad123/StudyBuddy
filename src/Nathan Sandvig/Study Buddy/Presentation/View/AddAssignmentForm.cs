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
using Study_Buddy.Presentation.Controller;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // Windows Form to add an assignment
    //---------------------------------------------------------------------
    public partial class AddAssignmentForm : BaseForm, IView
    {
        private AddAssignmentFormController controller;

        //---------------------------------------------------------------------
        // Initializes the structure of the AddAssignmentForm
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        // Sets the controller of the form
        // controller: controller for AddAssignmentForm
        //---------------------------------------------------------------------
        public void SetController(FormController controller)
        {
            this.controller = (AddAssignmentFormController)controller;
        }

        //---------------------------------------------------------------------
        // Event for when the add assignment button is clicked.
        // Validates the information entered and adds an assignment if valid.
        //---------------------------------------------------------------------
        private void butAddAssig_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            int points = 0;
            int weight = 0;
            DateTime duedate;

            if (txtNameAssign.Text.Equals(""))
            {
                nameErrorMessageLabel.Text = "Invalid Name";
                valid = false;
            }
            try
            {
                points = Int32.Parse(txtPointsAssign.Text);
            }
            catch (Exception ex)
            {
                totalPointsErrorMessageLabel.Text = "Invalid Total Points";
                valid = false;
            }
            try
            {
                weight = Int32.Parse(txtWeight.Text);
            }
            catch (Exception ex)
            {
                weightErrorMessageLabel.Text = "Invalid Weight";
                valid = false;
            }

            if (cmbCourses.SelectedIndex == -1)
            {
                valid = false;
                courseErrorMessageLabel.Text = "No Course selected";
            }
            duedate = dtpAssignDate.Value;
            if (points < 0)
            {
                totalPointsErrorMessageLabel.Text = "Invalid Total Points";
                valid = false;
            }
            if (weight < 0)
            {
                weightErrorMessageLabel.Text = "Invalid Weight";
                valid = false;
            }

            if (valid)
            {
                successLabel.Text = "Assignment added";
                Assignment addassign = new Assignment(points, txtNameAssign.Text, weight, duedate);
                controller.AddAssignment(cmbCourses.Text, addassign);
                Clear();
            }
        }

        //---------------------------------------------------------------------
        // Clears input fields after successful entry.
        //---------------------------------------------------------------------
        private void Clear()
        {
            this.txtNameAssign.Text = null;
            this.txtPointsAssign.Text = null;
            this.txtWeight.Text = null;
            this.cmbCourses.SelectedItem = null;
            this.dtpAssignDate.Value = DateTime.Now;
        }

        //---------------------------------------------------------------------
        // Updates the course selection box to include all courses in the Account.
        //---------------------------------------------------------------------
        private void AddAssignmentForm_Load(object sender, EventArgs e)
        {
            foreach (Course c in AccountController.account.courses)
            {
                cmbCourses.Items.Add(c.name);
            }
        }
    }
}
