using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    public class GradeGraph : Graph
    {
        //A list of dates (keys) and grade on that date (values)
        private Dictionary<DateTime, double> datesAndAverageGrades;
        private DataAccess.Course course;

        List<DateTime> datesX;
        List<double> averageGradesY;

        public GradeGraph(DataAccess.Course course)
        {
            this.course = course;
            datesX = new List<DateTime>();
            averageGradesY = new List<double>();
            GenerateTestData();
            GetCourseData();
        }

        private void GetCourseData()
        {
            //TODO, Course needs "private Dictionary<DateTime, double> datesAndAverageGrades" of dates and grades
            /*for (int i = 0; i < course.datesAndAverageGrades.Count ; i++)
            {
                datesX[i] = datesAndAverageGrades[i];
                //TODO doesn't work, figure out how to get key by value
                averageGradesY[i] = course.datesAndAverageGrades.KeyAtindex(); 
            }*/
        }

        public List<DateTime> GetXValues()
        {
            return datesX;
        }

        public List<double> GetYValues()
        {
            return averageGradesY;
        }

        /*
         * Since we are unable to get actual data at this time, this method fills the
         * lists with test values
         */
        private void GenerateTestData()
        {
            DateTime semesterStart = new DateTime(2022, 1, 24);
            DateTime today = DateTime.Now;
            int daysSinceStartOfSemester = ((int)(today - semesterStart).TotalDays);

            DateTime dateTime = semesterStart;
            Random random = new Random();

            for (int i = 0; i < daysSinceStartOfSemester; i++)
            {
                averageGradesY.Add(random.NextDouble() * 100);
                datesX.Add(dateTime);
                dateTime = dateTime.AddDays(1);
            }
        }
    }
}
