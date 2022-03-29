using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{

    //---------------------------------------------------------------------
    // This class is the model for a graph of grades and time for a
    // given course.  Currently only graphs default values as the backend
    // is not yet implemented.
    // v1: Created the class - Peter H, 3-7-22
    //---------------------------------------------------------------------
    public class GradeGraph : Graph
    {
        //---------------------------------------------------------------------
        // Private data members:
        // datesAndAverageGrades : maps a DateTime to the course's average.
        // Will be obtained from the course, but not fully implemented yet.
        // grade on that date.
        // course : the course whose grades are being graphed
        // datesX : a list of dates to be graphed on the X axis
        // averageGradesY : a list of avg grades to be graphed on the Y axis
        //---------------------------------------------------------------------
        //private Dictionary<DateTime, double> datesAndAverageGrades;
        private DataAccess.Course course;
        private List<DateTime> datesX;
        private List<double> averageGradesY;

        //---------------------------------------------------------------------
        // Parameterized constructor.  Initializes the members and 
        // creates default data to graph.
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public GradeGraph(DataAccess.Course course)
        {
            this.course = course;
            datesX = new List<DateTime>();
            averageGradesY = new List<double>();
            //Fill with default data
            GenerateTestData();
            //GetCourseData();
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
                averageGradesY.Add(random.NextDouble() * 100);
                datesX.Add(dateTime);
                dateTime = dateTime.AddDays(1);
            }
        }
    }
}
