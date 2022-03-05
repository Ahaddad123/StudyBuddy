using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.DataAccess
{
    internal class Course
    {
        List<Assignment> assignments;
        String courseName;
        double courseGrade;
        String courseCode;
        int coursePriority;
        int courseCredits;
        int courseDifficulty;
        public Course(string newName, double newGrade, String newCode, int newPriority, int newCredit, int newDiff)
        {
            courseName = newName;
            courseGrade = newGrade;
            courseCode = newCode;
            coursePriority = newPriority;
            courseCredits = newCredit;
            courseDifficulty = newDiff;
            assignments = null;
        }

        public void AddAssigment(string assignName, int assignPoint, int assignPriority)
        {
            Assignment temp = new Assignment(assignPoint, assignName, assignPriority);

            assignments.Add(temp);
        }

        public void RemoveAssignment(string assignName, int assignPoint, int assignPriority)
        {
            Assignment temp = new Assignment(assignPoint, assignName, assignPriority);

            assignments.Remove(temp);
        }
    }
}
