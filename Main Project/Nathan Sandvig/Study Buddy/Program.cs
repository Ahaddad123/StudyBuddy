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

            //---------------------------------------------------------------------
            // Creating the conection to the database then checking if tables have 
            // been created for the table, and if they have, do not recreate, move
            // on to open the application.
            //---------------------------------------------------------------------
            AccountController acc = new AccountController();
            acc.createTables();


            //AccountController.account = acc;

            //Launching GUI application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //HomePageForm form = new HomePageForm();
            //HomePageFormController controller = new HomePageFormController(form);
            //form.SetController(controller);
            LoginForm form = new LoginForm();
            form.StartPosition = FormStartPosition.Manual;
            Application.Run(form);

            System.Environment.Exit(0);

        }
    }
}
