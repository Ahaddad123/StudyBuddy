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
using System.Windows.Forms;

namespace Study_Buddy.DataAccess
{
    public class SQLite
    {

        //---------------------------------------------------------------------
        // Creating the connection to the database and if a database with that
        // name is not located then one will be created.
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        // Query for creating the tables in the database, in a try catch loop
        // so the program can continue if the tables have been created
        // already.
        //---------------------------------------------------------------------
        public int createTables()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();
            SQLiteCommand checkAccounts;
            checkAccounts = sqlite_conn.CreateCommand();

            try {

                String createTables = "CREATE TABLE \"AccountData\" (\"Username\"  TEXT NOT NULL, \"Password\"  TEXT NOT NULL, \"Email\" TEXT NOT NULL, \"UserID\"    INTEGER NOT NULL,PRIMARY KEY(\"UserID\" AUTOINCREMENT))";
                checkAccounts.CommandText = createTables;
                checkAccounts.ExecuteNonQuery();

                String createTables2 = "CREATE TABLE \"Assignments\" (\"CourseID\" INTEGER NOT NULL,\"CourseName\"   TEXT NOT NULL, \"AssignmentName\"   TEXT NOT NULL, \"AssignmentWeight\" REAL NOT NULL, \"Grade\" REAL, \"Points\" REAL NOT NULL, \"DueDate\" INTEGER, PRIMARY KEY(\"CourseID\" AUTOINCREMENT))";
                checkAccounts.CommandText = createTables2;
                checkAccounts.ExecuteNonQuery();

                String createTables3 = "CREATE TABLE \"Courses\"(\"CourseID\"   INTEGER NOT NULL, \"CourseName\"   TEXT NOT NULL, \"Credits\"   INTEGER NOT NULL, \"CourseCode\"   TEXT NOT NULL, PRIMARY KEY(\"CourseID\" AUTOINCREMENT))";
                checkAccounts.CommandText = createTables3;
                checkAccounts.ExecuteNonQuery();

                String createTables4 = "CREATE TABLE \"OverallGrades\"(\"User ID\" INTEGER NOT NULL)";
                checkAccounts.CommandText = createTables4;
                checkAccounts.ExecuteNonQuery();

                String createTables5 = "CREATE TABLE \"StudentInformation\"(\"StudentID\" INTEGER NOT NULL, \"FName\" TEXT NOT NULL, \"LName\" TEXT NOT NULL, \"GPA\" REAL NOT NULL, \"SchoolName\" TEXT NOT NULL, PRIMARY KEY(\"StudentID\" AUTOINCREMENT))";
                checkAccounts.CommandText = createTables5;
                checkAccounts.ExecuteNonQuery();

                String createTables6 = "CREATE TABLE \"StudyHours\" (\"Hours\" INTEGER NOT NULL, \"CourseName\" INTEGER NOT NULL, \"Date\" INTEGER NOT NULL)";
                checkAccounts.CommandText = createTables6;
                checkAccounts.ExecuteNonQuery();

                string createTables7 = "CREATE TABLE \"GPAData\" (\"Number\" INTEGER NOT NULL, \"GPA\" INTEGER NOT NULL, PRIMARY KEY(\"Number\" AUTO INCREMENT))";
                checkAccounts.CommandText = createTables7;
                checkAccounts.ExecuteNonQuery();

                string createTables8 = "CREATE TABLE \"ClassTimes\" (\"CourseID\" INTEGER NOT NULL, \"SundayStart\" TEXT, \"SundayEnd\" TEXT, \"MondayStart\" TEXT, \"MondayEnd\" TEXT, \"TuesdayStart\" TEXT, \"TuesdayEnd\" TEXT, \"WednesdayStart\" TEXT, \"WednesdayEnd\" TEXT, \"ThursdayStart\" TEXT, \"ThursdayEnd\" TEXT, \"FridayStart\" TEXT, \"FridayEnd\" TEXT, \"SaturdayStart\" TEXT, \"SaturdayEnd\" TEXT, PRIMARY KEY(CourseID))";
                checkAccounts.CommandText = createTables8;
                checkAccounts.ExecuteNonQuery();
            } 
            catch (System.Data.SQLite.SQLiteException) 
            {
                return -1;
            }

            return 1;
        }

        //---------------------------------------------------------------------
        // Query for checking if an account exists by username
        //---------------------------------------------------------------------
        public String checkAccount(String username, String password) 
        {
            int UserExists = 0;
            Boolean exists = false;
            String checkUser = "";

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
                    checkUser = hello.ToString();
            } 
            catch (SQLiteException e) 
            {
                return null;
            }

