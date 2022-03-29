using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.DataAccess;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation
{
    public partial class StudyLogForm : Form, IView
    {
        private StudyLogFormController controller;
        public StudyLogForm()
        {
            InitializeComponent();
            this.nav1.SetCurrentForm(this);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.mainPanel.MaximumSize = new System.Drawing.Size(1080, 720);
            this.mainPanel.Size = new System.Drawing.Size(1080, 720);
        }

        public void SetController(FormController controller)
        {
            this.controller = (StudyLogFormController)controller;
        }
    }
}
