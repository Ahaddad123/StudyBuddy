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

        public void readCourses() 
        {
            List<String> list = new List<String>();
            list = database.readCourses();

            foreach(String courseName in list)
            {
                populateCourses(new CourseBuilder().WithName(courseName).Build());
            }
        }

        //---------------------------------------------------------------------
        // Adds a course to the account
        // course: The course data being passed from the controller
        // v1: Created the method - Nathan S, 3-7-22
        //---------------------------------------------------------------------
        public void addCourse(Course course)
        {
            foreach(Course c in this.courses)
            {
                if (c.name.Equals(course.name))
                {
                    return;
                }
            }
            courses.Add(course);
            int success = database.insertCourseData(course);
        }

        public void populateCourses(Course course)
        {
            foreach (Course c in this.courses)
            {
                if (c.name.Equals(course.name))
                {
                    return;
                }
            }
            courses.Add(course);
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

        public void addAssignment(string coursename, string name, string grade, string weight,  string duedate) 
        {
            database.addAssignment(coursename, name, grade, weight, duedate);
        }
    }
}
