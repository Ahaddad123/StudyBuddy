using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    //-------------------------------------------------------------------------
    // This class is used as a base class for form Controllers.  
    // Used as the Controller component of MVC pattern.
    // v1: Created the class - Peter H., 3/7/2022
    //-------------------------------------------------------------------------
    public class FormController
    {
        //---------------------------------------------------------------------
        // protected data members:
        // view : the display that is being controlled
        //---------------------------------------------------------------------
        //-------------------------------------------------------------------------
        protected IView view;
    }
}
