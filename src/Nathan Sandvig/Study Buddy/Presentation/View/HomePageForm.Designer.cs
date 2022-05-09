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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewMyInfoBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 213);
            this.panel1.MaximumSize = new System.Drawing.Size(652, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 400);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(502, 0);
            this.label2.MaximumSize = new System.Drawing.Size(1000, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Grade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(500, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Study hours this Week";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.viewMyInfoBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.name);
            this.panel2.Location = new System.Drawing.Point(24, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 177);
            this.panel2.TabIndex = 7;
            // 
            // viewMyInfoBtn
            // 
            this.viewMyInfoBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewMyInfoBtn.BackColor = System.Drawing.Color.White;
            this.viewMyInfoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewMyInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewMyInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMyInfoBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMyInfoBtn.ForeColor = System.Drawing.Color.Navy;
            this.viewMyInfoBtn.Location = new System.Drawing.Point(3, 73);
            this.viewMyInfoBtn.Name = "viewMyInfoBtn";
            this.viewMyInfoBtn.Size = new System.Drawing.Size(173, 45);
            this.viewMyInfoBtn.TabIndex = 3;
            this.viewMyInfoBtn.Text = "View my info";
            this.viewMyInfoBtn.UseVisualStyleBackColor = false;
            this.viewMyInfoBtn.Click += new System.EventHandler(this.viewMyInfoBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Study_Buddy.Properties.Resources.user_icon_10;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 61);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Navy;
            this.name.Location = new System.Drawing.Point(73, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(154, 67);
            this.name.TabIndex = 0;
            this.name.Text = "label";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(318, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 627);
            this.panel3.TabIndex = 0;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(963, 591);
            this.Name = "HomePageForm";
            this.Text = "Form Template";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.Controls.SetChildIndex(this.nav1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button viewMyInfoBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}