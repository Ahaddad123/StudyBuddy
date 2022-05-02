using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;
using Study_Buddy.Presentation.View;

namespace Study_Buddy.Presentation.Controller
{
    //---------------------------------------------------------------------
    // This class controls a Login Form
    //---------------------------------------------------------------------
    internal class LoginFormController : FormController
    {

        //---------------------------------------------------------------------
        // Default constructor
        // form : the form being controlled
        //---------------------------------------------------------------------
        public LoginFormController(LoginForm form)
        {
            this.view = form;
        }

        //---------------------------------------------------------------------
        // Attempts to validate the user's username and password
        // userName : the provided userName
        // password : the provided password
        //---------------------------------------------------------------------
        public bool Login(String userName, String password)
        {
            AccountController acc = new AccountController();
            return acc.accountCreated(userName, password);
        }
    }
}
