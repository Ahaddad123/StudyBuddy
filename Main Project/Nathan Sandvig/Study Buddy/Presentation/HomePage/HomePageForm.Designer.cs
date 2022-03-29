namespace Study_Buddy.Presentation
{
    partial class HomePageForm
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
            this.name = new System.Windows.Forms.Label();
            this.nav1 = new Study_Buddy.Presentation.Nav();
            this.gpa = new System.Windows.Forms.Label();
            this.couses = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.couses);
            this.mainPanel.Controls.Add(this.gpa);
            this.mainPanel.Controls.Add(this.name);
            this.mainPanel.Location = new System.Drawing.Point(287, 116);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
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
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home Page";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(31, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 55);
            this.name.TabIndex = 0;
            this.name.Text = "label";
            // 
            // nav1
            // 
            this.nav1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nav1.Location = new System.Drawing.Point(0, -1);
            this.nav1.Margin = new System.Windows.Forms.Padding(2);
            this.nav1.MaximumSize = new System.Drawing.Size(236, 878);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(236, 878);
            this.nav1.TabIndex = 0;
            // 
            // gpa
            // 
            this.gpa.AutoSize = true;
            this.gpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa.Location = new System.Drawing.Point(35, 76);
            this.gpa.Name = "gpa";
            this.gpa.Size = new System.Drawing.Size(84, 33);
            this.gpa.TabIndex = 1;
            this.gpa.Text = "GPA:";
            // 
            // couses
            // 
            this.couses.ColumnCount = 2;
            this.couses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.couses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.couses.Location = new System.Drawing.Point(41, 187);
            this.couses.Name = "couses";
            this.couses.RowCount = 1;
            this.couses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.couses.Size = new System.Drawing.Size(478, 192);
            this.couses.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your study hours this week";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(947, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.nav1);
            this.MaximumSize = new System.Drawing.Size(963, 591);
            this.Name = "HomePageForm";
            this.Text = "Form Template";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Nav nav1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label gpa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel couses;
    }
}