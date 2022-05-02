using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.Presentation;
using Study_Buddy.Presentation.Controller;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation.View
{
    //---------------------------------------------------------------------
    // Form that allows the user to log in or create a new account
    //---------------------------------------------------------------------
    public partial class LoginForm : Form, IView
    {
        private LoginFormController controller;

        //---------------------------------------------------------------------
        // Default constructor
        //---------------------------------------------------------------------
        public LoginForm()
        {

            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
        }

        //---------------------------------------------------------------------
        // Sets the forms controller
        // controller : the controller being set
        //---------------------------------------------------------------------
        public void SetController(FormController controller)
        {
            this.controller = (LoginFormController)controller;
        }


        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion

        //---------------------------------------------------------------------
        // Handles a click of the "create account" button
        //---------------------------------------------------------------------
        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            FormSwitcher.OpenRegistrationForm(this);
        }

        //---------------------------------------------------------------------
        // Handles a click of the "sign in" button 
        //---------------------------------------------------------------------
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String newUsername = nameTextBox.Text;
            String newPassword = passwordTextBox.Text;
            

            Boolean valid = controller.Login(newUsername, newPassword); 

            if (!valid)
            {
                this.errorMessageLabel.Text = "Invalid Login Credentials.  Please try again.";
            }
            else
                FormSwitcher.OpenHomePageForm(this);
        }
    }
}
