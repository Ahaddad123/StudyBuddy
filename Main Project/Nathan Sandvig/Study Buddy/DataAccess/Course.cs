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

        public void AddAssigment(string assignName, int assignPoint, int assignPriority)
        {
            Assignment temp = new Assignment(assignPoint, assignName, assignPriority);
            //wip add assignments based on priority
            assignments.Add(temp);
        }

        public void RemoveAssignment(string assignName, int assignPoint, int assignPriority)
        {
            Assignment temp = new Assignment(assignPoint, assignName, assignPriority);

            assignments.Remove(temp);
        }
    }
}
