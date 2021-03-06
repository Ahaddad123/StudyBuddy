// Namespaces being used by default
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// The namespace the class is in
namespace Study_Buddy.BusinessLogic
{
    //-------------------------------------------------------------------------
    // This class manages course objects within an account
    // v1: Created the class - Nathan S, 3-6-22
    // v2: Created couresTimes - Andrew V, 4-12-22
    //-------------------------------------------------------------------------
    public class Course
    {
        //---------------------------------------------------------------------
        // Private data members
        // assignments: The assignments contained within the course
        // hourLog: The log of the hours studied for the course
        // name: The name of the course
        // grade: The grade the user currently has in the course
        // code: The code of the course
        // priority: How important the course is
        // credits: The number of credits the course is worth
        // courseTimes: days and times where you have class
        //---------------------------------------------------------------------
        public List<Assignment> assignments { get; set; }
        public StudyLog hourLog { get; set; }
        public string name { get; set; }
        public double grade { get; set; }
        public string code { get; set; }
        public double priority { get; set; }
        public double credits { get; set; }

        public CourseSchedule schedule { get; set; }

        //---------------------------------------------------------------------
        // Default constructor for the Course class
        // v1: Created the method - Nathan S, 3-6-22
        // v2: Created couresTimes - Andrew V, 4-12-22
        //---------------------------------------------------------------------
        public Course()
        {
            assignments = new List<Assignment>();
            hourLog = new StudyLog();
            this.name = "CourseName";
            this.grade = 100.0;
            this.code = "CourseCode";
            this.priority = -1.0;
            this.credits = 3.0;
        }

        //---------------------------------------------------------------------
        // Builder constructor for the Course class
        // v1: Created the method - Nathan S, 3-6-22
        // v2: Created couresTimes - Andrew V, 4-12-22
        //---------------------------------------------------------------------
        public Course(CourseBuilder builder)
        {
            assignments = new List<Assignment>();
            hourLog = new StudyLog();
            this.name = builder.name;
            this.grade = builder.grade;
            this.code = builder.code;
            this.priority = builder.priority;
            this.credits = builder.credits;
            this.schedule = builder.schedule;
        }

        //---------------------------------------------------------------------
        // Adds an assignment to the list of assignments
        // name: The name of the assignment
        // totalPoints: The point value of the assignment
        // weight: The weight of the assignment
        // v1: Created the method - Andrew V, 3-5-22
        //---------------------------------------------------------------------
        public void AddAssignment(Assignment newAssign)
        {
            foreach (Assignment a in this.assignments)
            {
                if (a.name.Equals(newAssign.name))
                {
                    return;
                }
            }
            assignments.Add(newAssign);
        }

        //---------------------------------------------------------------------
        // Removes an assignment from the list of assignments
        // name: The name of the assignment
        // retrn: True if the assignment was removed, false if not
        // v1: Created the method - Andrew V, 3-5-22
        // v2: Converted to remove-by-name - Nathan S, 3-6-22
        //---------------------------------------------------------------------
        public bool RemoveAssignment(string assignmentName)
        {
            // Initialize variables
            int index = -1;
            bool removed = false;

            // Find the index of the assignment
            for(int i = 0; i < assignments.Count; i++)
            {
                if (assignments[i].name == assignmentName)
                    index = i;
            }

            // Remove the assignment if it exists
            if(index != -1)
            {
                assignments.RemoveAt(index);
                removed = true;
            }

            return removed;
        }

        //---------------------------------------------------------------------
        // Adds a grade to an assignment
        // name: The name of the assignment
        // points: The points achieved on the assignment
        // v1: Created the method - Nathan S, 3-6-22
        //---------------------------------------------------------------------
        public void GradeAssignment(string name, double points)
        {
            int index = -1;
            for (int i = 0; i < assignments.Count; i++)
            {
                if (assignments[i].name == name)
                    index = i;
            }
            if(index != -1)
            {
                assignments[index].addGrade(points);
            }
        }

        //---------------------------------------------------------------------
        // Calculates the user's current grade in the course
        // return: The current grade as a double
        // v1: Created the method - Makenna H, 3-6-22
        //---------------------------------------------------------------------
        public double CalculateGrade()
        {
            // Initialize variables
            grade = 0.0;
            double totalPoints = 0.0;

            // Add the grade and weight of each assignment
            for(int i = 0; i < assignments.Count; i++)
            {
                grade += assignments[i].grade * assignments[i].weight;
                totalPoints += assignments[i].weight;
            }

            // Calculate the final grade
            if (totalPoints > 0)
                grade /= totalPoints;
            else
                grade = 100;

            return grade;
        }

        //---------------------------------------------------------------------
        // Adds more hours to the study log
        // time: The time spent studying in hours
        // v1: Created the method - Nathan S, 3-7-22
        //---------------------------------------------------------------------
        public void LogHours(double time, DateTime date)
        {
            //checks to see if a valid value of time was entered
            if(time < 0)
            {
                //returns if the time entered was invalid
                return;
            }
            //adds time to log if the value was valid
            hourLog.AddTimeToLog(time, date.Date);
        }

        public void RemoveHours(double time, DateTime date)
        {
            //checks to see if a valid value of time was entered
            if (time < 0)
            {
                //returns if the time entered was invalid
                return;
            }
            //removes time from log if the value was valid
            hourLog.RemoveTimeFromLog(time, date.Date);
        }

        //---------------------------------------------------------------------
        // Finds the number of hours studied on a given day
        // day: The date being checked for hours studied
        // return: The number of hours studied that day
        // v1: Created the method - Nathan S, 3-7-22
        //---------------------------------------------------------------------
        public double GetHoursStudied(DateTime date)
        {
            return hourLog.GetHours(date.Date);
        }
    }
}
