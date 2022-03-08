using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.Presentation
{
    public interface GraphView
    {
        void SetController(Controller controller);
        void DrawGradeGraph(List<DateTime> xValues, List<double> yValues);
        void DrawStudyLogGraph(int weekID, List<string> xValues, List<int> yValues);
    }
}
