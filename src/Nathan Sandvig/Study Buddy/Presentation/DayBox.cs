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
    //---------------------------------------------------------------------
    // This class creates a box representing the drawing of a day on the
    // calendar form.
    //---------------------------------------------------------------------
    public partial class DayBox : UserControl
    {
        //---------------------------------------------------------------------
        // Default constructor
        //---------------------------------------------------------------------
        public DayBox()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        // Inverts the DayBox's colors if the day being drawn is the current day
        //---------------------------------------------------------------------
        public void setToday()
        {
            this.BackColor = Color.RoyalBlue;
            this.labelDays.ForeColor = Color.White;
        }

        //---------------------------------------------------------------------
        // Adds a label representing an assignment to the box.
        // yValue : the location of the label on the Y axis - important if
        // multiple labels are being added
        // fontColor : the Color of the label's font
        // return : the Label describing a due date
        //---------------------------------------------------------------------
        public Label AddDueDate(int yValue, string assignmentName, Color fontColor)
        {
            Label labelDays = new Label();
            labelDays.Text = assignmentName;
            labelDays.ForeColor = fontColor;
            labelDays.Font = new Font("Arial", 8);
            labelDays.Location = new Point(0, yValue);
            labelDays.Size = new Size(this.Width - 5, 15);
            return labelDays;
        }

        //---------------------------------------------------------------------
        // Sets the label to the numeric day of the month
        // numDay : the numeric day of month
        //---------------------------------------------------------------------
        public void Days(int numDay)
        {
            labelDays.Text = numDay + "";
        }
    }
}
