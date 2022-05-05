using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.DataAccess;

namespace Study_Buddy.BusinessLogic
{
    //controller for account
    public class AccountController
    {

        SQLite database = new SQLite();
        public static Account account { get; set; }

        public int createTables()
        {
            int success = database.createTables();

            return success;
        }

        public Boolean createAccount(string username, string password, string email, string firstname, string lastname, string gpa, string schoolname)
        {
            account = new Account(username, password, firstname, lastname, gpa, schoolname);
            account.readCourses();
            int acc = database.InsertAccountData(username, password, email, firstname, lastname, gpa, schoolname);

            if (acc == -1)
            {
                return false;
            }
            else
                return true;
        }

        public Boolean accountCreated(string username, string password)
        {
            string acc = database.checkAccount(username, password);

            if (acc == null)
            {
                return false;
            }
            else
            {
                string accpass = database.checkPassword(password);
                if (accpass == null)
                {
                    return false;
                }
                else
                {
                    account = new Account(username, password);
                    account.readCourses();
                    return true;
                }
            }
        }

        public static bool scheduleCheck(CourseSchedule courseSchedule, String courseName) {
            foreach(DayOfWeek date in courseSchedule.times.Keys)
            {
                for(int i = courseSchedule.times[date].startTime.Hour; i < courseSchedule.times[date].endTime.Hour; i++)
                {
                    foreach(Course course in account.courses)
                    {
                        if(!course.name.Equals(courseName))
                        {
                            if (course.schedule.times.ContainsKey(date))
                            {
                                for (int j = course.schedule.times[date].startTime.Hour; j < course.schedule.times[date].endTime.Hour; j++)
                                {
                                    if (i == j)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
