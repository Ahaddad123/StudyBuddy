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

        public int checkAccount(String username, String password) 
        {
            int UserExists = 0;
            Boolean exists = false;

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();
            SQLiteCommand checkAccounts;
            checkAccounts = sqlite_conn.CreateCommand();

            String command = "SELECT * FROM AccountData WHERE(Username = '@username')";
            String command1 = command.Replace("@username", username);
            checkAccounts.CommandText = command1;
            UserExists = (int)checkAccounts.ExecuteNonQuery();
            return UserExists;
            
        }

        public int InsertAccountData(String username, String password,  String email) 
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();

            int success = 0;

            SQLiteCommand insertAccountDataa;
            insertAccountDataa = sqlite_conn.CreateCommand();

            String command = "INSERT INTO AccountData(Username, Password, Email) VALUES ('@username', '@password', '@email')";
            String command1 = command.Replace("@username", username).Replace("@password", password).Replace("@email", email);
            insertAccountDataa.CommandText = command1;
            success = insertAccountDataa.ExecuteNonQuery();

            return success;
        }

        
        




    }
}
