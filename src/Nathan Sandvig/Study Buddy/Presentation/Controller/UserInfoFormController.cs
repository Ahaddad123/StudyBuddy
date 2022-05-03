using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.Presentation.View;
using Study_Buddy.Presentation.Model;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation.Controller
{
    internal class UserInfoFormController : FormController
    {
        private Account account { get; set; }
        private GPAGraph gpaGraph;
        public UserInfoFormController(UserInfoForm form, Account account)
        {
            this.view = form;
            this.account = account;
            this.gpaGraph = new GPAGraph(new List<DateTime>(), new List<double>());
            view.SetController(this);
        }

        public void SetUserInfo()
        {
            ((UserInfoForm)(this.view)).DisplayUserInfo(account.fname, account.lname, account.sName, account.GPA1);
        }

        //---------------------------------------------------------------------
        // Draws a graph of grades in the course against time.
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public void DrawGPAGraph()
        {
            ((UserInfoForm)view).DrawGPAGraph(gpaGraph.GetXValues(), gpaGraph.GetYValues());
        }
    }
}
