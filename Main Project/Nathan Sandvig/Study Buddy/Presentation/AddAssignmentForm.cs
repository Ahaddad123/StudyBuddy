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
    public partial class AddAssignmentForm : Form
    {
        public AddAssignmentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butAddAssig_Click(object sender, EventArgs e)
        {
            string assignmentName = txtNameAssign.Text;
            int assignmentPoints = Int32.Parse(txtPointsAssign.Text);
            int assignmentPriority = Int32.Parse(txtPriority.Text);

            //call command to 
        }
    }
}
