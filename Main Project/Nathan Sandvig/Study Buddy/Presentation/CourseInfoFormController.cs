using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    internal class CourseInfoFormController : Controller
    {
        private DataAccess.Course course;
        private DataAccess.StudyLog studyLog;
        private GradeGraph gradeGraph;
        private StudyLogGraph studyLogGraph;
        private int weekID;

        public CourseInfoFormController(CourseInfoForm form, DataAccess.Course course, DataAccess.StudyLog studyLog)
        {
            this.course = course;
            this.studyLog = studyLog;
            this.view = form;
            this.gradeGraph = new GradeGraph(this.course);
            this.studyLogGraph = new StudyLogGraph(this.studyLog); 
            form.SetController(this);
            weekID = 0;
        }


        /*
         * Draws grade graph
         */
        public void DrawGradeGraph()
        {
            this.view.DrawGradeGraph(gradeGraph.GetXValues(), gradeGraph.GetYValues());
        }

        /*
         * Draws studyLog graph
         */
        public void DrawStudyLogGraph()
        {
            this.view.DrawStudyLogGraph(weekID, studyLogGraph.GetXValues(), studyLogGraph.GetYValues());
        }

        public void ChangeCurrentWeekID(int change)
        {
            //Decrement weekID
            if (change < 0)
            {
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
