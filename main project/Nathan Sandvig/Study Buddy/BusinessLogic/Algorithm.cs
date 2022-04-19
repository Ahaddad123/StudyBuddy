using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //-------------------------------------------------------------------------
    // This class manages the study hours algorithm
    // v1: Created the class - Nathan S, 4-19-22
    //-------------------------------------------------------------------------
    internal class Algorithm
    {
        //---------------------------------------------------------------------
        // Constants:
        // DEFAULT_BASE: The default base grade of the user
        // DEFAULT_HOURS: The default hours per percentage of the user
        //---------------------------------------------------------------------
        private const double DEFAULT_BASE = 60;
        private const double DEFAULT_HOURS = 0.1;

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
        // v1: Created the constructor - Nathan S, 4-19-22
        //---------------------------------------------------------------------
        public Algorithm()
        {
            assignmentLog = new LinkedList<Tuple<double, double>>();
            baseGrade = DEFAULT_BASE;
            hoursPerPercent = DEFAULT_HOURS;
        }

        //---------------------------------------------------------------------
        // Calculates the grade function
        // v1: Created the method - Nathan S, 4-19-22
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

            // Create and calculate the averages
            double averageHours = hourSum / assignmentLog.Count;
            double averageGrade = gradeSum / assignmentLog.Count;

            // Create the numerator and denominator for the slope
            double numerator = 0.0;
            double denominator = 0.0;
            foreach (Tuple<double, double> pair in assignmentLog)
            {
                numerator += ((pair.Item1 - averageHours) * (pair.Item2 - averageGrade));
                denominator += ((pair.Item1 - averageHours) * (pair.Item1 - averageHours));
            }

            // Calculate the slope
            hoursPerPercent = numerator / denominator;

            // Calculate the intercept
            baseGrade = averageGrade - (hoursPerPercent * averageHours);
        }

        //---------------------------------------------------------------------
        // Calculates the number of hours needed to get a target grade
        // targetGrade: The grade the user wishes to achieve
        // return: The number of hours needed for the grade
        // v1: Created the method - Nathan S, 4-19-22
        //---------------------------------------------------------------------
        public double HoursForGrade(double targetGrade)
        {
            if (assignmentLog.Count > 0)
                CalculateFunction();
            return (targetGrade - baseGrade) / hoursPerPercent;
        }
    }
}
