using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // This interface defines common behavior for forms.  Used as the View
    // component of MVC pattern.
    //---------------------------------------------------------------------
    public interface IView
    {
        //Sets the controller for the form
        void SetController(FormController controller);
    }
}
