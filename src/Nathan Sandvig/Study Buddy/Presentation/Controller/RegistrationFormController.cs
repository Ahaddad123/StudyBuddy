using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.Presentation.View;

namespace Study_Buddy.Presentation.Controller
{
    //---------------------------------------------------------------------
    // Controls the RegistrationForm
    //---------------------------------------------------------------------
    internal class RegistrationFormController : FormController
    {
        //---------------------------------------------------------------------
        // Sets the view to the RegistrationForm
        //---------------------------------------------------------------------
        public RegistrationFormController(RegistrationForm form)
        {
            this.view = form;
        }
    }
}
