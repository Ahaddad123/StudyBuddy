using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    public interface IView
    {
        //Sets the controller
        void SetController(FormController controller);
    }
}
