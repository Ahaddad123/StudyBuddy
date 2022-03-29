using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //-------------------------------------------------------------------------
    // This class manages the first algorithm
    // v1: Created the class - Nathan S, 3-24-22
    //-------------------------------------------------------------------------
    internal class Algorithm1
    {
        //---------------------------------------------------------------------
        // Attributes:
        // assignmentLog: The list of assignment grades and hours studied
        //---------------------------------------------------------------------
        private LinkedList<Tuple<double, double>> assignmentLog;

        //---------------------------------------------------------------------
        // Default constructor for the algorithm1 class
        // v1: Created the constructor - Nathan S, 3-24-22
        //---------------------------------------------------------------------
        public Algorithm1()
        {
            assignmentLog = new LinkedList<Tuple<double, double>>();
        }

        //---------------------------------------------------------------------
        // Adds an assignment result to the list
        // grade: The grade achieved on the assignment (out of 100.0)
        // hours: The number of hours logged prior to completing the assignment
        //---------------------------------------------------------------------
        public void AddAssignment(double grade, double hours)
        {
            assignmentLog.AddLast(new Tuple<double, double>(grade, hours));
        }

        //---------------------------------------------------------------------
        // Calculates the number of hours per percentage point
        // return: The number of hours spent for each percentage point earned
        // v1: Created the method - Nathan S, 3-24-22
        //---------------------------------------------------------------------
        private double HoursPerPercent()
        {
            // Initialize variables
            int count = 0;
            double gradeSum = 0.0;
            double hourSum = 0.0;

            // Total up the grades, hours, and number of assignments
            foreach (Tuple<double, double> pair in assignmentLog)
            {
                count++;
                gradeSum += pair.Item1;
                hourSum += pair.Item2;
            }

            // Return the average number of hours per percentage point
            return hourSum / gradeSum;
        }

        //---------------------------------------------------------------------
        // Calculates the number of hours needed to get a target grade
        // targetGrade: The grade the user wishes to achieve
        // return: The number of hours needed for the grade
        // v1: Created the method - Nathan S, 3-24-22
        //---------------------------------------------------------------------
        public double HoursForGrade(double targetGrade)
        {
            return targetGrade * HoursPerPercent();
        }
    }
}
