using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.Presentation.View;

namespace Study_Buddy.Presentation.Controller
{
    //---------------------------------------------------------------------
    // Controls the InitialSetupForm
    //---------------------------------------------------------------------
    internal class InitialSetupFormController : FormController
    {
        //---------------------------------------------------------------------
        // Sets the view to the InitialSetupForm
        //---------------------------------------------------------------------
        public InitialSetupFormController(InitialSetupForm form)
        {
            this.view = form;
        }

    }
}
