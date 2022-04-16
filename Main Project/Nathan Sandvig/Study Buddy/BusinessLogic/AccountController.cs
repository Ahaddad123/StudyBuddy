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
        Account accountData = new Account();
        public static Account account { get; set; }

        public int createTables()
        {
            int success = database.createTables();

            return success;
        }

        public Boolean createAccount(String username, String password, String email, string firstname, string lastname, string gpa, string schoolname)
        {
            accountData = new Account(firstname, lastname, gpa, schoolname);
            int acc = database.InsertAccountData(username, password, email, firstname, lastname, gpa, schoolname);

            if (acc == -1)
            {
                return false;
            }
            else
                return true;
        }

        public Boolean accountCreated(String username, String password)
        {
            String acc = database.checkAccount(username, password);
            if (acc == null)
            {
                return false;
            }
            else
                return true;
        }
    }
}
