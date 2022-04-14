namespace Study_Buddy.Presentation
{
    partial class DayBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDays = new System.Windows.Forms.Label();
            this.eventLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(0, 0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(27, 19);
            this.labelDays.TabIndex = 0;
            this.labelDays.Text = "00";
            // 
            // eventLabel1
            // 
            this.eventLabel1.AutoSize = true;
            this.eventLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventLabel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLabel1.Location = new System.Drawing.Point(3, 66);
            this.eventLabel1.Name = "eventLabel1";
            this.eventLabel1.Size = new System.Drawing.Size(0, 16);
            this.eventLabel1.TabIndex = 1;
            // 
            // DayBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.eventLabel1);
            this.Controls.Add(this.labelDays);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximumSize = new System.Drawing.Size(138, 85);
            this.MinimumSize = new System.Drawing.Size(138, 85);
            this.Name = "DayBox";
            this.Size = new System.Drawing.Size(138, 85);
            this.Load += new System.EventHandler(this.DayBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label eventLabel1;
    }
}
