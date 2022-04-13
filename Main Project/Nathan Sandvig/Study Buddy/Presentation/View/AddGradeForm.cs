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
    public partial class AddGradeForm : BaseForm, IView
    {
        private AddGradeFormController controller;
        public AddGradeForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.nav1.SetCurrentForm(this);
        }
        
        public void SetController(FormController controller)
        {
            this.controller = (AddGradeFormController)controller;
        }

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
    }
}
