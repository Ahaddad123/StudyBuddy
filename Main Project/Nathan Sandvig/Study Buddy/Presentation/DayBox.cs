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
    public partial class DayBox : UserControl
    {
        public DayBox()
        {
            InitializeComponent();
        }

        public void setToday()
        {
            this.BackColor = Color.RoyalBlue;
            this.labelDays.ForeColor = Color.White;
            this.eventLabel1.ForeColor = Color.White;
        }

        private void DayBox_Load(object sender, EventArgs e)
        {

        }

        public void days(int numDay)
        {
            labelDays.Text = numDay + "";
        }
    }
}
