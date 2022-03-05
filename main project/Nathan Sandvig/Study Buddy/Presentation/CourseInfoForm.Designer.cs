namespace Study_Buddy.Presentation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNameAssign = new System.Windows.Forms.TextBox();
            this.txtPointsAssign = new System.Windows.Forms.TextBox();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butAddAssig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCourseNameCode = new System.Windows.Forms.Label();
            this.lblClasscode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.butAddAssig);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPriority);
            this.groupBox1.Controls.Add(this.txtPointsAssign);
            this.groupBox1.Controls.Add(this.txtNameAssign);
            this.groupBox1.Location = new System.Drawing.Point(157, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtNameAssign
            // 
            this.txtNameAssign.Location = new System.Drawing.Point(74, 29);
            this.txtNameAssign.Name = "txtNameAssign";
            this.txtNameAssign.Size = new System.Drawing.Size(248, 20);
            this.txtNameAssign.TabIndex = 0;
            // 
            // txtPointsAssign
            // 
            this.txtPointsAssign.Location = new System.Drawing.Point(74, 64);
            this.txtPointsAssign.Name = "txtPointsAssign";
            this.txtPointsAssign.Size = new System.Drawing.Size(100, 20);
            this.txtPointsAssign.TabIndex = 1;
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(74, 101);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(100, 20);
            this.txtPriority.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Priority";
            // 
            // butAddAssig
            // 
            this.butAddAssig.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.butAddAssig.Location = new System.Drawing.Point(217, 101);
            this.butAddAssig.Name = "butAddAssig";
            this.butAddAssig.Size = new System.Drawing.Size(105, 30);
            this.butAddAssig.TabIndex = 6;
            this.butAddAssig.Text = "Add Assignment";
            this.butAddAssig.UseVisualStyleBackColor = true;
            this.butAddAssig.Click += new System.EventHandler(this.butAddAssig_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(152, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Assignment";
            // 
            // lblCourseNameCode
            // 
            this.lblCourseNameCode.AutoSize = true;
            this.lblCourseNameCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseNameCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCourseNameCode.Location = new System.Drawing.Point(154, 63);
            this.lblCourseNameCode.Name = "lblCourseNameCode";
            this.lblCourseNameCode.Size = new System.Drawing.Size(44, 16);
            this.lblCourseNameCode.TabIndex = 8;
            this.lblCourseNameCode.Text = "label5";
            // 
            // lblClasscode
            // 
            this.lblClasscode.AutoSize = true;
            this.lblClasscode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasscode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClasscode.Location = new System.Drawing.Point(638, 63);
            this.lblClasscode.Name = "lblClasscode";
            this.lblClasscode.Size = new System.Drawing.Size(70, 25);
            this.lblClasscode.TabIndex = 9;
            this.lblClasscode.Text = "label6";
            // 
            // AddAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lblClasscode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCourseNameCode);
            this.Controls.Add(this.label4);
            this.Name = "AddAssignmentForm";
            this.Text = "AddAssignmentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.TextBox txtPointsAssign;
        private System.Windows.Forms.TextBox txtNameAssign;
        private System.Windows.Forms.Button butAddAssig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCourseNameCode;
        private System.Windows.Forms.Label lblClasscode;
    }
}