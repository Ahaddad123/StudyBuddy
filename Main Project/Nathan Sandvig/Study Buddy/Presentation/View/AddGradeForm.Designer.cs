namespace Study_Buddy.Presentation
{
    partial class AddGradeForm
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
            this.successMessageLabel = new System.Windows.Forms.Label();
            this.scoreErrorMessageLabel = new System.Windows.Forms.Label();
            this.nameErrorMessageLabel = new System.Windows.Forms.Label();
            this.txtNameAssign = new System.Windows.Forms.ComboBox();
            this.butAddAssig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPointsAssign = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.btnRedo);
            this.groupBox1.Controls.Add(this.btnUndo);
            this.groupBox1.Controls.Add(this.successMessageLabel);
            this.groupBox1.Controls.Add(this.scoreErrorMessageLabel);
            this.groupBox1.Controls.Add(this.nameErrorMessageLabel);
            this.groupBox1.Controls.Add(this.txtNameAssign);
            this.groupBox1.Controls.Add(this.butAddAssig);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPointsAssign);
            this.groupBox1.Location = new System.Drawing.Point(90, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // successMessageLabel
            // 
            this.successMessageLabel.AutoSize = true;
            this.successMessageLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successMessageLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.successMessageLabel.Location = new System.Drawing.Point(55, 212);
            this.successMessageLabel.Name = "successMessageLabel";
            this.successMessageLabel.Size = new System.Drawing.Size(0, 23);
            this.successMessageLabel.TabIndex = 9;
            // 
            // scoreErrorMessageLabel
            // 
            this.scoreErrorMessageLabel.AutoSize = true;
            this.scoreErrorMessageLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.scoreErrorMessageLabel.Location = new System.Drawing.Point(223, 124);
            this.scoreErrorMessageLabel.Name = "scoreErrorMessageLabel";
            this.scoreErrorMessageLabel.Size = new System.Drawing.Size(0, 23);
            this.scoreErrorMessageLabel.TabIndex = 8;
            // 
            // nameErrorMessageLabel
            // 
            this.nameErrorMessageLabel.AutoSize = true;
            this.nameErrorMessageLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorMessageLabel.Location = new System.Drawing.Point(223, 67);
            this.nameErrorMessageLabel.Name = "nameErrorMessageLabel";
            this.nameErrorMessageLabel.Size = new System.Drawing.Size(0, 23);
            this.nameErrorMessageLabel.TabIndex = 7;
            // 
            // txtNameAssign
            // 
            this.txtNameAssign.FormattingEnabled = true;
            this.txtNameAssign.Location = new System.Drawing.Point(227, 40);
            this.txtNameAssign.Name = "txtNameAssign";
            this.txtNameAssign.Size = new System.Drawing.Size(209, 24);
            this.txtNameAssign.TabIndex = 4;
            // 
            // butAddAssig
            // 
            this.butAddAssig.BackColor = System.Drawing.Color.White;
            this.butAddAssig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddAssig.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddAssig.ForeColor = System.Drawing.Color.Navy;
            this.butAddAssig.Location = new System.Drawing.Point(319, 161);
            this.butAddAssig.Name = "butAddAssig";
            this.butAddAssig.Size = new System.Drawing.Size(105, 30);
            this.butAddAssig.TabIndex = 6;
            this.butAddAssig.Text = "Add Grade";
            this.butAddAssig.UseVisualStyleBackColor = false;
            this.butAddAssig.Click += new System.EventHandler(this.butAddAssig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(152, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(55, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assignment Name";
            // 
            // txtPointsAssign
            // 
            this.txtPointsAssign.Location = new System.Drawing.Point(227, 100);
            this.txtPointsAssign.Name = "txtPointsAssign";
            this.txtPointsAssign.Size = new System.Drawing.Size(100, 22);
            this.txtPointsAssign.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.12963F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.87037F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(324, 95);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.83333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.16667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1080, 720);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.White;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.Navy;
            this.btnUndo.Location = new System.Drawing.Point(20, 215);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 10;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.White;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.ForeColor = System.Drawing.Color.Navy;
            this.btnRedo.Location = new System.Drawing.Point(101, 215);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 23);
            this.btnRedo.TabIndex = 11;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // AddGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(946, 545);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximumSize = new System.Drawing.Size(964, 592);
            this.MinimumSize = new System.Drawing.Size(964, 592);
            this.Name = "AddGradeForm";
            this.Text = "Form Template";
            this.Load += new System.EventHandler(this.AddGradeForm_Load);
            this.Controls.SetChildIndex(this.nav1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butAddAssig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPointsAssign;
        private System.Windows.Forms.ComboBox txtNameAssign;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label nameErrorMessageLabel;
        private System.Windows.Forms.Label scoreErrorMessageLabel;
        private System.Windows.Forms.Label successMessageLabel;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
    }
}