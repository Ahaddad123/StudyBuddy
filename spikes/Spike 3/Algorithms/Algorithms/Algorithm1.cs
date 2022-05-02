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
    internal class Algorithm1 : Algorithm
    {
        //---------------------------------------------------------------------
        // Attributes:
        // assignmentLog: The list of assignment grades and hours studied
        // baseGrade: The grade the user would get with 0 hours of studying
        // hoursPerPercent: The number of hours per percentage increase in grade
        //---------------------------------------------------------------------
        private LinkedList<Tuple<double, double>> assignmentLog;
        private double baseGrade;
        private double hoursPerPercent;

        //---------------------------------------------------------------------
        // Default constructor for the algorithm1 class
        // v1: Created the constructor - Nathan S, 3-24-22
        //---------------------------------------------------------------------
        public Algorithm1(LinkedList<Tuple<double, double>> assignmentLog)
        {
            this.assignmentLog = assignmentLog;
        }

        //---------------------------------------------------------------------
        // Calculates the grade function
        // v1: Created the method - Nathan S, 3-24-22
        //---------------------------------------------------------------------
        private void CalculateFunction()
        {
            // Create and initialize the sums
            double hourSum = 0.0;
            double gradeSum = 0.0;

            // Add to each sum
            foreach(Tuple<double, double> pair in assignmentLog)
            {
                hourSum += pair.Item1;
                gradeSum += pair.Item2;
            }

            // Calculate the slope
            hoursPerPercent = hourSum / gradeSum;

            // Calculate the intercept
            baseGrade = 0.0;
        }

        //---------------------------------------------------------------------
        // Calculates the number of hours needed to get a target grade
        // targetGrade: The grade the user wishes to achieve
        // return: The number of hours needed for the grade
        // v1: Created the method - Nathan S, 3-24-22
        //---------------------------------------------------------------------
        override public double HoursForGrade(double targetGrade)
        {
            CalculateFunction();
            return (targetGrade - baseGrade) * hoursPerPercent;
        }
    }
}
