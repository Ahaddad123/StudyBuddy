namespace Study_Buddy.Presentation.View
{
    partial class RemoveCourseBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseListBox = new System.Windows.Forms.ComboBox();
            this.removeCourseButton = new System.Windows.Forms.Button();
            this.successMessage = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.successMessage);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.courseListBox);
            this.groupBox2.Controls.Add(this.removeCourseButton);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1001, 545);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Course";
            // 
            // courseListBox
            // 
            this.courseListBox.DropDownWidth = 121;
            this.courseListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.IntegralHeight = false;
            this.courseListBox.Location = new System.Drawing.Point(120, 52);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(393, 31);
            this.courseListBox.TabIndex = 15;
            // 
            // removeCourseButton
            // 
            this.removeCourseButton.BackColor = System.Drawing.Color.White;
            this.removeCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCourseButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCourseButton.ForeColor = System.Drawing.Color.Navy;
            this.removeCourseButton.Location = new System.Drawing.Point(389, 112);
            this.removeCourseButton.Name = "removeCourseButton";
            this.removeCourseButton.Size = new System.Drawing.Size(124, 44);
            this.removeCourseButton.TabIndex = 16;
            this.removeCourseButton.Text = "Remove";
            this.removeCourseButton.UseVisualStyleBackColor = false;
            this.removeCourseButton.Click += new System.EventHandler(this.removeCourseButton_Click);
            // 
            // successMessage
            // 
            this.successMessage.AutoSize = true;
            this.successMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.successMessage.Location = new System.Drawing.Point(41, 178);
            this.successMessage.Name = "successMessage";
            this.successMessage.Size = new System.Drawing.Size(0, 29);
            this.successMessage.TabIndex = 18;
            // 
            // RemoveCourseBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "RemoveCourseBox";
            this.Size = new System.Drawing.Size(1001, 545);
            this.Load += new System.EventHandler(this.RemoveCourseBox_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseListBox;
        private System.Windows.Forms.Button removeCourseButton;
        private System.Windows.Forms.Label successMessage;
    }
}