            return checkUser;
            
        }

        public string checkPassword(string password) {
            string checkPasswords;
            
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();
            SQLiteCommand checkAccounts;
            checkAccounts = sqlite_conn.CreateCommand();

            String command = "SELECT Password FROM AccountData WHERE(Password = '@password')";
            String command1 = command.Replace("@password", password);
            checkAccounts.CommandText = command1;

            try
            {
                Object hello = checkAccounts.ExecuteScalar();
                if (hello == null)
                {
                    return null;
                }
                else
                    checkPasswords = hello.ToString();
            }
            catch (SQLiteException e)
            {
                return null;
            }

            return checkPasswords;
        }
        //---------------------------------------------------------------------
        // Query for creating an account by inserting the account data into
        // the table.
        //---------------------------------------------------------------------
        public int InsertAccountData(string username, string password,  string email, string firstname, string lastname, string gpa, string schoolname) 
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

            string command2 = "INSERT INTO StudentInformation(Fname, LName, GPA, SchoolName) VALUES ('@first', '@last', '@gpa', '@schoolname')";
            string command3 = command2.Replace("@first", firstname).Replace("@last", lastname).Replace("@gpa", gpa).Replace("@schoolname", schoolname);
            insertAccountDataa.CommandText = command3;
            insertAccountDataa.ExecuteNonQuery();
            
            return success;
        }

        //---------------------------------------------------------------------
        // Query for inserting course data into the table
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        // Query for reading course data from the table and inserting it into
        // a returnable list
        //---------------------------------------------------------------------

        public List<String> readCourses()
        {
            List<String> courses = new List<String>();
            SQLiteDataReader sqlite_datareader;
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();

            SQLiteCommand letsRead = sqlite_conn.CreateCommand();
            letsRead.CommandText = "SELECT CourseName, Credits, CourseCode FROM Courses";

            sqlite_datareader = letsRead.ExecuteReader();

            while (sqlite_datareader.Read()) 
            {
                String course = sqlite_datareader.GetString(0);
                int credits = sqlite_datareader.GetInt32(1);
                String code = sqlite_datareader.GetString(2);
                courses.Add(course);
                courses.Add(credits + "");
                courses.Add(code);
            }

            return courses;
        }

        public List<String> readAssignments()
        {
            List<String> assignments = new List<String>();
            SQLiteDataReader sqlite_datareader;
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();

            SQLiteCommand letsRead = sqlite_conn.CreateCommand();
            letsRead.CommandText = "SELECT CourseName, AssignmentName, AssignmentWeight, Grade, Points, DueDate FROM Assignments";

            sqlite_datareader = letsRead.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                String course = sqlite_datareader.GetString(0);
                String assignment = sqlite_datareader.GetString(1);
                double weight = sqlite_datareader.GetDouble(2);
                double grade = sqlite_datareader.GetDouble(3);
                double points = sqlite_datareader.GetDouble(4);
                String date = sqlite_datareader.GetString(5);
                assignments.Add(course);
                assignments.Add(assignment);
                assignments.Add(weight + "");
                assignments.Add(grade + "");
                assignments.Add(points + "");
                assignments.Add(date);
            }

            return assignments;
        }

        //---------------------------------------------------------------------
        // Query for reading the students information and inserting it into a
        // returnable list
        //---------------------------------------------------------------------
        public List<string> readStudentInfo()
        {
            List<String> studentInfo = new List<String>();
            SQLiteDataReader sqlite_datareader;
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();

            SQLiteCommand studentData = sqlite_conn.CreateCommand();
            studentData.CommandText = "SELECT FName, LName, GPA, SchoolName FROM StudentInformation";
            sqlite_datareader = studentData.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                String studentFirstName = sqlite_datareader.GetString(0);
                String studentLastName = sqlite_datareader.GetString(1);
                double studentGpa = sqlite_datareader.GetDouble(2);
                String studentSchoolName = sqlite_datareader.GetString(3);
                studentInfo.Add(studentFirstName);
                studentInfo.Add(studentLastName);
                studentInfo.Add(studentGpa + "");
                studentInfo.Add(studentSchoolName);
            }

            return studentInfo;
        }

        //---------------------------------------------------------------------
        // Query for inserting logged study hours into the database
        //---------------------------------------------------------------------

        public void logStudyHours(String courses, DateTime date, String hours)
        {
            SQLiteConnection sqlite_conn = CreateConnection();

            SQLiteCommand addHours;
            addHours = sqlite_conn.CreateCommand();
            int value = readHour(courses, date) + Int32.Parse(hours);
            string command = "INSERT INTO StudyHours(Hours, CourseName, Date) VALUES ('@hours', '@coursename', '@datetime')";
            string command1 = command.Replace("@hours", hours).Replace("@coursename", courses).Replace("@datetime", date.ToString()).Replace("@value", value + "");

            addHours.CommandText = command1;
            addHours.ExecuteNonQuery();
        }

        public void addStudyHours(String course, DateTime date, String hours)
        {
            SQLiteConnection sqlite_conn = CreateConnection();

            SQLiteCommand removeHours;
            removeHours = sqlite_conn.CreateCommand();

            int value = readHour(course, date) + Int32.Parse(hours);

            string command = "UPDATE StudyHours SET Hours='@hours' WHERE CourseName = '@coursename' AND Date = '@date'";
            string command1 = command.Replace("@coursename", course).Replace("@hours", value + "").Replace("@date", date.ToString());

            removeHours.CommandText = command1;
            removeHours.ExecuteNonQuery();
        }

        public void removeStudyHours(String course, DateTime date, String hours)
        {
            SQLiteConnection sqlite_conn = CreateConnection();

            SQLiteCommand removeHours;
            removeHours = sqlite_conn.CreateCommand();

            int value = readHour(course, date) - Int32.Parse(hours);

            string command = "UPDATE StudyHours SET Hours='@hours' WHERE CourseName = '@coursename' AND Date = '@date'";
            string command1 = command.Replace("@coursename", course).Replace("@hours", value + "").Replace("@date", date.ToString());

            removeHours.CommandText = command1;
            removeHours.ExecuteNonQuery();
        }

        public int readHour(String course, DateTime date)
        {
            int studyHours = 0;
            SQLiteDataReader sqlite_datareader;
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();

            SQLiteCommand studentData = sqlite_conn.CreateCommand();
            string command = "SELECT Hours FROM StudyHours WHERE CourseName = '@coursename' AND Date = '@date'";
            string command1 = command.Replace("@coursename", course).Replace("@date", date.ToString());
            studentData.CommandText = command1;
            sqlite_datareader = studentData.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                int hours = sqlite_datareader.GetInt32(0);
                studyHours = hours;
            }

            return studyHours;
        }

        //---------------------------------------------------------------------
        // Query for reading the study hours and seperating them by week.
        //---------------------------------------------------------------------
        public List<string> readStudyHours()
        {
            List<String> studyHours = new List<String>();
            SQLiteDataReader sqlite_datareader;
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = CreateConnection();

            SQLiteCommand studentData = sqlite_conn.CreateCommand();
            studentData.CommandText = "SELECT Hours, CourseName, Date FROM StudyHours";
            sqlite_datareader = studentData.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                int hours = sqlite_datareader.GetInt32(0);
                String course = sqlite_datareader.GetString(1);
                String date = sqlite_datareader.GetString(2);
                studyHours.Add(hours + "");
                studyHours.Add(course);
                studyHours.Add(date);
            }

            return studyHours;
        }

        //---------------------------------------------------------------------
        // Query to remove a course from the course list
        //---------------------------------------------------------------------
        public void removeCourse(string courseName) 
        {
            SQLiteConnection sqlite_conn = CreateConnection();

            SQLiteCommand removeCourses;
            removeCourses = sqlite_conn.CreateCommand();

            string command = "DELETE FROM Courses WHERE CourseName = '@name'";
            string command1 = command.Replace("@name", courseName);
            removeCourses.CommandText = command1;
            
            removeCourses.ExecuteNonQuery();

            // Add queries for removing assignments for that course
        }

        //---------------------------------------------------------------------
        // Query for adding an assignment to the assignment list
        //---------------------------------------------------------------------
        public void addAssignment(string courseName, string assignmentName, string assignmentWeight, string grade, string points, string duedate) 
        {
            SQLiteConnection sqlite_conn = CreateConnection();

            SQLiteCommand addAssignment;
            addAssignment = sqlite_conn.CreateCommand();


            string command = "INSERT INTO Assignments(CourseName, AssignmentName, AssignmentWeight, Grade, Points, DueDate) VALUES ('@course', '@assignmentname','@assignmentweight', '@grade', '@points', '@duedate')";
            string command1 = command.Replace("@course", courseName).Replace("@assignmentname", assignmentName).Replace("@assignmentweight", assignmentWeight).Replace("@grade", grade).Replace("@points", points).Replace("@duedate", duedate);

            addAssignment.CommandText = command1;
            addAssignment.ExecuteNonQuery();
        }

        public void addGrade(string assignmentName, string grade)
        {
            SQLiteConnection sqlite_conn = CreateConnection();

            SQLiteCommand addGrade;
            addGrade = sqlite_conn.CreateCommand();

            string command = "UPDATE Assignments SET Grade='@grade' WHERE AssignmentName = '@assignmentname'";
            string command1 = command.Replace("@assignmentname", assignmentName).Replace("@grade", grade);

            addGrade.CommandText = command1;
            addGrade.ExecuteNonQuery();
        }

        public void addTimesCourse(Dictionary<DayOfWeek, (String startTime, String endTime)> times) 
        {

        }
    }
}
