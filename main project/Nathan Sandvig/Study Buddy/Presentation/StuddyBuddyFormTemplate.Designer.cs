namespace Study_Buddy.Presentation
{
    partial class StuddyBuddyFormTemplate
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
            this.nav1 = new Study_Buddy.Presentation.Nav();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(383, 143);
            this.mainPanel.MaximumSize = new System.Drawing.Size(1080, 720);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(815, 498);
            this.mainPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(374, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main Header";
            // 
            // nav1
            // 
            this.nav1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nav1.Location = new System.Drawing.Point(0, -1);
            this.nav1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nav1.MaximumSize = new System.Drawing.Size(315, 1080);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(315, 1080);
            this.nav1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(108)))), ((int)(((byte)(221)))));
            this.button1.Location = new System.Drawing.Point(996, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // StuddyBuddyFormTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.nav1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "StuddyBuddyFormTemplate";
            this.Text = "Form Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Nav nav1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}