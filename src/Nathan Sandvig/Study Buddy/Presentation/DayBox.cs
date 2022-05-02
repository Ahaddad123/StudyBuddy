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
        }

        public Label addDueDate(int indexValue, string assignmentName, Color color)
        {
            Label labelDays = new Label();
            labelDays.Text = assignmentName;
            labelDays.ForeColor = color;
            labelDays.Font = new Font("Arial", 8);
            labelDays.Location = new Point(0, indexValue);
            labelDays.Size = new Size(this.Width - 5, 15);
            return labelDays;
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
