using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
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
        private static LinkedList<(double, double)> assignmentLog = new LinkedList<(double, double)>();
        private static double baseGrade = DEFAULT_BASE;
        private static double hoursPerPercent = DEFAULT_HOURS;

        //---------------------------------------------------------------------
        // Imports course data for the specified course
        // course: The course being imported
        // v1: Created the method - Nathan S, 4-21-22
        //---------------------------------------------------------------------
        private static void ImportCourseData(Course course)
        {
            assignmentLog.Clear();
            List<Assignment> assignmentList = new List<Assignment>();
            foreach (Assignment assignment in course.assignments)
                if (assignment.grade != 0)
                    assignmentList.Add(assignment);
            assignmentList.Sort(delegate (Assignment a1, Assignment a2) { return a1.dueDate.CompareTo(a2.dueDate); });
            
            if (assignmentList.Count > 0)
            {
                DateTime previousDate = assignmentList.First().dueDate.Subtract(new TimeSpan(120, 0, 0, 0));
                double hours = 0.0;
                while (hours == 0.0 && previousDate <= assignmentList.First().dueDate)
                {
                    previousDate = previousDate.AddDays(1);
                    hours = course.hourLog.GetHours(previousDate);
                }

                foreach (Assignment assignment in assignmentList)
                {
                    double hoursStudied = 0.0;
                    DateTime currentDate = assignment.dueDate;
                    for (DateTime date = previousDate; date <= currentDate; date = date.AddDays(1))
                        hoursStudied += course.hourLog.GetHours(date);
                    double weeks = (currentDate - previousDate).Days / 7.0;
                    double hoursPerWeek = hoursStudied / weeks;
                    assignmentLog.AddLast((hoursPerWeek, assignment.grade));
                    previousDate = currentDate;
                }
            }
        }

        //---------------------------------------------------------------------
        // Calculates the grade function
        // v1: Created the method - Nathan S, 4-19-22
        //---------------------------------------------------------------------
        private static void CalculateFunction()
        {
            // Create and initialize the sums
            double hourSum = 0.0;
            double gradeSum = 0.0;

            // Add to each sum
            foreach((double hours, double grade) assignment in assignmentLog)
            {
                hourSum += assignment.hours;
                gradeSum += assignment.grade;
            }

            // Create and calculate the averages
            double averageHours = hourSum / assignmentLog.Count;
            double averageGrade = gradeSum / assignmentLog.Count;

            // Create the numerator and denominator for the slope
            double numerator = 0.0;
            double denominator = 0.0;
            foreach ((double hours, double grade) assignment in assignmentLog)
            {
                numerator += ((assignment.hours - averageHours) * (assignment.grade - averageGrade));
                denominator += ((assignment.hours - averageHours) * (assignment.hours - averageHours));
            }

            // Calculate the slope
            if (denominator != 0.0)
                hoursPerPercent = numerator / denominator;
            if (hoursPerPercent <= 0)
                hoursPerPercent = DEFAULT_HOURS;

            // Calculate the intercept
            baseGrade = averageGrade - (hoursPerPercent * averageHours);
            if (baseGrade < 0 || baseGrade > 100)
                baseGrade = DEFAULT_BASE;
        }

        //---------------------------------------------------------------------
        // Calculates the number of hours needed per week to get a target grade
        // targetGrade: The grade the user wishes to achieve
        // return: The number of hours needed for the grade
        // v1: Created the method - Nathan S, 4-19-22
        //---------------------------------------------------------------------
        public static double HoursForGrade(Course course, double targetGrade)
        {
            ImportCourseData(course);
            if (assignmentLog.Count > 0)
                CalculateFunction();
            double hours = (targetGrade - baseGrade) / hoursPerPercent;
            if (hours < 0)
                hours = 0;
            return hours;
        }
    }
}
