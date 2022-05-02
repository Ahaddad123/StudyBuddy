using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.DataAccess;

namespace Study_Buddy.BusinessLogic
{
    public class AccountController
    {

        SQLite database = new SQLite();
        public static Account account { get; set; }

        public int createTables()
        {
            int success = database.createTables();

            return success;
        }

        public Boolean createAccount(string username, string password, string email, string firstname, string lastname, string gpa, string schoolname)
        {
            account = new Account(username, password, firstname, lastname, gpa, schoolname);
            account.readCourses();
            int acc = database.InsertAccountData(username, password, email, firstname, lastname, gpa, schoolname);

            if (acc == -1)
            {
                return false;
            }
            else
                return true;
        }

        public Boolean accountCreated(string username, string password)
        {
            string acc = database.checkAccount(username, password);

            if (acc == null)
            {
                return false;
            }
            else
            {
                string accpass = database.checkPassword(password);
                if (accpass == null)
                {
                    return false;
                }
                else
                {
                    account = new Account(username, password);
                    account.readCourses();
                    return true;
                }
            }
        }
    }
}
