﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.DataAccess
{
    public class Account
    {
        internal String username; //Login username
        internal String password; //Login password
        internal int userID; //This is the ID for the database to track accounts
        public List<Course> courses { get; set; } = new List<Course>();

        public Account(String newUsername, String newPassword, int newUserID){
            username = newUsername;
            password = newPassword;
            userID = newUserID;
        }

        public Boolean CreateAccount(String username, String password) {
            Boolean AccountCreated = false;

            return AccountCreated;
        }

        public Boolean Login(String username, String password)
        {
            Boolean isCorrect = false;

            return isCorrect;
        }

        //---------------------------------------------------------------------
        // Adds a course to the account
        // course: The course data being passed from the controller
        // v1: Created the method - Nathan S, 3-7-22
        //---------------------------------------------------------------------
        public void addCourse(Course course) 
        {
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
    }
}
