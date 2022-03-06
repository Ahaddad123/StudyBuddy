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
    internal class Course
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
        private String name;
        private double grade;
        private String code;
        private double priority;
        private double credits;

        //---------------------------------------------------------------------
        // This class is a builder class for Courses
        // v1: Created the class - Nathan S, 3-6-22
        //---------------------------------------------------------------------
        public class CourseBuilder
        {
            //-----------------------------------------------------------------
            // Private data members
            // name: The name of the course
            // grade: The grade the user currently has in the course
            // code: The code of the course
            // priority: How important the course is
            // credits: The number of credits the course is worth
            //-----------------------------------------------------------------
            public String name;
            public double grade;
            public String code;
            public double priority;
            public double credits;

            //-----------------------------------------------------------------
            // Default constructor for the CourseBuilder class
            // v1: Created the constructor - Nathan S, 3-6-22
            //-----------------------------------------------------------------
            public CourseBuilder()
            {

            }

            //-----------------------------------------------------------------
            // Wither method for the name attribute
            // name: The name being set in the builder
            // return: The builder for build chains
            // v1: Created the method - Nathan S, 3-6-22
            //-----------------------------------------------------------------
            public CourseBuilder WithName(String name)
            {
                this.name = name;
                return this;
            }

            //-----------------------------------------------------------------
            // Wither method for the grade attribute
            // grade: The grade being set in the builder
            // return: The builder for build chains
            // v1: Created the method - Nathan S, 3-6-22
            //-----------------------------------------------------------------
            public CourseBuilder WithGrade(double grade)
            {
                this.grade = grade;
                return this;
            }

            //-----------------------------------------------------------------
            // Wither method for the code attribute
            // code: The code being set in the builder
            // return: The builder for build chains
            // v1: Created the method - Nathan S, 3-6-22
            //-----------------------------------------------------------------
            public CourseBuilder WithCode(String code)
            {
                this.code = code;
                return this;
            }

            //-----------------------------------------------------------------
            // Wither method for the priority attribute
            // priority: The priority being set in the builder
            // return: The builder for build chains
            // v1: Created the method - Nathan S, 3-6-22
            //-----------------------------------------------------------------
            public CourseBuilder WithPriority(double priority)
            {
                this.priority = priority;
                return this;
            }

            //-----------------------------------------------------------------
            // Wither method for the credits attribute
            // credits: The credits being set in the builder
            // return: The builder for build chains
            // v1: Created the method - Nathan S, 3-6-22
            //-----------------------------------------------------------------
            public CourseBuilder WithCredits(double credits)
            {
                this.credits = credits;
                return this;
            }

            //-----------------------------------------------------------------
            // Build method for the builder
            // return: The course which was built
            // v1: Created the method - Nathan S, 3-6-22
            //-----------------------------------------------------------------
            public Course Build()
            {
                return new Course(this);
            }
        }

        //---------------------------------------------------------------------
        // Default constructor for the Course class
        // v1: Created the method - Nathan S, 3-6-22
        //---------------------------------------------------------------------
        private Course(CourseBuilder builder)
        {
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
