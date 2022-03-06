using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.DataAccess
{
    internal class Assignment
    {
        internal int points;         //total point value of assignment
        internal string name;        //name of assignment
        internal int priority;       //priority points of assignments
        internal double gradePoints; //gade user got for assignment

        public Assignment(int newPoints, string newName, int newPriority)
        {
            points = newPoints;
            name = newName;
            priority = newPriority;
        }

        void gradeAssignment(double percentGrade)
        {
            gradePoints = points * (0.01 * percentGrade);
        }
        
    }
}

