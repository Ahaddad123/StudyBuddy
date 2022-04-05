namespace Study_Buddy.Presentation.View
{
    partial class AddCoursePopupForm
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.butAddCourse);
            this.groupBox1.Controls.Add(this.txtCourseCredits);
            this.groupBox1.Controls.Add(this.txtCoursePriority);
            this.groupBox1.Controls.Add(this.txtCourseCode);
            this.groupBox1.Controls.Add(this.txtCourseTitle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(49, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(406, 227);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // butAddCourse
            // 
            this.butAddCourse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.butAddCourse.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.butAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddCourse.ForeColor = System.Drawing.Color.Navy;
            this.butAddCourse.Location = new System.Drawing.Point(194, 113);
            this.butAddCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAddCourse.Name = "butAddCourse";
            this.butAddCourse.Size = new System.Drawing.Size(65, 23);
            this.butAddCourse.TabIndex = 9;
            this.butAddCourse.Text = "Add Course";
            this.butAddCourse.UseVisualStyleBackColor = false;
            this.butAddCourse.Click += new System.EventHandler(this.butAddCourse_Click);
            // 
            // txtCourseCredits
            // 
            this.txtCourseCredits.Location = new System.Drawing.Point(79, 113);
            this.txtCourseCredits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseCredits.Name = "txtCourseCredits";
            this.txtCourseCredits.Size = new System.Drawing.Size(68, 22);
            this.txtCourseCredits.TabIndex = 8;
            // 
            // txtCoursePriority
            // 
            this.txtCoursePriority.Location = new System.Drawing.Point(79, 89);
            this.txtCoursePriority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCoursePriority.Name = "txtCoursePriority";
            this.txtCoursePriority.Size = new System.Drawing.Size(68, 22);
            this.txtCoursePriority.TabIndex = 7;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(79, 52);
            this.txtCourseCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(68, 22);
            this.txtCourseCode.TabIndex = 6;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(79, 30);
            this.txtCourseTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(180, 22);
            this.txtCourseTitle.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(13, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Credits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(13, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // AddCoursePopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 230);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCoursePopupForm";
            this.Text = "Add course";
            this.Load += new System.EventHandler(this.AddCoursePopupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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