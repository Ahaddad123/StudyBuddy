using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Buddy.Presentation.View
{
    //---------------------------------------------------------------------
    // This class represents a blank day drawn on a calendar if the month
    // starts on a day after Sunday or ends on a day before Saturday.
    //---------------------------------------------------------------------
    public partial class Blank : UserControl
    {
        //---------------------------------------------------------------------
        // Default constructor
        //---------------------------------------------------------------------
        public Blank()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(138, 85);
        }

    }
}
