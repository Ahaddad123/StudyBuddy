using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.BusinessLogic;
using Study_Buddy.Presentation;
using Study_Buddy.Presentation.Controller;

namespace Study_Buddy.Presentation.View
{
    //---------------------------------------------------------------------
    // Windows Form to create an account
    //---------------------------------------------------------------------
    public partial class RegistrationForm : Form, IView
    {
        private RegistrationFormController controller;

        protected String title = "";

        //---------------------------------------------------------------------
        // Initializes the structure of the RegistrationForm
        //---------------------------------------------------------------------
        public RegistrationForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
        }

        //---------------------------------------------------------------------
        // Sets the controller of the form
        // controller: controller for RegistrationForm
        //---------------------------------------------------------------------
        public void SetController(FormController controller)
        {
            this.controller = (RegistrationFormController)controller;
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
        // Event for when the create account button is clicked.
        // Validates the information entered and creates the account if valid.
        //---------------------------------------------------------------------
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Clear();
            string username = textBox2.Text;
            string password = textBox3.Text;
            string email = textBox1.Text;
            string firstName = textBox4.Text;
            string lastName = textBox5.Text;
            string gpa = textBox6.Text;
            string schoolName = textBox7.Text;
            double gpa_double = 0;

            bool valid = true;

            if (username.Equals(""))
            {
                usernameLabel.Visible = true;
                valid = false;
            }
            if (password.Equals(""))
            {
                passwordLabel.Visible = true;
                valid = false;
            }
            if (email.Equals(""))
            {
                emailLabel.Visible = true;
                valid = false;
            }
            if (firstName.Equals(""))
            {
                firstNameLabel.Visible = true;
                valid = false;
            }
            if (lastName.Equals(""))
            {
                lastNameLabel.Visible = true;
                valid = false;
            }
            if (schoolName.Equals(""))
            {
                schoolLabel.Visible = true;
                valid = false;
            }
            try
            {
                gpa_double = Double.Parse(gpa);
            }
            catch (Exception ex)
            {
                gpaLabel.Visible = true;
                valid = false;
            }
            if (gpa_double < 0)
            {
                gpaLabel.Visible = true;
                valid = false;
            }

            if (valid)
            {
                AccountController acc = new AccountController();
                acc.createAccount(username, password, email, firstName, lastName, gpa, schoolName);
                FormSwitcher.OpenInitialSetupForm(this);
                Clear();
            }
        }

        //---------------------------------------------------------------------
        // Clears all of the error messages.
        //---------------------------------------------------------------------
        private void Clear()
        {
            usernameLabel.Visible=false;
            passwordLabel.Visible=false;
            emailLabel.Visible=false;
            firstNameLabel.Visible=false;
            lastNameLabel.Visible=false;
            gpaLabel.Visible=false;
            schoolLabel.Visible=false;
        }
    }
}
