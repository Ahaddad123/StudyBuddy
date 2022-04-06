using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.Presentation;
using Study_Buddy.DataAccess;
using Study_Buddy.Presentation.View;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Account acc = new Account();
            acc.createTables();

            //Launching GUI application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //HomePageForm form = new HomePageForm();
            //HomePageFormController controller = new HomePageFormController(form);
            //form.SetController(controller);
            LoginForm form = new LoginForm();
            form.StartPosition = FormStartPosition.Manual;
            Application.Run(form);
        }
    }
}
