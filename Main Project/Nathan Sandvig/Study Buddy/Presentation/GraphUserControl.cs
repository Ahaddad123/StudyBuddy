using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.Presentation.Model;

namespace Study_Buddy.Presentation
{
    public partial class GraphUserControl : UserControl//, IGraphView
    {
        private GraphController controller;
        public GraphUserControl()
        {
            InitializeComponent();
        }
        public void SetController(GraphController controller)
        {
            this.controller = controller;
        }

        public void DrawGPAGraph(List<DateTime> xValues, List<double> yValues)
        {
            throw new NotImplementedException();
        }

        public void DrawGradeGraph(List<DateTime> xValues, List<double> yValues)
        {
            throw new NotImplementedException();
        }

        public void DrawStudyLogGraph(int weekID, List<string> xValues, List<int> yValues)
        {
            throw new NotImplementedException();
        }

    }
}
