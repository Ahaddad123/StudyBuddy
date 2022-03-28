namespace Study_Buddy.Presentation
{
    partial class StudyLogForm
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
            this.nav1 = new Study_Buddy.Presentation.Nav(this);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bubAddHours = new System.Windows.Forms.Button();
            this.txtDateDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.COMBOBOXStudyLog = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.COMBOBOXStudyLog);
            this.mainPanel.Controls.Add(this.txtMonth);
            this.mainPanel.Controls.Add(this.txtDateDay);
            this.mainPanel.Controls.Add(this.bubAddHours);
            this.mainPanel.Location = new System.Drawing.Point(287, 116);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.MaximumSize = new System.Drawing.Size(810, 585);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(611, 405);
            this.mainPanel.TabIndex = 1;
            // 
            // nav1
            // 
            this.nav1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nav1.Location = new System.Drawing.Point(0, -1);
            this.nav1.Margin = new System.Windows.Forms.Padding(2);
            this.nav1.MaximumSize = new System.Drawing.Size(236, 878);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(236, 878);
            this.nav1.TabIndex = 0;
            // 
            // bubAddHours
            // 
            this.bubAddHours.Location = new System.Drawing.Point(239, 264);
            this.bubAddHours.Name = "bubAddHours";
            this.bubAddHours.Size = new System.Drawing.Size(107, 46);
            this.bubAddHours.TabIndex = 3;
            this.bubAddHours.Text = "Add Hours";
            this.bubAddHours.UseVisualStyleBackColor = true;
            //this.bubAddHours.Click += new System.EventHandler(this.bubAddHours_Click);
            // 
            // txtDateDay
            // 
            this.txtDateDay.Location = new System.Drawing.Point(147, 111);
            this.txtDateDay.Name = "txtDateDay";
            this.txtDateDay.Size = new System.Drawing.Size(100, 20);
            this.txtDateDay.TabIndex = 4;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(41, 111);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 5;
            // 
            // COMBOBOXStudyLog
            // 
            this.COMBOBOXStudyLog.FormattingEnabled = true;
            this.COMBOBOXStudyLog.Location = new System.Drawing.Point(41, 46);
            this.COMBOBOXStudyLog.Name = "COMBOBOXStudyLog";
            this.COMBOBOXStudyLog.Size = new System.Drawing.Size(121, 21);
            this.COMBOBOXStudyLog.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // StudyLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.nav1);
            this.MaximumSize = new System.Drawing.Size(964, 592);
            this.Name = "StudyLogForm";
            this.Text = "Form Template";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private Nav nav1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ComboBox COMBOBOXStudyLog;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDateDay;
        private System.Windows.Forms.Button bubAddHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        #endregion
    }
}