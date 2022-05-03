using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Dapper;
using Study_Buddy.BusinessLogic;
using Study_Buddy.DataAccess;


//using System.Windows.Forms;

namespace Nathans_Unit_Test
{
    class MockDatabase : SQLite
    {

        public override SQLiteConnection CreateConnection()
        {
            return null;
        }

        //---------------------------------------------------------------------
        // Query for checking if an account exists by username
        //---------------------------------------------------------------------
        public override String checkAccount(String username, String password)
        {
            return "";
        }
        public override int createTables()
        {
            return 1;
        }

        //---------------------------------------------------------------------
        // Query for checking if an account exists by password
        //---------------------------------------------------------------------
        public override string checkPassword(string password)
        {
            return "";
        }
        //---------------------------------------------------------------------
        // Query for creating an account by inserting the account data into
        // the table.
        //---------------------------------------------------------------------
        public override int InsertAccountData(string username, string password, string email, string firstname, string lastname, string gpa, string schoolname)
        {
            return 1;
        }

        //---------------------------------------------------------------------
        // Query for inserting course data into the table
        //---------------------------------------------------------------------
        public override int insertCourseData(Course course)
        {
            return 1;
        }

        //---------------------------------------------------------------------
        // Query for reading course data from the table and inserting it into
        // a returnable list
        //---------------------------------------------------------------------

        public override List<String> readCourses()
        {
            return new List<String>();
        }

        //---------------------------------------------------------------------
        // Query for reading assignment data from the table and inserting it into
        // a returnable list
        //---------------------------------------------------------------------
        public override List<String> readAssignments()
        {
            return new List<String>();
        }

        //---------------------------------------------------------------------
        // Query for reading the students information and inserting it into a
        // returnable list
        //---------------------------------------------------------------------
        public override List<string> readStudentInfo()
        {
            return new List<String>();
        }

        //---------------------------------------------------------------------
        // Query for inserting logged study hours into the database
        //---------------------------------------------------------------------

        public override void logStudyHours(String courses, DateTime date, String hours)
        {

        }

        //---------------------------------------------------------------------
        // Query for adding logged study hours to an existing entry in
        // the database
        //---------------------------------------------------------------------
        public override void addStudyHours(String course, DateTime date, String hours)
        {

        }

        //---------------------------------------------------------------------
        // Query for removing logged study hours from an existing entry
        // in the database
        //---------------------------------------------------------------------
        public override void removeStudyHours(String course, DateTime date, String hours)
        {
        }

        //---------------------------------------------------------------------
        // Query for readin the current number of logged hours in a
        // specific entry in the database.
        //---------------------------------------------------------------------
        public override int readHour(String course, DateTime date)
        {
            return 1;
        }

        //---------------------------------------------------------------------
        // Query for reading the study hours and seperating them by week.
        //---------------------------------------------------------------------
        public override List<string> readStudyHours()
        {
            return new List<String>();
        }

        //---------------------------------------------------------------------
        // Query to remove a course from the course list
        //---------------------------------------------------------------------
        public override void removeCourse(string courseName)
        {
        }

        //---------------------------------------------------------------------
        // Query for adding an assignment to the assignment list
        //---------------------------------------------------------------------
        public override void addAssignment(string courseName, string assignmentName, string assignmentWeight, string grade, string points, string duedate)
        {
        }

        //---------------------------------------------------------------------
        // Query for adding a grade to an existing assignment to the
        // assignment list.
        //---------------------------------------------------------------------
        public override void addGrade(string assignmentName, string grade)
        {
        }

        //---------------------------------------------------------------------
        // Query adding course times to the database.
        //---------------------------------------------------------------------
        public override void addTimesCourse(Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times, string courseName)
        {
        }

        //---------------------------------------------------------------------
        // Query for removing an entry from the course times table.
        //---------------------------------------------------------------------
        public override void removeTimesCourse(string courseName)
        {

        }

        //---------------------------------------------------------------------
        // Query for reading course times data from the table and inserting
        // it into a returnable list
        //---------------------------------------------------------------------
        public override List<String> readTimesCourse()
        {
            return new List<String>();
        }
    }
}
