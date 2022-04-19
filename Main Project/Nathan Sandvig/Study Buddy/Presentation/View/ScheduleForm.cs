using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.DataAccess;
using Study_Buddy.BusinessLogic;
using Study_Buddy.Presentation.View;
using Study_Buddy.Presentation.Controller;

namespace Study_Buddy.Presentation
{
    public partial class ScheduleForm : BaseForm, IView
    {
        private ScheduleFormController controller;
        public ScheduleForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.title = "Schedule";
            this.Text = title;
            this.mainHeader.Text = title;
            this.nav1.SetCurrentForm(this);
        }

        //---------------------------------------------------------------------
        // Sets the form's controller
        // v1: Created the method - Peter H, 3-19-22
        //---------------------------------------------------------------------
        public void SetController(FormController controller)
        {
            this.controller = (ScheduleFormController)controller;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < this.tableLayoutPanel2.RowCount; i++)
            {
                Label label = new Label();
                int time = i + 6;
                if(time < 12)
                {
                    label.Text = time + "am";
                }
                else if (time == 12)
                {
                    label.Text = time + "pm";
                }
                else
                {
                    label.Text = time % 12 + "pm";
                }
                this.tableLayoutPanel2.Controls.Add(label, 0, i);
            }

            //for(int i = 0; i < tableLayoutPanel2.RowCount; i++)
            //{
                Label label2 = new Label();
                label2.Text = "courseName";
                label2.BackColor = Color.CornflowerBlue;
                label2.AutoSize = true;
                label2.Dock = DockStyle.Fill;
                this.tableLayoutPanel2.Controls.Add(label2, 3, 3);
                this.tableLayoutPanel2.SetRowSpan(label2, 2);
            //}
        }
    }
}
