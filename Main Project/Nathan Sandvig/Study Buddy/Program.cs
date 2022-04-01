using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.Presentation;
using Study_Buddy.DataAccess;

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
            SQLite db = new SQLite();
            SQLiteConnection sqlite_connection;
            sqlite_connection = db.CreateConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HomePageForm form = new HomePageForm();
            form.StartPosition = FormStartPosition.Manual;
            Application.Run(form);
        }
    }
}
