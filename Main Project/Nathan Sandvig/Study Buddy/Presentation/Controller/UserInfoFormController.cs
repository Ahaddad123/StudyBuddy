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
    internal class UserInfoFormController : GraphController
    {
        private Account account { get; set; }
        private GPAGraph gpaGraph;
        public UserInfoFormController(UserInfoForm form, Account account)
        {
            this.view = form;
            this.account = account;
            //this.gpaGraph = new GPAGraph(account.something); TODO: Get from account
            this.gpaGraph = new GPAGraph(new List<DateTime>(), new List<double>());
            view.SetController(this);
        }

        public void SetUserInfo()
        {
            this.view.SetUserInfo(account.username, "UW Harvard", 3.9);
        }

        //---------------------------------------------------------------------
        // Draws a graph of grades in the course against time.
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public void DrawGPAGraph()
        {
            this.view.DrawGPAGraph(gpaGraph.GetXValues(), gpaGraph.GetYValues());
        }
    }
}
