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
            this.labelPageInfoHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.nav1 = new Study_Buddy.Presentation.Nav();
            this.SuspendLayout();
            // 
            // labelPageInfoHeader
            // 
            this.labelPageInfoHeader.AutoSize = true;
            this.labelPageInfoHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelPageInfoHeader.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageInfoHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPageInfoHeader.Location = new System.Drawing.Point(436, 55);
            this.labelPageInfoHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPageInfoHeader.Name = "labelPageInfoHeader";
            this.labelPageInfoHeader.Size = new System.Drawing.Size(257, 67);
            this.labelPageInfoHeader.TabIndex = 7;
            this.labelPageInfoHeader.Text = "Header1";
            this.labelPageInfoHeader.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(451, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "label5";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(448, 220);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1382, 752);
            this.panelMain.TabIndex = 11;
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
            // StuddyBuddyFormTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.nav1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPageInfoHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "StuddyBuddyFormTemplate";
            this.Text = "Form Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPageInfoHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMain;
        private Nav nav1;
    }
}