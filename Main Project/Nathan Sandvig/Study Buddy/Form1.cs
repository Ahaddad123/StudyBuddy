using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Buddy
{
    public partial class Form1 : Presentation.StuddyBuddyFormTemplate
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Size = new System.Drawing.Size(1920, 1080);
        }
    }
}
