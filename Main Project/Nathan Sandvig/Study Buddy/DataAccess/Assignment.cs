using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.DataAccess
{
    public class Assignment
    {
        public int totalPoints { get; set; }   //total point value of assignment
        public string name { get; set; }        //name of assignment
        public double weight { get; set; }       //weight of assignment
        public double grade { get; set; } //gade user got for assignment

        public Assignment(int newPoints, string newName, int newWeight)
        {
            totalPoints = newPoints;
            name = newName;
            weight = newWeight;
        }

        public void addGrade(double points)
        {
            grade = points / totalPoints;
        }
        
    }
}

