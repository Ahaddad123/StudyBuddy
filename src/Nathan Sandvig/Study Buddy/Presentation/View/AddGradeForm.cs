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
using Study_Buddy.Presentation.View;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // Windows Form to add a grade
    //---------------------------------------------------------------------
    public partial class AddGradeForm : BaseForm, IView
    {
        private AddGradeFormController controller;

        //---------------------------------------------------------------------
        // Initializes the structure of the AddGradeForm
        //---------------------------------------------------------------------
        public AddGradeForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.nav1.SetCurrentForm(this);
        }

        //---------------------------------------------------------------------
        // Sets the controller of the form
        // controller: controller for AddGradeForm
        //---------------------------------------------------------------------
        public void SetController(FormController controller)
        {
            this.controller = (AddGradeFormController)controller;
        }

        //---------------------------------------------------------------------
        // Event for when the add grade button is clicked.
        // Validates the information entered and adds a grade if valid.
        //---------------------------------------------------------------------
        private void butAddAssig_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            double points = 0;
            if (txtNameAssign.Text.Equals(""))
            {
                nameErrorMessageLabel.Text = "Invalid Name";
                valid = false;
            }
            try
            {
                points = Double.Parse(txtPointsAssign.Text);
            }
            catch (Exception ex)
            {
                scoreErrorMessageLabel.Text = "Invalid Score";
                valid = false;
            }
            if (valid)
            {
                controller.AddGrade(txtNameAssign.Text, points);
                successMessageLabel.Text = "Successfully added grade";
            }
        }

        //---------------------------------------------------------------------
        // Populates the assignment drop box for a specific course
        //---------------------------------------------------------------------
        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            Course course = controller.course;
            foreach(Assignment assignment in course.assignments)
            {
                txtNameAssign.Items.Add(assignment.name);
            }
            this.title = "Add Grade for " + course.name;
            this.Text = title;
            this.mainHeader.Text = title;
        }

        //---------------------------------------------------------------------
        // Undoes adding a grade when the Undo button is clicked
        //---------------------------------------------------------------------
        private void btnUndo_Click(object sender, EventArgs e)
        {
            controller.Undo();
        }

        //---------------------------------------------------------------------
        // Redoes adding a grade when the Redo button is clicked
        //---------------------------------------------------------------------
        private void btnRedo_Click(object sender, EventArgs e)
        {
            controller.Redo();
        }
    }
}
