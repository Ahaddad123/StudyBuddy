using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Configuration;
using Dapper;

namespace Study_Buddy.DataAccess
{
    public class SQLite
    {
        public static void main() 
        {
            SQLite db = new SQLite();
            SQLiteConnection sqlite_connection;
            sqlite_connection = db.CreateConnection();
        }
        public static List<BusinessLogic.Account> LoadAccount() 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) 
            {
                var output = cnn.Query<BusinessLogic.Account>("SELECT * FROM AccountData", new DynamicParameters());
                return output.ToList();
            }
        }

        public SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        public static void addAccount(BusinessLogic.Account account1) 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO AccountData (Username, Password, UserID) values (@Username, @Password, @UserID)", account1);
            }
        }

        private static string LoadConnectionString(string id = "Default") 
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public Boolean InsertAccountData(String username, String password) {
            Boolean result = false;

            // Insert username and password into table for account information, potentially add more needed information later on

            return result;
        }

        public Boolean CheckAccountUsername(String username) {
            Boolean result = false;

            // Query username data against database to see if it exists / is the right username

            return result;
        }

        public Boolean CheckAccountPassword(String password) {
            Boolean result = false;

            // Query password data against database to see if it is the right password

            return result;
        }

        public Boolean InsertAssignment() {
            Boolean result = false;

            return result;
        }

        public Boolean InsertGrade() {
            Boolean result = false;

            return result;
        }

        public Boolean InsertCourse() { 
            Boolean result = false;

            return result;
        }

        public Boolean RemoveCourse() {
            Boolean result = false;

            // Remove course from the course table

            result = RemoveCourseData();
            return result;
        }

        public Boolean RemoveCourseData() {
            Boolean result = false;

            // Add code to remove the course data from all the tables

            return result;
        }



    }
}
