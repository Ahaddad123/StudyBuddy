using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    //---------------------------------------------------------------------
    // This interface defines behaviors that are implemented by forms 
    // containing a graph.
    // v1: Created class - Peter H., 3-7-22
    //---------------------------------------------------------------------
    public interface IGraphView : IView
    {
        //Draws a graph of grades vs time
        void DrawGradeGraph(List<DateTime> xValues, List<double> yValues);
        //Draws a graph of hours studied for a course in a given week
        void DrawStudyLogGraph(int weekID, List<string> xValues, List<int> yValues);
    }
}
