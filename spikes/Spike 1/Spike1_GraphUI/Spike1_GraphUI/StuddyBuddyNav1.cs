using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spike1_GraphUI
{
    public partial class StuddyBuddyNav1 : UserControl
    {
        public StuddyBuddyNav1()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(315, 780);
            this.Size = new System.Drawing.Size(315, 780);
            this.panelSubMenu.MaximumSize = new System.Drawing.Size(315, 780);
            this.panelSubMenu.Size = new System.Drawing.Size(315, 780);
        }


        private void btnVisualizeMyData_Click(object sender, EventArgs e)
        {
            //Call formController to change form
        }
    }
}
