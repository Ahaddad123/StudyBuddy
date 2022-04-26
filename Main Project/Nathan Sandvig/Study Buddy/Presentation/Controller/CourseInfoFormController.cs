using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;
using Study_Buddy.Presentation.View;
using Study_Buddy.Presentation.Model;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // This class controls a CourseInfoForm.  
    // v1: Created class - Peter H., 3-7-22
    //---------------------------------------------------------------------
    internal class CourseInfoFormController : GraphController
    {
        //---------------------------------------------------------------------
        // private data members:
        // course : The current course being displayed.
        // studyLog : the log of hours studied for the course.
        // gradeGraph : The graph of grades in the course.
        // weekID : the current week for which study data is being viewed.
        //---------------------------------------------------------------------
        //-------------------------------------------------------------------------
        public Course currentCourse { get; set; }
        public StudyLog studyLog { get; set; }
        private GradeGraph gradeGraph;
        private StudyLogGraph studyLogGraph;
        private int weekID;

        //---------------------------------------------------------------------
        // Parameterized Constructor.  Sets the form, course, studyLog and
        // creates graphs for the course.
        //---------------------------------------------------------------------
        public CourseInfoFormController(CourseInfoForm form, Course course, StudyLog studyLog)
        {
            this.currentCourse = course;
            this.studyLog = studyLog;
            this.view = form;
            this.gradeGraph = new GradeGraph(this.currentCourse);
            this.studyLogGraph = new StudyLogGraph(course.hourLog);
            view.SetController(this);
            weekID = 0;
        }

        public void SetCourseInfo()
        {
            ((CourseInfoForm)view).currentCourse = currentCourse;
            ((CourseInfoForm)view).SetInfo();
        }

        //---------------------------------------------------------------------
        // Draws a graph of grades in the course against time.
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public void DrawGradeGraph()
        {
            this.view.DrawGradeGraph(gradeGraph.GetXValues(), gradeGraph.GetYValues());
        }

        //---------------------------------------------------------------------
        // Draws a graph of hours studied in the course for a given week
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public void DrawStudyLogGraph()
        {
            this.view.DrawStudyLogGraph(weekID, studyLogGraph.GetXValues(), studyLogGraph.GetYValues());
        }

        //---------------------------------------------------------------------
        // Changes the current weekID for the study graph
        // change : The desired change in weekID
        // v1: Created the method - Peter H, 3-7-22
        //---------------------------------------------------------------------
        public void ChangeCurrentWeekID(int change)
        {
            //Decrement weekID
            if (change < 0)
            {
                //Make sure not going out of bounds
                if (weekID > 0)
                {
                    weekID += change;
                    studyLogGraph.SelectWeek(weekID);
                    DrawStudyLogGraph();
                }
            }
            //Increment weekID
            else
            {
                //Make sure not going out of bounds
                if (weekID < studyLogGraph.GetNumWeeks() - 1)
                {
                    weekID += change;
                    studyLogGraph.SelectWeek(weekID);
                    DrawStudyLogGraph();
                }

            }
        }
    }
}
