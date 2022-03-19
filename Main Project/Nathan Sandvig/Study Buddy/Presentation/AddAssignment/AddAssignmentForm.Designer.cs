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
            this.label1 = new System.Windows.Forms.Label();
            this.nav1 = new Study_Buddy.Presentation.Nav(this);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.mainPanel.Location = new System.Drawing.Point(287, 116);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.MaximumSize = new System.Drawing.Size(810, 585);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(611, 405);
            this.mainPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Assignment";
            // 
            // nav1
            // 
            this.nav1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nav1.Location = new System.Drawing.Point(0, -1);
            this.nav1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nav1.MaximumSize = new System.Drawing.Size(236, 878);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(236, 878);
            this.nav1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(108)))), ((int)(((byte)(221)))));
            this.button1.Location = new System.Drawing.Point(747, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.butAddAssig);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPriority);
            this.groupBox1.Controls.Add(this.txtPointsAssign);
            this.groupBox1.Controls.Add(this.txtNameAssign);
            this.groupBox1.Location = new System.Drawing.Point(132, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(33, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(74, 101);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(100, 20);
            this.txtPriority.TabIndex = 2;
            // 
            // txtPointsAssign
            // 
            this.txtPointsAssign.Location = new System.Drawing.Point(74, 64);
            this.txtPointsAssign.Name = "txtPointsAssign";
            this.txtPointsAssign.Size = new System.Drawing.Size(100, 20);
            this.txtPointsAssign.TabIndex = 1;
            // 
            // txtNameAssign
            // 
            this.txtNameAssign.Location = new System.Drawing.Point(74, 29);
            this.txtNameAssign.Name = "txtNameAssign";
            this.txtNameAssign.Size = new System.Drawing.Size(248, 20);
            this.txtNameAssign.TabIndex = 0;
            // 
            // AddAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.nav1);
            this.MaximumSize = new System.Drawing.Size(964, 592);
            this.Name = "AddAssignmentForm";
            this.Text = "Form Template";
            this.mainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Nav nav1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butAddAssig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.TextBox txtPointsAssign;
        private System.Windows.Forms.TextBox txtNameAssign;
    }
}