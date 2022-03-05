using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Buddy.Presentation
{
    public partial class Nav : UserControl
    {
        public Nav()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.panelSubMenu.MaximumSize = new System.Drawing.Size(1366, 768);
            this.panelSubMenu.Size = new System.Drawing.Size(1366, 768);
        }


        private void btnVisualizeMyData_Click(object sender, EventArgs e)
        {
            //Call formController to change form
        }
    }
}
