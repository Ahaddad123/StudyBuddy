using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    public class Assignment
    {
        public int totalPoints { get; set; }   //total point value of assignment
        public string name { get; set; }        //name of assignment
        public double weight { get; set; }       //weight of assignment
        public double grade { get; set; } //gade user got for assignment
        public DateTime dueDate { get; set; }    //due date of assignment

        //---------------------------------------------------------------------
        // Constructor the initializes the data in Assignment
        // newPoints: number of points the assignment is worth
        // newName: name of the assignment
        // newWeight: percentage weight that the assignment counts towards the course's total grade
        // date: due date of the assignment
        //---------------------------------------------------------------------
        public Assignment(int newPoints, string newName, int newWeight, DateTime date)
        {
            totalPoints = newPoints;
            name = newName;
            weight = newWeight;
            dueDate = date;
        }

        //---------------------------------------------------------------------
        // Grades the assignment.
        // points: number of points scored on the assignment
        //---------------------------------------------------------------------
        public void addGrade(double points)
        {
            grade = points / totalPoints * 100;
        }
        
    }
}

