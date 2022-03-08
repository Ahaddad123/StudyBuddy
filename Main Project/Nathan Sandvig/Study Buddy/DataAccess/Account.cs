using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.DataAccess
{
    internal class Account
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


        public void addCourse() { }

        public void removeCourse() { }
    }
}
