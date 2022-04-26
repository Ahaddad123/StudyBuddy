namespace Study_Buddy.Presentation.View
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.hoursLoggedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gradesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WeekMinus = new System.Windows.Forms.Button();
            this.WeekPlus = new System.Windows.Forms.Button();
            this.courseListPanel = new System.Windows.Forms.TableLayoutPanel();
            this.yourCoursesLabel = new System.Windows.Forms.Label();
            this.userCourseList1 = new Study_Buddy.Presentation.View.UserCourseList();
            ((System.ComponentModel.ISupportInitialize)(this.hoursLoggedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesChart)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.courseListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nav1
            // 
            this.nav1.Load += new System.EventHandler(this.nav1_Load);
            // 
            // hoursLoggedChart
            // 
            this.hoursLoggedChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.hoursLoggedChart.ChartAreas.Add(chartArea3);
            this.mainTableLayoutPanel.SetColumnSpan(this.hoursLoggedChart, 2);
            legend3.Name = "Legend1";
            this.hoursLoggedChart.Legends.Add(legend3);
            this.hoursLoggedChart.Location = new System.Drawing.Point(3, 34);
            this.hoursLoggedChart.Name = "hoursLoggedChart";
            this.hoursLoggedChart.Size = new System.Drawing.Size(678, 258);
            this.hoursLoggedChart.TabIndex = 2;
            this.hoursLoggedChart.Text = "chart1";
            // 
            // gradesChart
            // 
            this.gradesChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.gradesChart.ChartAreas.Add(chartArea4);
            this.mainTableLayoutPanel.SetColumnSpan(this.gradesChart, 2);
            legend4.Name = "Legend1";
            this.gradesChart.Legends.Add(legend4);
            this.gradesChart.Location = new System.Drawing.Point(3, 346);
            this.gradesChart.Name = "gradesChart";
            this.gradesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.gradesChart.Size = new System.Drawing.Size(678, 263);
            this.gradesChart.TabIndex = 3;
            this.gradesChart.Text = "chart2";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.hoursLoggedChart, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.gradesChart, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.label2, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 1, 0);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(318, 95);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1028, 625);
            this.mainTableLayoutPanel.TabIndex = 6;
            this.mainTableLayoutPanel.Click += new System.EventHandler(this.mainTableLayoutPanel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Grades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(3, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Study Hours";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.WeekMinus);
            this.panel1.Controls.Add(this.WeekPlus);
            this.panel1.Location = new System.Drawing.Point(345, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 25);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // WeekMinus
            // 
            this.WeekMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekMinus.AutoEllipsis = true;
            this.WeekMinus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.WeekMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WeekMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeekMinus.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekMinus.ForeColor = System.Drawing.Color.White;
            this.WeekMinus.Location = new System.Drawing.Point(257, 0);
            this.WeekMinus.Name = "WeekMinus";
            this.WeekMinus.Size = new System.Drawing.Size(36, 22);
            this.WeekMinus.TabIndex = 7;
            this.WeekMinus.Text = "<";
            this.WeekMinus.UseVisualStyleBackColor = false;
            this.WeekMinus.Click += new System.EventHandler(this.WeekMinus_Click);
            // 
            // WeekPlus
            // 
            this.WeekPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekPlus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.WeekPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WeekPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeekPlus.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekPlus.ForeColor = System.Drawing.Color.White;
            this.WeekPlus.Location = new System.Drawing.Point(299, 0);
            this.WeekPlus.Name = "WeekPlus";
            this.WeekPlus.Size = new System.Drawing.Size(34, 22);
            this.WeekPlus.TabIndex = 6;
            this.WeekPlus.Text = ">";
            this.WeekPlus.UseVisualStyleBackColor = false;
            this.WeekPlus.Click += new System.EventHandler(this.WeekPlus_Click);
            // 
            // courseListPanel
            // 
            this.courseListPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.courseListPanel.ColumnCount = 1;
            this.courseListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.courseListPanel.Controls.Add(this.yourCoursesLabel, 0, 0);
            this.courseListPanel.Controls.Add(this.userCourseList1, 0, 1);
            this.courseListPanel.Location = new System.Drawing.Point(1002, 95);
            this.courseListPanel.Name = "courseListPanel";
            this.courseListPanel.RowCount = 2;
            this.courseListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.courseListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.courseListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.courseListPanel.Size = new System.Drawing.Size(338, 625);
            this.courseListPanel.TabIndex = 8;
            // 
            // yourCoursesLabel
            // 
            this.yourCoursesLabel.AutoSize = true;
            this.yourCoursesLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourCoursesLabel.ForeColor = System.Drawing.Color.Navy;
            this.yourCoursesLabel.Location = new System.Drawing.Point(3, 0);
            this.yourCoursesLabel.Name = "yourCoursesLabel";
            this.yourCoursesLabel.Size = new System.Drawing.Size(193, 35);
            this.yourCoursesLabel.TabIndex = 0;
            this.yourCoursesLabel.Text = "Your Courses";
            // 
            // userCourseList1
            // 
            this.userCourseList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userCourseList1.Location = new System.Drawing.Point(3, 53);
            this.userCourseList1.Name = "userCourseList1";
            this.userCourseList1.Size = new System.Drawing.Size(332, 569);
            this.userCourseList1.Width = this.courseListPanel.Width;
            this.userCourseList1.TabIndex = 1;
            // 
            // CourseInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.courseListPanel);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "CourseInfoForm";
            this.Text = "AddAssignmentForm";
            this.Controls.SetChildIndex(this.mainTableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.nav1, 0);
            this.Controls.SetChildIndex(this.courseListPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.hoursLoggedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesChart)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.courseListPanel.ResumeLayout(false);
            this.courseListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart hoursLoggedChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart gradesChart;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button WeekMinus;
        private System.Windows.Forms.Button WeekPlus;
        private System.Windows.Forms.TableLayoutPanel courseListPanel;
        private System.Windows.Forms.Label yourCoursesLabel;
        private UserCourseList userCourseList1;
    }
}