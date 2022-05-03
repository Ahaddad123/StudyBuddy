using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation.Model
{
    //---------------------------------------------------------------------
    // This class is the model for a graph of grades and time for a
    // given course.  Currently only graphs default values as the backend
    // is not yet implemented.
    // v1: Created the class - Peter H, 3-7-22
    //---------------------------------------------------------------------
    public class GPAGraph : Graph
    {
        //---------------------------------------------------------------------
        // Private data members:
        // datesAndAverageGrades : maps a DateTime to the course's average.
        // Will be obtained from the course, but not fully implemented yet.
        // grade on that date.
        // datesX : a list of dates to be graphed on the X axis
        // averageGradesY : a list of avg grades to be graphed on the Y axis
        //---------------------------------------------------------------------
        //private Dictionary<DateTime, double> datesAndAverageGrades;
        private List<DateTime> datesX;
        private List<double> averageGradesY;

        //---------------------------------------------------------------------
        // Parameterized constructor.  Initializes the members and 
        // creates default data to graph.
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public GPAGraph(List<DateTime> datesX, List<double> averageGradesY)
        {
            //this.datesX = datesX;
            //this.averageGradesY = averageGradesY;
            this.datesX = new List<DateTime>();
            this.averageGradesY = new List<double>();
            //Fill with default data
            //GenerateTestData();
            //GetCourseData();
            GetData();
        }

        //---------------------------------------------------------------------
        // Gets the grade data from the course.  Currently empty until backend
        // is implemented
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        private void GetCourseData()
        {
            //TODO, Course needs "private Dictionary<DateTime, double>
            //datesAndAverageGrades" of dates and grades
            /*for (int i = 0; i < course.datesAndAverageGrades.Count ; i++)
            {
                datesX[i] = datesAndAverageGrades[i];
                //TODO doesn't work, figure out how to get key by value
                averageGradesY[i] = course.datesAndAverageGrades.KeyAtindex(); 
            }*/
        }

        //---------------------------------------------------------------------
        // Returns the dates to be displayed as X values on a chart
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public List<DateTime> GetXValues()
        {
            return datesX;
        }

        //---------------------------------------------------------------------
        // Returns the average grads to be displayed as Y values on a chart
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public List<double> GetYValues()
        {
            return averageGradesY;
        }


        //---------------------------------------------------------------------
        // Generates default grade data to fill in for the current length of the
        // semester.
        // This method exists primarily for demonstration purposes and will be 
        // eliminated once the backend is fully implemented, so that we may 
        // graph actual data.
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        private void GenerateTestData()
        {
            //Calculate days since semester began (arbitrarily 1/24/2022
            DateTime semesterStart = new DateTime(2022, 1, 24);
            DateTime today = DateTime.Now;
            int daysSinceStartOfSemester = ((int)(today - semesterStart).TotalDays);

            DateTime dateTime = semesterStart;
            Random random = new Random();

            //Populate lists with test data
            for (int i = 0; i < daysSinceStartOfSemester; i++)
            {
                double num = 5;
                while (num > 4)
                {
                    num = (random.NextDouble() * 10);
                }
                averageGradesY.Add(num);
                datesX.Add(dateTime);
                dateTime = dateTime.AddDays(1);
            }
        }

        //---------------------------------------------------------------------
        // Gathers data to present on gpa graph
        // v1: Created the method - Andrew V, 4-26-22
        //---------------------------------------------------------------------
        private void GetData()
        {
            DateTime currDate = new DateTime(2022, 1, 1);
            DateTime today = DateTime.Now;

            double averageGrade = 100;
            int numAssignments = 0;
            double total = 0;
            double sumOfCredits = 0;
            double gradeCredit = 0;

            foreach(Course c in AccountController.account.courses)
            {
                sumOfCredits += c.credits;
            }

            while(currDate < today)
            {
                datesX.Add(currDate);
                currDate = currDate.AddDays(1);
            }

            currDate = new DateTime(2022, 1, 1);

            while (currDate < today)
            {
                gradeCredit = 0;
                foreach (Course c in AccountController.account.courses)
                {
                    total = 0;
                    numAssignments = 0;
                    DateTime newTime = new DateTime(2022, 1, 1);
                    averageGrade = 100;
                    while (newTime < currDate)
                    {
                        numAssignments += GetNumAssignments(currDate, c);
                        total += GetAssignGrade(currDate, c);

                        if (numAssignments > 0)
                        {
                            averageGrade = total / numAssignments;
                        }

                        newTime = newTime.AddDays(1);
                    }

                    if (numAssignments > 0)
                    {
                        if (averageGrade >= 93)
                        {
                            gradeCredit += c.credits * 4;
                        }
                        else if (averageGrade >= 90 && averageGrade < 93)
                        {
                            gradeCredit += c.credits * 3.7;
                        }
                        else if (averageGrade >= 87 && averageGrade < 90)
                        {
                            gradeCredit += c.credits * 3.3;
                        }
                        else if (averageGrade >= 83 && averageGrade < 87)
                        {
                            gradeCredit += c.credits * 3;
                        }
                        else if (averageGrade >= 80 && averageGrade < 83)
                        {
                            gradeCredit += c.credits * 2.7;
                        }
                        else if (averageGrade >= 77 && averageGrade < 80)
                        {
                            gradeCredit += c.credits * 2.3;
                        }
                        else if (averageGrade >= 73 && averageGrade < 77)
                        {
                            gradeCredit += c.credits * 2;
                        }
                        else if (averageGrade >= 70 && averageGrade < 73)
                        {
                            gradeCredit += c.credits * 1.7;
                        }
                        else if (averageGrade >= 67 && averageGrade < 70)
                        {
                            gradeCredit += c.credits * 1.3;
                        }
                        else if (averageGrade >= 65 && averageGrade < 67)
                        {
                            gradeCredit += c.credits * 1;
                        }
                        else if (averageGrade < 65)
                        {
                            gradeCredit += c.credits * 0;
                        }
                    }
                }
                averageGradesY.Add(gradeCredit / sumOfCredits);
                currDate = currDate.AddDays(1);
            }
        }

        //---------------------------------------------------------------------
        // gets the number of assignments from courses
        // v1: Created the method - Andrew V, 4-26-22
        //---------------------------------------------------------------------
        private int GetNumAssignments(DateTime currDate, Course c)
        {
            int numNewAssignment = 0;
            Course newCourse = c;
            foreach(Assignment currAssign in c.assignments)
            {
                if(currAssign.dueDate.DayOfYear == currDate.DayOfYear)
                {
                    numNewAssignment++;
                }
            }
            
            return numNewAssignment;
        }

        //---------------------------------------------------------------------
        // gets the total grade from courses
        // v1: Created the method - Andrew V, 4-26-22
        //---------------------------------------------------------------------
        private double GetAssignGrade(DateTime currDate, Course c)
        {
            double sumOfGrade = 0.0;
            
            foreach (Assignment currAssign in c.assignments)
            {
                if (currAssign.dueDate.DayOfYear == currDate.DayOfYear)
                {
                     sumOfGrade += currAssign.grade;
                }
            }
            
            return sumOfGrade;
        }
    }
}
