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
    //---------------------------------------------------------------------
    // controller for userinfo form
    //---------------------------------------------------------------------
    internal class UserInfoFormController : FormController
    {
        private Account account { get; set; }  //sets the account where the gpa will gets its data
        private GPAGraph gpaGraph;             //gpa graph of the form
        //---------------------------------------------------------------------
        // paramaterized constructor for controller
        // form: current form of the controller
        // account: account that the data for controller will be pulled from
        //---------------------------------------------------------------------
        public UserInfoFormController(UserInfoForm form, Account account)
        {
            this.view = form;
            this.account = account;
            this.gpaGraph = new GPAGraph(new List<DateTime>(), new List<double>());
            view.SetController(this);
        }

        //---------------------------------------------------------------------
        // sets user info to the data of account
        //---------------------------------------------------------------------
        public void SetUserInfo()
        {
            ((UserInfoForm)(this.view)).DisplayUserInfo(account.firstName, account.lastName, account.schoolName, account.GPA1);
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
