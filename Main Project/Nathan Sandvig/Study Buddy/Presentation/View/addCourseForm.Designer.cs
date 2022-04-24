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
            this.addCourseBox1 = new Study_Buddy.Presentation.View.AddCourseBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseListBox = new System.Windows.Forms.ComboBox();
            this.removeCourseButton = new System.Windows.Forms.Button();
            this.removeCourseLabel = new System.Windows.Forms.Label();
            this.addCourseLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.addCourseBox1);
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.removeCourseLabel);
            this.mainPanel.Controls.Add(this.addCourseLabel);
            this.mainPanel.Location = new System.Drawing.Point(317, 114);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.MaximumSize = new System.Drawing.Size(1030, 585);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1029, 585);
            this.mainPanel.TabIndex = 1;
            // 
            // addCourseBox1
            // 
            this.addCourseBox1.Location = new System.Drawing.Point(31, 40);
            this.addCourseBox1.Name = "addCourseBox1";
            this.addCourseBox1.Size = new System.Drawing.Size(558, 545);
            this.addCourseBox1.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.courseListBox);
            this.groupBox2.Controls.Add(this.removeCourseButton);
            this.groupBox2.Location = new System.Drawing.Point(621, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 259);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(71, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Course";
            // 
            // courseListBox
            // 
            this.courseListBox.DropDownWidth = 121;
            this.courseListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.IntegralHeight = false;
            this.courseListBox.Location = new System.Drawing.Point(150, 86);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(121, 31);
            this.courseListBox.TabIndex = 15;
            // 
            // removeCourseButton
            // 
            this.removeCourseButton.BackColor = System.Drawing.Color.White;
            this.removeCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCourseButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCourseButton.ForeColor = System.Drawing.Color.Navy;
            this.removeCourseButton.Location = new System.Drawing.Point(131, 147);
            this.removeCourseButton.Name = "removeCourseButton";
            this.removeCourseButton.Size = new System.Drawing.Size(124, 44);
            this.removeCourseButton.TabIndex = 16;
            this.removeCourseButton.Text = "Remove";
            this.removeCourseButton.UseVisualStyleBackColor = false;
            this.removeCourseButton.Click += new System.EventHandler(this.removeCourseButton_Click);
            // 
            // removeCourseLabel
            // 
            this.removeCourseLabel.AutoSize = true;
            this.removeCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCourseLabel.Location = new System.Drawing.Point(731, 34);
            this.removeCourseLabel.Name = "removeCourseLabel";
            this.removeCourseLabel.Size = new System.Drawing.Size(187, 29);
            this.removeCourseLabel.TabIndex = 14;
            this.removeCourseLabel.Text = "Remove Course";
            // 
            // addCourseLabel
            // 
            this.addCourseLabel.AutoSize = true;
            this.addCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseLabel.Location = new System.Drawing.Point(26, 8);
            this.addCourseLabel.Name = "addCourseLabel";
            this.addCourseLabel.Size = new System.Drawing.Size(140, 29);
            this.addCourseLabel.TabIndex = 13;
            this.addCourseLabel.Text = "Add Course";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.mainPanel);
            this.MaximumSize = new System.Drawing.Size(9640, 5920);
            this.MinimumSize = new System.Drawing.Size(964, 592);
            this.Name = "AddCourseForm";
            this.Text = "Form Template";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.nav1, 0);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label addCourseLabel;
        private System.Windows.Forms.ComboBox courseListBox;
        private System.Windows.Forms.Label removeCourseLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeCourseButton;
        private View.AddCourseBox addCourseBox1;
    }
}