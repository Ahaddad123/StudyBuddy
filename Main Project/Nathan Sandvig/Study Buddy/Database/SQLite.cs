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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Failed.");
            }
            return sqlite_connection;
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
