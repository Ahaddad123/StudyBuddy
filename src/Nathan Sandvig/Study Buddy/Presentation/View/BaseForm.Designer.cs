namespace Study_Buddy.Presentation.View
{
    partial class BaseForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainHeader = new System.Windows.Forms.Label();
            this.nav1 = new Study_Buddy.Presentation.Nav();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.mainHeader, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(318, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 89);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mainHeader
            // 
            this.mainHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainHeader.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.mainHeader, 3);
            this.mainHeader.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeader.ForeColor = System.Drawing.Color.Navy;
            this.mainHeader.Location = new System.Drawing.Point(327, 20);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(373, 49);
            this.mainHeader.TabIndex = 1;
            this.mainHeader.Text = "Main Header Here";
            this.mainHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nav1
            // 
            this.nav1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nav1.Location = new System.Drawing.Point(0, 0);
            this.nav1.Margin = new System.Windows.Forms.Padding(0);
            this.nav1.MaximumSize = new System.Drawing.Size(315, 780);
            this.nav1.MinimumSize = new System.Drawing.Size(315, 768);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(315, 780);
            this.nav1.TabIndex = 0;
            // 
            // BaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.nav1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "BaseForm";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BaseForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.Label mainHeader;
        protected Nav nav1;
    }
}
