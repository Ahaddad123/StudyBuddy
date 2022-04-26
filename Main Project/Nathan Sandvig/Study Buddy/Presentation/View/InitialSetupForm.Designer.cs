namespace Study_Buddy.Presentation.View
{
    partial class InitialSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.btnDone = new System.Windows.Forms.Button();
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.courseListPanel = new System.Windows.Forms.Panel();
            this.userCourseList1 = new Study_Buddy.Presentation.View.UserCourseList();
            this.addCourseBox1 = new Study_Buddy.Presentation.View.AddCourseBox();
            this.labelCourses = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.courseListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Navy;
            this.btnDone.Location = new System.Drawing.Point(1145, 647);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(173, 48);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done!";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.welcomeMessage.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessage.ForeColor = System.Drawing.Color.White;
            this.welcomeMessage.Location = new System.Drawing.Point(225, 16);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(797, 45);
            this.welcomeMessage.TabIndex = 0;
            this.welcomeMessage.Text = "Thanks for joining.  Let\'s set up your classes.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.courseListPanel);
            this.panel1.Controls.Add(this.addCourseBox1);
            this.panel1.Controls.Add(this.welcomeMessage);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 719);
            this.panel1.TabIndex = 10;
            // 
            // courseListPanel
            // 
            this.courseListPanel.Controls.Add(this.labelCourses);
            this.courseListPanel.Controls.Add(this.userCourseList1);
            this.courseListPanel.Location = new System.Drawing.Point(1011, 75);
            this.courseListPanel.Name = "courseListPanel";
            this.courseListPanel.Size = new System.Drawing.Size(307, 558);
            this.courseListPanel.TabIndex = 11;
            // 
            // userCourseList1
            // 
            this.userCourseList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userCourseList1.BackColor = System.Drawing.Color.Transparent;
            this.userCourseList1.Location = new System.Drawing.Point(3, 54);
            this.userCourseList1.Name = "userCourseList1";
            this.userCourseList1.Size = new System.Drawing.Size(304, 504);
            this.userCourseList1.TabIndex = 10;
            // 
            // addCourseBox1
            // 
            this.addCourseBox1.Location = new System.Drawing.Point(3, 75);
            this.addCourseBox1.Name = "addCourseBox1";
            this.addCourseBox1.Size = new System.Drawing.Size(1058, 558);
            this.addCourseBox1.TabIndex = 9;
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourses.ForeColor = System.Drawing.Color.White;
            this.labelCourses.Location = new System.Drawing.Point(78, 0);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(150, 26);
            this.labelCourses.TabIndex = 12;
            this.labelCourses.Text = "Your Courses";
            // 
            // InitialSetupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1078, 576);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "InitialSetupForm";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BaseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.courseListPanel.ResumeLayout(false);
            this.courseListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.Panel panel1;
        private AddCourseBox addCourseBox1;
        private UserCourseList userCourseList1;
        private System.Windows.Forms.Panel courseListPanel;
        private System.Windows.Forms.Label labelCourses;
    }
}
