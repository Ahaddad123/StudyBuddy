// Namespaces being used by default
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// The namespace the class is in
namespace Study_Buddy.DataAccess
{
    //-------------------------------------------------------------------------
    // This class manages course objects within an account
    // v1: Created the class - Nathan S, 3-6-22
    //-------------------------------------------------------------------------
    public class Course
    {
        //---------------------------------------------------------------------
        // Private data members
        // assignments: The assignments contained within the course
        // name: The name of the course
        // grade: The grade the user currently has in the course
        // code: The code of the course
        // priority: How important the course is
        // credits: The number of credits the course is worth
        //---------------------------------------------------------------------
        private List<Assignment> assignments;
        public String name { get; set; }
        public double grade { get; set; }
        public String code { get; set; }
        public double priority { get; set; }
        public double credits { get; set; }

        //---------------------------------------------------------------------
        // Default constructor for the Course class
        // v1: Created the method - Nathan S, 3-6-22
        //---------------------------------------------------------------------
        public Course()
        {
            assignments = new List<Assignment>();
            this.name = "CourseName";
            this.grade = 100.0;
            this.code = "CourseCode";
            this.priority = -1.0;
            this.credits = 3.0;
        }

        //---------------------------------------------------------------------
        // Builder constructor for the Course class
        // v1: Created the method - Nathan S, 3-6-22
        //---------------------------------------------------------------------
        public Course(CourseBuilder builder)
        {
            assignments = new List<Assignment>();
            this.name = builder.name;
            this.grade = builder.grade;
            this.code = builder.code;
            this.priority = builder.priority;
            this.credits = builder.credits;
        }

        //---------------------------------------------------------------------
        // Adds an assignment to the list of assignments
        // name: The name of the assignment
        // points: The point value of the assignment
        // priority: The priority of the assignment
        // v1: Created the method - Andrew V, 3-5-22
        //---------------------------------------------------------------------
        public void AddAssigment(string name, int points, int priority)
        {
            Assignment temp = new Assignment(points, name, priority);
            //wip add assignments based on priority
            assignments.Add(temp);
        }

        //---------------------------------------------------------------------
        // Removes an assignment from the list of assignments
        // name: The name of the assignment
        // retrn: True if the assignment was removed, false if not
        // v1: Created the method - Andrew V, 3-5-22
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
        // Calculates the user's current grade in the course
        // return: The current grade as a double
        // v1: Created the method - Nathan S, 3-6-22
        //---------------------------------------------------------------------
        public double CalculateGrade()
        {
            double points = 0.0;
            double totalPoints = 0.0;
            for(int i = 0; i < assignments.Count; i++)
            {
                points += assignments[i].gradePoints;
                totalPoints += assignments[i].points;
            }
            grade = 100.0 * points / totalPoints;
            return grade;
        }
    }
}
