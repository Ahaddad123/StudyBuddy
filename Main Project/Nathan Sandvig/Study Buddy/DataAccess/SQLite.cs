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
using Study_Buddy.BusinessLogic;

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

        public int createTables()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();
            SQLiteCommand checkAccounts;
            checkAccounts = sqlite_conn.CreateCommand();

            try {
                String createTables = "CREATE TABLE \"AccountData\" (\"Username\"  INTEGER NOT NULL, \"Password\"  TEXT NOT NULL, \"Email\" TEXT NOT NULL, \"UserID\"    INTEGER NOT NULL,PRIMARY KEY(\"UserID\" AUTOINCREMENT))";
                checkAccounts.CommandText = createTables;

                checkAccounts.ExecuteNonQuery();

                String createTables2 = "CREATE TABLE \"Assignments\" (\"Course Code\"   TEXT NOT NULL, \"Assignment Name\"   TEXT NOT NULL,\"Assignment Weight\" REAL NOT NULL, \"Grade\" REAL, \"Course ID\" INTEGER, PRIMARY KEY(\"Course Code\"))";
                checkAccounts.CommandText = createTables2;
                checkAccounts.ExecuteNonQuery();

                String createTables3 = "CREATE TABLE \"Courses\"(\"Course Name\"   TEXT NOT NULL, \"Course ID\"   INTEGER NOT NULL, \"Credits\"   INTEGER NOT NULL, \"Course Code\"   TEXT NOT NULL, PRIMARY KEY(\"Course ID\"))";
                checkAccounts.CommandText = createTables3;
                checkAccounts.ExecuteNonQuery();

                String createTables4 = "CREATE TABLE \"Overall Grades\"(\"User ID\" INTEGER NOT NULL)";
                checkAccounts.CommandText = createTables4;
                checkAccounts.ExecuteNonQuery();

                String createTables5 = "CREATE TABLE \"Student Information\"(\"FName\" TEXT NOT NULL, \"LName\" TEXT NOT NULL, \"GPA\" REAL NOT NULL, \"School Name\" TEXT NOT NULL, \"Student ID\" INTEGER NOT NULL, PRIMARY KEY(\"Student ID\"))";
                checkAccounts.CommandText = createTables5;
                checkAccounts.ExecuteNonQuery();

                String createTables6 = "CREATE TABLE \"StudyHours\" (\"Hours\" INTEGER NOT NULL, \"Course ID\" INTEGER NOT NULL, \"Date\" INTEGER NOT NULL)";
                checkAccounts.CommandText = createTables6;
                checkAccounts.ExecuteNonQuery();
            } 
            catch (System.Data.SQLite.SQLiteException) 
            {
                return -1;
            }

            return 1;
        }

        public String checkAccount(String username, String password) 
        {
            int UserExists = 0;
            Boolean exists = false;
            String usernamebro = "";

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();
            SQLiteCommand checkAccounts;
            checkAccounts = sqlite_conn.CreateCommand();

            String command = "SELECT * FROM AccountData WHERE(Username = '@username')";
            String command1 = command.Replace("@username", username);
            checkAccounts.CommandText = command1;

            try 
            {
                Object hello = checkAccounts.ExecuteScalar();
                if (hello == null)
                {
                    return null;
                }
                else
                    usernamebro = hello.ToString();
            } 
            catch (SQLiteException e) 
            {
                return null;
            }

            return usernamebro;
            
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

        public int insertCourseData(Course course)
        {
            int success = 0;

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();
            
            SQLiteCommand addCourses;
            addCourses = sqlite_conn.CreateCommand();
            String credits = course.credits.ToString();

            String command = "INSERT INTO Courses(CourseName, Credits, CourseCode) VALUES ('@name', @credits, '@code')";
            String command1 = command.Replace("@name", course.name).Replace("@credits", credits).Replace("@code", course.code);

            addCourses.CommandText = command1;
            addCourses.ExecuteNonQuery();

            return success;
        }

        public List<String> readCourses()
        {
            List<String> courses = new List<String>();
            SQLiteDataReader sqlite_datareader;
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();

            SQLiteCommand letsRead = sqlite_conn.CreateCommand();
            letsRead.CommandText = "SELECT Course Name FROM Courses";

            sqlite_datareader = letsRead.ExecuteReader();

            while (sqlite_datareader.Read()) 
            {
                String course = sqlite_datareader.GetString(0);
                courses.Add(course);

            }

            return courses;
        }

        public List<string> readStudentInfo()
        {
            List<String> studentInfo = new List<String>();
            SQLiteDataReader sqlite_datareader;
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();

            SQLiteCommand studentData = sqlite_conn.CreateCommand();
            studentData.CommandText = "SELECT * Name FROM StudentInformation";
            sqlite_datareader = studentData.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                String student = sqlite_datareader.GetString(0);
                studentInfo.Add(student);
            }

            return studentInfo;
        }
    }
}
