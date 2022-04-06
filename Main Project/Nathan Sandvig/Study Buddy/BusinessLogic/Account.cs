using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.DataAccess;

namespace Study_Buddy.BusinessLogic
{
    public class Account
    {
        internal String username; //Login username
        internal String password; //Login password
        //internal int userID; //This is the ID for the database to track accounts
        SQLite database = new SQLite();

        public List<Course> courses { get; set; } = new List<Course>();

        public Account() { }

        public Account(String newUsername, String newPassword){
            username = newUsername;
            password = newPassword;
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

        public int createTables() 
        {
            int success = database.createTables();

            return success;
        }

        public Boolean createAccount(String username, String password, String email, string firstname, string lastname, string gpa, string schoolname)
        {
            //int success = database.createTables();

            int acc = database.InsertAccountData(username, password, email, firstname, lastname, gpa, schoolname);

            if (acc == -1)
            {
                return false;
            }
            else
                return true;
        }

        public void readCourses() 
        {
            List<String> courses = new List<String>();
            courses = database.readCourses();
        }

        //---------------------------------------------------------------------
        // Adds a course to the account
        // course: The course data being passed from the controller
        // v1: Created the method - Nathan S, 3-7-22
        //---------------------------------------------------------------------
        public void addCourse(Course course) 
        {
            courses.Add(course);
            int success = database.insertCourseData(course);
        }

        //---------------------------------------------------------------------
        // Removes a course from the account
        // courseName: The name of the course being removed
        // return: True if the course was removed, false if not
        // v1: Created the method - Nathan S, 3-7-22
        //---------------------------------------------------------------------
        public bool removeCourse(string courseName) 
        {
            // Initialize variables
            int index = -1;
            bool removed = false;

            // Find the index of the assignment
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].name == courseName)
                    index = i;
            }

            // Remove the assignment if it exists
            if (index != -1)
            {
                courses.RemoveAt(index);
                removed = true;
            }

            return removed;
        }

        public void addStudyHours(String courses, DateTimePicker date, String hours) 
        {
            database.logStudyHours(courses, date, hours);
        }
    }
}
