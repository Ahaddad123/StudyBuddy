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
        internal string username; //Login username
        internal string password; //Login password
        internal string fname;
        internal string lname;
        internal string GPA1;
        internal string sName;
        //internal int userID; //This is the ID for the database to track accounts
        SQLite database = new SQLite();

        public List<Course> courses { get; set; } = new List<Course>();

        public Account() { }

        public Account(string nameuser, string pass, string firstName, string lastName, string gpa, string schoolName) {
            username = nameuser;
            password = pass;
            fname = firstName;
            lname = lastName;
            GPA1 = gpa;
            sName = schoolName;
        }

        public Account(String newUsername, String newPassword){
            username = newUsername;
            password = newPassword;
        }

        public void readCourses() 
        {
            List<String> list;
            list = database.readCourses();
            for(int i = 0; i < list.Count; i+=3)
            {
                populateCourses(new CourseBuilder().WithName(list.ElementAt(i)).WithCredits(Double.Parse(list.ElementAt(i+1))).WithCode(list.ElementAt(i+2)).Build());
            }

            List<String> list2;
            list2 = database.readAssignments();
            for(int i = 0; i < list2.Count; i += 5)
            {
                foreach(Course course in courses)
                {
                    if (course.name.Equals(list2.ElementAt(i)))
                    {
                        Assignment assignment = new Assignment(0, list2.ElementAt(i + 1), Int32.Parse(list2.ElementAt(i + 2)), DateTime.Today);
                        course.AddAssignment(assignment);
                        course.GradeAssignment(assignment.name, Double.Parse(list2.ElementAt(i + 3)));
                    }
                }
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
            database.addAssignment(coursename, name, weight, grade, duedate);
        }

        public void addGrade(string coursename, string assignmentname, double grade)
        {
            foreach (Course c in this.courses)
            {
                if (c.name.Equals(coursename))
                {
                    c.GradeAssignment(assignmentname, grade);
                    database.addGrade(assignmentname, grade + "");
                }
            }
        }

        public void getAccountData()
        {

        }
    }
}
