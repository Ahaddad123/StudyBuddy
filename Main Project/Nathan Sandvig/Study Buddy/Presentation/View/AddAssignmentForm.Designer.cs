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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpAssignDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.butAddAssig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.txtPointsAssign = new System.Windows.Forms.TextBox();
            this.txtNameAssign = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Location = new System.Drawing.Point(321, 112);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.MaximumSize = new System.Drawing.Size(810, 585);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(611, 405);
            this.mainPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.dtpAssignDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbCourses);
            this.groupBox1.Controls.Add(this.butAddAssig);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPriority);
            this.groupBox1.Controls.Add(this.txtPointsAssign);
            this.groupBox1.Controls.Add(this.txtNameAssign);
            this.groupBox1.Location = new System.Drawing.Point(68, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtpAssignDate
            // 
            this.dtpAssignDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAssignDate.Location = new System.Drawing.Point(158, 191);
            this.dtpAssignDate.Name = "dtpAssignDate";
            this.dtpAssignDate.Size = new System.Drawing.Size(332, 30);
            this.dtpAssignDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 191);
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
            this.label5.Location = new System.Drawing.Point(30, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Course";
            // 
            // cmbCourses
            // 
            this.cmbCourses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(158, 104);
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
            this.butAddAssig.Location = new System.Drawing.Point(363, 243);
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
            this.label3.Location = new System.Drawing.Point(29, 149);
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
            this.label2.Location = new System.Drawing.Point(28, 71);
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
            // txtPriority
            // 
            this.txtPriority.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriority.Location = new System.Drawing.Point(158, 149);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(125, 30);
            this.txtPriority.TabIndex = 2;
            // 
            // txtPointsAssign
            // 
            this.txtPointsAssign.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPointsAssign.Location = new System.Drawing.Point(158, 64);
            this.txtPointsAssign.Name = "txtPointsAssign";
            this.txtPointsAssign.Size = new System.Drawing.Size(125, 30);
            this.txtPointsAssign.TabIndex = 1;
            // 
            // txtNameAssign
            // 
            this.txtNameAssign.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameAssign.Location = new System.Drawing.Point(158, 27);
            this.txtNameAssign.Name = "txtNameAssign";
            this.txtNameAssign.Size = new System.Drawing.Size(318, 30);
            this.txtNameAssign.TabIndex = 0;
            // 
            // AddAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(756, 436);
            this.Controls.Add(this.mainPanel);
            this.MaximumSize = new System.Drawing.Size(964, 592);
            this.MinimumSize = new System.Drawing.Size(964, 592);
            this.Name = "AddAssignmentForm";
            this.Text = "Form Template";
            this.Load += new System.EventHandler(this.AddAssignmentForm_Load);
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
        private System.Windows.Forms.Button butAddAssig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.TextBox txtPointsAssign;
        private System.Windows.Forms.TextBox txtNameAssign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.DateTimePicker dtpAssignDate;
        private System.Windows.Forms.Label label1;
    }
}