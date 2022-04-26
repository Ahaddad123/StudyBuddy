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
            for(int i = 0; i < list2.Count; i += 6)
            {
                foreach(Course course in courses)
                {
                    if (course.name.Equals(list2.ElementAt(i)))
                    {
                        Assignment assignment = new Assignment(Int32.Parse(list2.ElementAt(i+4)), list2.ElementAt(i + 1), Int32.Parse(list2.ElementAt(i + 2)), DateTime.Parse(list2.ElementAt(i+5)));
                        course.AddAssignment(assignment);
                        course.GradeAssignment(assignment.name, Double.Parse(list2.ElementAt(i + 3)));
                    }
                }
            }

            List<String> list3;
            list3 = database.readStudyHours();
            for (int i = 0; i < list3.Count; i += 3)
            {
                foreach (Course course in courses)
                {
                    if (course.name.Equals(list3.ElementAt(i+1)))
                    {
                        course.LogHours(Int32.Parse(list3.ElementAt(i)), DateTime.Parse(list3.ElementAt(i + 2)));
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

        public void addCourseTimes(Dictionary<DayOfWeek, (String startTime, String endTime)> times)
        {
            database.addTimesCourse(Dictionary < DayOfWeek, (String startTime, String endTime) > times);
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
                database.removeCourse(courseName);
                removed = true;
            }

            return removed;
        }

        public void addStudyHours(String course, DateTime date, double hours) 
        {
            foreach (Course c in this.courses)
            {
                if (c.name.Equals(course))
                {
                    if (c.hourLog.Log.ContainsKey(date.Date))
                    {
                        database.addStudyHours(course, date.Date, hours + "");
                    }
                    else
                    {
                        database.logStudyHours(course, date.Date, hours + "");
                    }
                    c.LogHours(hours, date.Date);
                }
            }
        }

        public void removeStudyHours(String course, DateTime date, double hours)
        {
            foreach (Course c in this.courses)
            {
                if (c.name.Equals(course))
                {
                    c.RemoveHours(hours, date.Date);
                }
            }
            database.removeStudyHours(course, date.Date, hours + "");
        }

        public void addAssignment(string coursename, string name, string grade, string weight, string points, string duedate) 
        {
            database.addAssignment(coursename, name, weight, grade, points, duedate);
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

        public void removeGrade(string coursename, string assignmentname)
        {
            foreach(Course c in this.courses)
            {
                if (c.name.Equals(coursename))
                {
                    c.GradeAssignment(assignmentname, 0);
                    database.addGrade(assignmentname, 0 + "");
                }
            }
        }

        public List<String> getStudentInfo()
        {
            return database.readStudentInfo();
        }

        public Course getCourseByName(String courseName)
        {
            foreach(Course course in this.courses)
            {
                if (course.name.Equals(courseName))
                {
                    return course;
                }
            }
            return null;
        }
    }
}
