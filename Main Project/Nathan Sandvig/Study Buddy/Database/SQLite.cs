using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Database
{
    internal class SQLite
    {
        public SQLiteConnection CreateConnection() {
            SQLiteConnection sqlite_connection;
            // Create a new database connection:
            sqlite_connection = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
         // Open the connection:
         try
            {
                sqlite_connection.Open();
                Console.WriteLine("Connection opened?");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Failed.");
            }
            return sqlite_connection;
        }

    }
}
