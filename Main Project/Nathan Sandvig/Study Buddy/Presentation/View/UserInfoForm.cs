using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.Presentation.Controller;

namespace Study_Buddy.Presentation.View
{
    public partial class UserInfoForm : BaseForm, IView
    {
        private UserInfoFormController controller;
        public UserInfoForm()
        {
            InitializeComponent();
            this.title = "Your Information";
            this.Text = title;
            this.mainHeader.Text = title;
            this.nav1.SetCurrentForm(this);
        }
        public void SetController(FormController formController)
        {
            this.controller = (UserInfoFormController)formController;
        }
    }
}
