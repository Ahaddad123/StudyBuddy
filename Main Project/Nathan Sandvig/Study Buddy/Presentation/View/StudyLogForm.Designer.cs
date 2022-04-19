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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.successMessageLabel = new System.Windows.Forms.Label();
            this.hoursErrorMessageLabel = new System.Windows.Forms.Label();
            this.dateErrorMessageLabel = new System.Windows.Forms.Label();
            this.courseErrorMessageLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPhourDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.butAddHours = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Location = new System.Drawing.Point(333, 127);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.MaximumSize = new System.Drawing.Size(810, 585);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(611, 405);
            this.mainPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.btnRedo);
            this.groupBox1.Controls.Add(this.btnUndo);
            this.groupBox1.Controls.Add(this.successMessageLabel);
            this.groupBox1.Controls.Add(this.hoursErrorMessageLabel);
            this.groupBox1.Controls.Add(this.dateErrorMessageLabel);
            this.groupBox1.Controls.Add(this.courseErrorMessageLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DTPhourDate);
            this.groupBox1.Controls.Add(this.cmbCourses);
            this.groupBox1.Controls.Add(this.butAddHours);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(52, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 310);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // successMessageLabel
            // 
            this.successMessageLabel.AutoSize = true;
            this.successMessageLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successMessageLabel.ForeColor = System.Drawing.Color.White;
            this.successMessageLabel.Location = new System.Drawing.Point(90, 258);
            this.successMessageLabel.Name = "successMessageLabel";
            this.successMessageLabel.Size = new System.Drawing.Size(0, 23);
            this.successMessageLabel.TabIndex = 18;
            // 
            // hoursErrorMessageLabel
            // 
            this.hoursErrorMessageLabel.AutoSize = true;
            this.hoursErrorMessageLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.hoursErrorMessageLabel.Location = new System.Drawing.Point(90, 219);
            this.hoursErrorMessageLabel.Name = "hoursErrorMessageLabel";
            this.hoursErrorMessageLabel.Size = new System.Drawing.Size(0, 23);
            this.hoursErrorMessageLabel.TabIndex = 17;
            // 
            // dateErrorMessageLabel
            // 
            this.dateErrorMessageLabel.AutoSize = true;
            this.dateErrorMessageLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.dateErrorMessageLabel.Location = new System.Drawing.Point(90, 147);
            this.dateErrorMessageLabel.Name = "dateErrorMessageLabel";
            this.dateErrorMessageLabel.Size = new System.Drawing.Size(0, 23);
            this.dateErrorMessageLabel.TabIndex = 16;
            // 
            // courseErrorMessageLabel
            // 
            this.courseErrorMessageLabel.AutoSize = true;
            this.courseErrorMessageLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.courseErrorMessageLabel.Location = new System.Drawing.Point(90, 74);
            this.courseErrorMessageLabel.Name = "courseErrorMessageLabel";
            this.courseErrorMessageLabel.Size = new System.Drawing.Size(0, 23);
            this.courseErrorMessageLabel.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date";
            // 
            // DTPhourDate
            // 
            this.DTPhourDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPhourDate.CalendarForeColor = System.Drawing.Color.White;
            this.DTPhourDate.CalendarTitleBackColor = System.Drawing.Color.White;
            this.DTPhourDate.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.DTPhourDate.CalendarTrailingForeColor = System.Drawing.Color.CornflowerBlue;
            this.DTPhourDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPhourDate.Location = new System.Drawing.Point(89, 114);
            this.DTPhourDate.Name = "DTPhourDate";
            this.DTPhourDate.Size = new System.Drawing.Size(327, 30);
            this.DTPhourDate.TabIndex = 13;
            // 
            // cmbCourses
            // 
            this.cmbCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(94, 47);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(121, 24);
            this.cmbCourses.TabIndex = 10;
            // 
            // butAddHours
            // 
            this.butAddHours.BackColor = System.Drawing.Color.White;
            this.butAddHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddHours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddHours.ForeColor = System.Drawing.Color.Navy;
            this.butAddHours.Location = new System.Drawing.Point(313, 180);
            this.butAddHours.Name = "butAddHours";
            this.butAddHours.Size = new System.Drawing.Size(98, 36);
            this.butAddHours.TabIndex = 9;
            this.butAddHours.Text = "Add Course";
            this.butAddHours.UseVisualStyleBackColor = false;
            this.butAddHours.Click += new System.EventHandler(this.butAddHours_Click);
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(89, 187);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(125, 30);
            this.txtHours.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(362, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(436, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Week";
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.White;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.ForeColor = System.Drawing.Color.Navy;
            this.btnRedo.Location = new System.Drawing.Point(110, 265);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 23);
            this.btnRedo.TabIndex = 13;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.White;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.Navy;
            this.btnUndo.Location = new System.Drawing.Point(29, 265);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 12;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // StudyLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(946, 545);
            this.Controls.Add(this.mainPanel);
            this.MaximumSize = new System.Drawing.Size(964, 592);
            this.MinimumSize = new System.Drawing.Size(964, 592);
            this.Name = "StudyLogForm";
            this.Text = "Form Template";
            this.Load += new System.EventHandler(this.StudyLogForm_Load);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.nav1, 0);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butAddHours;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPhourDate;
        private System.Windows.Forms.Label successMessageLabel;
        private System.Windows.Forms.Label hoursErrorMessageLabel;
        private System.Windows.Forms.Label dateErrorMessageLabel;
        private System.Windows.Forms.Label courseErrorMessageLabel;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
    }
}