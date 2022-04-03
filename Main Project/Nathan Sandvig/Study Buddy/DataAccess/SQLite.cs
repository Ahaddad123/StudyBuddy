using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
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
        static void main() 
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
            sqlite_conn = new SQLiteConnection("Data Source=NathansData.db; Version = 3; New = True; Compress = True; ");
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

        public static void InsertAccountData(SQLiteConnection sqlite_conn, String username, String password, int userid) 
        {
            SQLiteCommand insertAccountDataa;
            insertAccountDataa = sqlite_conn.CreateCommand();

            String command = "INSERT INTO AccountData(Username, Password, userid) VALUES (@username, @password, @userid)";
            insertAccountDataa.CommandText = command;
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

        public static void addAccount()
        {
            try
            {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "studybuddyserverintermediate2022.database.windows.net";
                cb.UserID = "ahaddad123";
                cb.Password = "Jiddo123";
                cb.InitialCatalog = "StudyBuddyDatabase";

                using (var connection = new SqlConnection(cb.ConnectionString))
                {
                    connection.Open();

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
