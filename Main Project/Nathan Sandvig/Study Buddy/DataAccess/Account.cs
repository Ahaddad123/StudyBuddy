using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.Database;

namespace Study_Buddy.DataAccess
{
    public class Account
    {
        internal String username; //Login username
        internal String password; //Login password
        internal int userID; //This is the ID for the database to track accounts
        SQLite database = new SQLite();

        public List<Course> courses { get; set; } = new List<Course>();

        //public Account(String newUsername, String newPassword, int newUserID){
            //username = newUsername;
            //password = newPassword;
            //userID = newUserID;
        //}

        public Boolean CheckCreateAccount(String username, String password) {

            Boolean AccountCreated = database.CheckAccountUsername(username);
            
            if (!AccountCreated) {
                database.InsertAccountData(username, password);
            }

            return AccountCreated;
        }

        public Boolean Login(String username, String password)
        {
            Boolean isCorrect = false;
            Boolean isUserCorrect = database.CheckAccountUsername(username);
            Boolean isPassCorrect = false;

            if (isUserCorrect) {
                isPassCorrect = database.CheckAccountPassword(password);
            }

            if (isPassCorrect) {
                isCorrect = true;
            }

            return isCorrect;
        }


        public Boolean addCourse() {
            Boolean courseAdded = false;
            courseAdded = database.InsertCourse();

            // Add conditionals for if the course was added to the database or not
            
            return courseAdded;

        }

        public Boolean removeCourse() {
            Boolean courseRemoved = false;

            courseRemoved = database.RemoveCourse();

            // Add conditionals for if the course was removed from the database or not

            return courseRemoved;
        }
    }
}
