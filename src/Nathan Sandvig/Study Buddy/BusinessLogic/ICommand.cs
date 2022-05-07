using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    //---------------------------------------------------------------------
    // Command interface.
    // Implemented by AddGrade and AddStudyHours.
    //---------------------------------------------------------------------
    public interface ICommand
    {
        void execute();
        void unexecute();
    }
}
