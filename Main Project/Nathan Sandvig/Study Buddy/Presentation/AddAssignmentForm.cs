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

        private void butAddAssig_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            int points = 0;
            double weight = 0;
            if (txtNameAssign.Text.Equals(""))
            {
                MessageBox.Show("Invalid Name");
                valid = false;
            }
            try
            {
                points = Int32.Parse(txtPointsAssign.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Total Points");
                valid = false;
            }
            try
            {
                weight = Double.Parse(txtPriority.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Weight");
                valid = false;
            }
            if (points < 0)
            {
                MessageBox.Show("Invalid Total Points");
            }
            if (weight < 0)
            {
                MessageBox.Show("Invalid Weight");
            }

            if(valid)
            {
                // Add assignment
            }
        }
    }
}
