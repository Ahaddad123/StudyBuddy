namespace Study_Buddy.Presentation
{
    partial class AddCourseForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butAddCourse = new System.Windows.Forms.Button();
            this.txtCourseCredits = new System.Windows.Forms.TextBox();
            this.txtCoursePriority = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Location = new System.Drawing.Point(317, 114);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.MaximumSize = new System.Drawing.Size(810, 585);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(611, 405);
            this.mainPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.butAddCourse);
            this.groupBox1.Controls.Add(this.txtCourseCredits);
            this.groupBox1.Controls.Add(this.txtCoursePriority);
            this.groupBox1.Controls.Add(this.txtCourseCode);
            this.groupBox1.Controls.Add(this.txtCourseTitle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(119, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 223);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // butAddCourse
            // 
            this.butAddCourse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.butAddCourse.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.butAddCourse.Location = new System.Drawing.Point(225, 157);
            this.butAddCourse.Name = "butAddCourse";
            this.butAddCourse.Size = new System.Drawing.Size(98, 36);
            this.butAddCourse.TabIndex = 9;
            this.butAddCourse.Text = "Add Course";
            this.butAddCourse.UseVisualStyleBackColor = false;
            this.butAddCourse.Click += new System.EventHandler(this.butAddCourse_Click);
            // 
            // txtCourseCredits
            // 
            this.txtCourseCredits.Location = new System.Drawing.Point(66, 166);
            this.txtCourseCredits.Name = "txtCourseCredits";
            this.txtCourseCredits.Size = new System.Drawing.Size(100, 20);
            this.txtCourseCredits.TabIndex = 8;
            // 
            // txtCoursePriority
            // 
            this.txtCoursePriority.Location = new System.Drawing.Point(66, 136);
            this.txtCoursePriority.Name = "txtCoursePriority";
            this.txtCoursePriority.Size = new System.Drawing.Size(100, 20);
            this.txtCoursePriority.TabIndex = 7;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(66, 74);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(100, 20);
            this.txtCourseCode.TabIndex = 6;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(66, 47);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(268, 20);
            this.txtCourseTitle.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Credits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(946, 545);
            this.Controls.Add(this.mainPanel);
            this.MaximumSize = new System.Drawing.Size(964, 592);
            this.MinimumSize = new System.Drawing.Size(964, 592);
            this.Name = "AddCourseForm";
            this.Text = "Form Template";
            this.Controls.SetChildIndex(this.nav1, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.mainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butAddCourse;
        private System.Windows.Forms.TextBox txtCourseCredits;
        private System.Windows.Forms.TextBox txtCoursePriority;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}