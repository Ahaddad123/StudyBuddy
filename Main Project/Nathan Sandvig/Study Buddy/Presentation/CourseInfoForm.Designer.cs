namespace Study_Buddy.Presentation
{
    partial class CourseInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.courseName = new System.Windows.Forms.Label();
            this.hoursLoggedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gradesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nav1 = new Study_Buddy.Presentation.Nav(this);
            this.WeekMinus = new System.Windows.Forms.Button();
            this.WeekPlus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoursLoggedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.BackColor = System.Drawing.Color.Transparent;
            this.courseName.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.ForeColor = System.Drawing.SystemColors.Window;
            this.courseName.Location = new System.Drawing.Point(425, 20);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(402, 42);
            this.courseName.TabIndex = 1;
            this.courseName.Text = "CourseNameGoesHere";
            // 
            // hoursLoggedChart
            // 
            chartArea1.Name = "ChartArea1";
            this.hoursLoggedChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.hoursLoggedChart.Legends.Add(legend1);
            this.hoursLoggedChart.Location = new System.Drawing.Point(432, 103);
            this.hoursLoggedChart.Name = "hoursLoggedChart";
            this.hoursLoggedChart.Size = new System.Drawing.Size(629, 283);
            this.hoursLoggedChart.TabIndex = 2;
            this.hoursLoggedChart.Text = "chart1";
            // 
            // gradesChart
            // 
            chartArea2.Name = "ChartArea1";
            this.gradesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.gradesChart.Legends.Add(legend2);
            this.gradesChart.Location = new System.Drawing.Point(432, 426);
            this.gradesChart.Name = "gradesChart";
            this.gradesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.gradesChart.Size = new System.Drawing.Size(629, 283);
            this.gradesChart.TabIndex = 3;
            this.gradesChart.Text = "chart2";
            // 
            // nav1
            // 
            this.nav1.AutoSize = true;
            this.nav1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nav1.Location = new System.Drawing.Point(0, 0);
            this.nav1.Margin = new System.Windows.Forms.Padding(0);
            this.nav1.MaximumSize = new System.Drawing.Size(315, 780);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(315, 780);
            this.nav1.TabIndex = 0;
            // 
            // WeekMinus
            // 
            this.WeekMinus.Location = new System.Drawing.Point(971, 74);
            this.WeekMinus.Name = "WeekMinus";
            this.WeekMinus.Size = new System.Drawing.Size(42, 23);
            this.WeekMinus.TabIndex = 5;
            this.WeekMinus.Text = "<-";
            this.WeekMinus.UseVisualStyleBackColor = true;
            this.WeekMinus.Click += new System.EventHandler(this.WeekMinus_Click);
            // 
            // WeekPlus
            // 
            this.WeekPlus.Location = new System.Drawing.Point(1019, 74);
            this.WeekPlus.Name = "WeekPlus";
            this.WeekPlus.Size = new System.Drawing.Size(42, 23);
            this.WeekPlus.TabIndex = 4;
            this.WeekPlus.Text = "->";
            this.WeekPlus.UseVisualStyleBackColor = true;
            this.WeekPlus.Click += new System.EventHandler(this.WeekPlus_Click);
            // 
            // CourseInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.WeekMinus);
            this.Controls.Add(this.WeekPlus);
            this.Controls.Add(this.gradesChart);
            this.Controls.Add(this.hoursLoggedChart);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.nav1);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "CourseInfoForm";
            this.Text = "AddAssignmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.hoursLoggedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Nav nav1;
        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.DataVisualization.Charting.Chart hoursLoggedChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart gradesChart;
        private System.Windows.Forms.Button WeekMinus;
        private System.Windows.Forms.Button WeekPlus;
    }
}