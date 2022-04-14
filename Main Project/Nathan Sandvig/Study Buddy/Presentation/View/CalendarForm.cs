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
using Study_Buddy.Presentation.View;
using Study_Buddy.Presentation.Controller;

namespace Study_Buddy.Presentation
{
    public partial class CalendarForm : BaseForm, IView
    {
        private CalendarFormController controller;
        public CalendarForm()
        {
            InitializeComponent();
            this.title = "Calendar";
            this.Text = title;
            this.mainHeader.Text = title;
            this.nav1.SetCurrentForm(this);
        }

        public void SetController(FormController controller)
        {
            this.controller = (CalendarFormController)controller;
        }
    }
}
