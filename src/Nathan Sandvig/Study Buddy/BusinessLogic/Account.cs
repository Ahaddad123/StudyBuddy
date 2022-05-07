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
    //---------------------------------------------------------------------
    // Holds all data needed to use Study Buddy and makes calls to SQLite
    // read and write data to the database.
    //---------------------------------------------------------------------
    public class Account
    {
        public string username;
        public string password;
        public string firstName;
        public string lastName;
        public string GPA1;
        public string schoolName;
        public SQLite database = new SQLite();
        public List<Course> courses { get; set; } = new List<Course>();

        //---------------------------------------------------------------------
        // Default Constructor for Account
        //---------------------------------------------------------------------
        public Account() { }

        //---------------------------------------------------------------------
        // Constructor for Account that initializes student information
        //---------------------------------------------------------------------
        public Account(string nameuser, string pass, string fname, string lname, string gpa, string sname) {
            username = nameuser;
            password = pass;
            firstName = fname;
            lastName = lname;
            GPA1 = gpa;
            schoolName = sname;
        }

        //---------------------------------------------------------------------
        // Constructor for Account the initializes username and password
        //---------------------------------------------------------------------
        public Account(String newUsername, String newPassword){
            username = newUsername;
            password = newPassword;
        }

        //---------------------------------------------------------------------
        // Populates local data with data from the database
        //---------------------------------------------------------------------
        public void populateLocalData() 
        {
            populateCourseList(database.readCourses());
            populateAssignments(database.readAssignments());
            populateStudyHours(database.readStudyHours());
            populateSchedules(database.readTimesCourse());
            populateStudentInfo(database.readStudentInfo());  
        }

        //---------------------------------------------------------------------
        // Adds a course to the account
        // course: The course data being passed from the controller
        // v1: Created the method - Nathan S, 3-7-22
        //---------------------------------------------------------------------
        public void addCourse(Course course)
        {
            populateCourse(course);
            int success = database.insertCourseData(course);
        }

        //---------------------------------------------------------------------
        // Populates the list of courses in Account
        // courseData: list of course data from the database
        //---------------------------------------------------------------------
        public void populateCourseList(List<String> courseData)
        {
            for (int i = 0; i < courseData.Count; i += 3)
            {
                populateCourse(new CourseBuilder().WithName(courseData.ElementAt(i)).WithCredits(Double.Parse(courseData.ElementAt(i + 1))).WithCode(courseData.ElementAt(i + 2)).WithSchedule(new CourseSchedule()).Build());
            }
        }

        //---------------------------------------------------------------------
        // Adds study hours logged in the database to the specified Courses in Account
        // studyHourData: list of study hour data from the database
        //---------------------------------------------------------------------
        public void populateStudyHours(List<String> studyHourData)
        {
            for (int i = 0; i < studyHourData.Count; i += 3)
            {
                foreach (Course course in courses)
                {
                    if (course.name.Equals(studyHourData.ElementAt(i + 1)))
                    {
                        course.LogHours(Int32.Parse(studyHourData.ElementAt(i)), DateTime.Parse(studyHourData.ElementAt(i + 2)));
                    }
                }
            }
        }

        //---------------------------------------------------------------------
        // Sets the schedule of the Course objects in Account
        // scheduleData: list of course time data from the database
        //---------------------------------------------------------------------
        public void populateSchedules(List<String> scheduleData)
        {
            for (int i = 0; i < scheduleData.Count; i += 15)
            {
                foreach (Course course in courses)
                {
                    if (course.name.Equals(scheduleData.ElementAt(i)))
                    {
                        Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)> times;
                        times = new Dictionary<DayOfWeek, (DateTime startTime, DateTime endTime)>();
                        if (!scheduleData.ElementAt(i + 1).Equals("null"))
                        {
                            times.Add(DayOfWeek.Sunday, (DateTime.Parse(scheduleData.ElementAt(i + 1)), DateTime.Parse(scheduleData.ElementAt(i + 2))));
                        }
                        if (!scheduleData.ElementAt(i + 3).Equals("null"))
                        {
                            times.Add(DayOfWeek.Monday, (DateTime.Parse(scheduleData.ElementAt(i + 3)), DateTime.Parse(scheduleData.ElementAt(i + 4))));
                        }
                        if (!scheduleData.ElementAt(i + 5).Equals("null"))
                        {
                            times.Add(DayOfWeek.Tuesday, (DateTime.Parse(scheduleData.ElementAt(i + 5)), DateTime.Parse(scheduleData.ElementAt(i + 6))));
                        }
                        if (!scheduleData.ElementAt(i + 7).Equals("null"))
                        {
                            times.Add(DayOfWeek.Wednesday, (DateTime.Parse(scheduleData.ElementAt(i + 7)), DateTime.Parse(scheduleData.ElementAt(i + 8))));
                        }
                        if (!scheduleData.ElementAt(i + 9).Equals("null"))
                        {
                            times.Add(DayOfWeek.Thursday, (DateTime.Parse(scheduleData.ElementAt(i + 9)), DateTime.Parse(scheduleData.ElementAt(i + 10))));
                        }
                        if (!scheduleData.ElementAt(i + 11).Equals("null"))
                        {
                            times.Add(DayOfWeek.Friday, (DateTime.Parse(scheduleData.ElementAt(i + 11)), DateTime.Parse(scheduleData.ElementAt(i + 12))));
                        }
                        if (!scheduleData.ElementAt(i + 13).Equals("null"))
                        {
                            times.Add(DayOfWeek.Saturday, (DateTime.Parse(scheduleData.ElementAt(i + 13)), DateTime.Parse(scheduleData.ElementAt(i + 14))));
                        }
                        course.schedule = new CourseSchedule(times);
                    }
                }
            }
        }

        //---------------------------------------------------------------------
        // Populates the student info in Account
        // studentInfoData: list of student info data from the database
        //---------------------------------------------------------------------
        public void populateStudentInfo(List<String> studentInfoData)
        {
            for (int i = 0; i < studentInfoData.Count; i += 4)
            {
                this.firstName = studentInfoData.ElementAt(i);
                this.lastName = studentInfoData.ElementAt(i + 1);
                this.GPA1 = studentInfoData.ElementAt(i + 2);
                this.schoolName = studentInfoData.ElementAt(i + 3);
            }
        }

        //---------------------------------------------------------------------
        // Adds a Course object to the local data in Account
        // course: Course object to be added
        //---------------------------------------------------------------------
        public void populateCourse(Course course)
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
        // Populates the assignments in the specified Course in Account
        // assignmentData: list of assignment data from the database
        //---------------------------------------------------------------------
        public void populateAssignments(List<String> assignmentData)
        {
            for (int i = 0; i < assignmentData.Count; i += 6)
            {
                foreach (Course course in courses)
                {
                    if (course.name.Equals(assignmentData.ElementAt(i)))
                    {
                        Assignment assignment = new Assignment(Int32.Parse(assignmentData.ElementAt(i + 4)), assignmentData.ElementAt(i + 1), Int32.Parse(assignmentData.ElementAt(i + 2)), DateTime.Parse(assignmentData.ElementAt(i + 5)));
                        course.AddAssignment(assignment);
                        course.GradeAssignment(assignment.name, Double.Parse(assignmentData.ElementAt(i + 3)));
                    }
                }
            }
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

        //---------------------------------------------------------------------
        // Adds study hours to the specified Course
        // course: name of the course that the hours were logged for
        // date: date the study hours were completed
        // hours: number of hours studied
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        // Removes study hours from the specified Course
        // course: name of the course to remove the hours from
        // date: date the study hours need to be removed from
        // hours: number of hours studied to be removed
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        // Adds grade to the specified Assignment
        // coursename: name of the course that the assigment is in
        // assignmentname: name of the assignment the grade is for
        // hours: grade received on the assignment
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        // Removes grade from the specified Assignment
        // coursename: name of the course that the assigment is in
        // assignmentname: name of the assignment to remove the grade from
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        // Gets the Course object with the specified name
        // coursename: name of the course to be returned
        // return: the Course object
        //---------------------------------------------------------------------
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
