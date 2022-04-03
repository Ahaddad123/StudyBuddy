using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.Presentation.View;

namespace Study_Buddy.Presentation.Controller
{
    internal class InitialSetupFormController : FormController
    {
        public InitialSetupFormController(InitialSetupForm form)
        {
            this.view = form;
        }
    }
}
