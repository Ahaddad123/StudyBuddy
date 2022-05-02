namespace Study_Buddy.Presentation
{
    partial class AddAssignmentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAssignmentForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.weightErrorMessageLabel = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            this.nameErrorMessageLabel = new System.Windows.Forms.Label();
            this.courseErrorMessageLabel = new System.Windows.Forms.Label();
            this.totalPointsErrorMessageLabel = new System.Windows.Forms.Label();
            this.dtpAssignDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.butAddAssig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtPointsAssign = new System.Windows.Forms.TextBox();
            this.txtNameAssign = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Location = new System.Drawing.Point(321, 112);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.MaximumSize = new System.Drawing.Size(1029, 585);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1029, 585);
            this.mainPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.weightErrorMessageLabel);
            this.groupBox1.Controls.Add(this.successLabel);
            this.groupBox1.Controls.Add(this.nameErrorMessageLabel);
            this.groupBox1.Controls.Add(this.courseErrorMessageLabel);
            this.groupBox1.Controls.Add(this.totalPointsErrorMessageLabel);
            this.groupBox1.Controls.Add(this.dtpAssignDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbCourses);
            this.groupBox1.Controls.Add(this.butAddAssig);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.txtPointsAssign);
            this.groupBox1.Controls.Add(this.txtNameAssign);
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 570);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "The day the assignment is due. \r\nNote that when a grade is later entered, this is" +
        " the day that \r\ngrade is logged as having been entered.\r\n");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(159, 93);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "The overall number of points an assignments ");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(159, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "The percentage of the overall grade\r\nin a course that this assignment counts towa" +
        "rds.");
            // 
            // weightErrorMessageLabel
            // 
            this.weightErrorMessageLabel.AutoSize = true;
            this.weightErrorMessageLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.weightErrorMessageLabel.Location = new System.Drawing.Point(154, 230);
            this.weightErrorMessageLabel.Name = "weightErrorMessageLabel";
            this.weightErrorMessageLabel.Size = new System.Drawing.Size(0, 19);
            this.weightErrorMessageLabel.TabIndex = 15;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.successLabel.Location = new System.Drawing.Point(38, 315);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(0, 23);
            this.successLabel.TabIndex = 14;
            // 
            // nameErrorMessageLabel
            // 
            this.nameErrorMessageLabel.AutoSize = true;
            this.nameErrorMessageLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorMessageLabel.Location = new System.Drawing.Point(154, 60);
            this.nameErrorMessageLabel.Name = "nameErrorMessageLabel";
            this.nameErrorMessageLabel.Size = new System.Drawing.Size(0, 19);
            this.nameErrorMessageLabel.TabIndex = 13;
            // 
            // courseErrorMessageLabel
            // 
            this.courseErrorMessageLabel.AutoSize = true;
            this.courseErrorMessageLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.courseErrorMessageLabel.Location = new System.Drawing.Point(154, 174);
            this.courseErrorMessageLabel.Name = "courseErrorMessageLabel";
            this.courseErrorMessageLabel.Size = new System.Drawing.Size(0, 19);
            this.courseErrorMessageLabel.TabIndex = 12;
            // 
            // totalPointsErrorMessageLabel
            // 
            this.totalPointsErrorMessageLabel.AutoSize = true;
            this.totalPointsErrorMessageLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPointsErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.totalPointsErrorMessageLabel.Location = new System.Drawing.Point(154, 119);
            this.totalPointsErrorMessageLabel.Name = "totalPointsErrorMessageLabel";
            this.totalPointsErrorMessageLabel.Size = new System.Drawing.Size(0, 19);
            this.totalPointsErrorMessageLabel.TabIndex = 11;
            // 
            // dtpAssignDate
            // 
            this.dtpAssignDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAssignDate.Location = new System.Drawing.Point(185, 258);
            this.dtpAssignDate.Name = "dtpAssignDate";
            this.dtpAssignDate.Size = new System.Drawing.Size(332, 30);
            this.dtpAssignDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Due date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(30, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Course";
            // 
            // cmbCourses
            // 
            this.cmbCourses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(185, 140);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(121, 31);
            this.cmbCourses.TabIndex = 7;
            // 
            // butAddAssig
            // 
            this.butAddAssig.BackColor = System.Drawing.Color.White;
            this.butAddAssig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddAssig.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddAssig.ForeColor = System.Drawing.Color.Navy;
            this.butAddAssig.Location = new System.Drawing.Point(361, 304);
            this.butAddAssig.Name = "butAddAssig";
            this.butAddAssig.Size = new System.Drawing.Size(105, 30);
            this.butAddAssig.TabIndex = 6;
            this.butAddAssig.Text = "Add Assignment";
            this.butAddAssig.UseVisualStyleBackColor = false;
            this.butAddAssig.Click += new System.EventHandler(this.butAddAssig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(29, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(28, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(185, 197);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(125, 30);
            this.txtWeight.TabIndex = 2;
            // 
            // txtPointsAssign
            // 
            this.txtPointsAssign.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPointsAssign.Location = new System.Drawing.Point(185, 86);
            this.txtPointsAssign.Name = "txtPointsAssign";
            this.txtPointsAssign.Size = new System.Drawing.Size(125, 30);
            this.txtPointsAssign.TabIndex = 1;
            // 
            // txtNameAssign
            // 
            this.txtNameAssign.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameAssign.Location = new System.Drawing.Point(185, 27);
            this.txtNameAssign.Name = "txtNameAssign";
            this.txtNameAssign.Size = new System.Drawing.Size(318, 30);
            this.txtNameAssign.TabIndex = 0;
            // 
            // AddAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(964, 592);
            this.Name = "AddAssignmentForm";
            this.Text = "Form Template";
            this.Load += new System.EventHandler(this.AddAssignmentForm_Load);
            this.Controls.SetChildIndex(this.nav1, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.mainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butAddAssig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtPointsAssign;
        private System.Windows.Forms.TextBox txtNameAssign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.DateTimePicker dtpAssignDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label weightErrorMessageLabel;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label nameErrorMessageLabel;
        private System.Windows.Forms.Label courseErrorMessageLabel;
        private System.Windows.Forms.Label totalPointsErrorMessageLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}