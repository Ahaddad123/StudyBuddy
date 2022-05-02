namespace Spike1_GraphUI
{
    partial class StudyHoursForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHoursStudied = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.graphDataBtn = new System.Windows.Forms.Button();
            this.studdyBuddyNav11 = new Spike1_GraphUI.StuddyBuddyNav1();
            this.WeekComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(347, 113);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Hours Studied";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(890, 325);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your hours studied. \r\nDoesn\'t do anything yet.";
            // 
            // labelHoursStudied
            // 
            this.labelHoursStudied.Location = new System.Drawing.Point(468, 578);
            this.labelHoursStudied.Name = "labelHoursStudied";
            this.labelHoursStudied.Size = new System.Drawing.Size(100, 22);
            this.labelHoursStudied.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(468, 533);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hours";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Location = new System.Drawing.Point(344, 675);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 16);
            this.msg.TabIndex = 8;
            // 
            // graphDataBtn
            // 
            this.graphDataBtn.Location = new System.Drawing.Point(959, 574);
            this.graphDataBtn.Name = "graphDataBtn";
            this.graphDataBtn.Size = new System.Drawing.Size(145, 23);
            this.graphDataBtn.TabIndex = 9;
            this.graphDataBtn.Text = "Graph Data";
            this.graphDataBtn.UseVisualStyleBackColor = true;
            this.graphDataBtn.Click += new System.EventHandler(this.graphDataBtn_Click);
            // 
            // studdyBuddyNav11
            // 
            this.studdyBuddyNav11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studdyBuddyNav11.Location = new System.Drawing.Point(0, 0);
            this.studdyBuddyNav11.Margin = new System.Windows.Forms.Padding(0);
            this.studdyBuddyNav11.MaximumSize = new System.Drawing.Size(315, 780);
            this.studdyBuddyNav11.Name = "studdyBuddyNav11";
            this.studdyBuddyNav11.Size = new System.Drawing.Size(315, 780);
            this.studdyBuddyNav11.TabIndex = 0;
            // 
            // WeekComboBox
            // 
            this.WeekComboBox.FormattingEnabled = true;
            this.WeekComboBox.Items.AddRange(new object[] {
            "0",
            "1"});
            this.WeekComboBox.Location = new System.Drawing.Point(959, 508);
            this.WeekComboBox.Name = "WeekComboBox";
            this.WeekComboBox.Size = new System.Drawing.Size(121, 24);
            this.WeekComboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(968, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select a week";
            // 
            // StudyHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 777);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WeekComboBox);
            this.Controls.Add(this.graphDataBtn);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelHoursStudied);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.studdyBuddyNav11);
            this.Name = "StudyHoursForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StuddyBuddyNav1 studdyBuddyNav11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelHoursStudied;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button graphDataBtn;
        private System.Windows.Forms.ComboBox WeekComboBox;
        private System.Windows.Forms.Label label4;
    }
}