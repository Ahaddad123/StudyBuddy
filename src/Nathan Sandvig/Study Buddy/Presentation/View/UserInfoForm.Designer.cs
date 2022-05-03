﻿namespace Study_Buddy.Presentation.View
{
    partial class UserInfoForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fullName = new System.Windows.Forms.Label();
            this.userSchool = new System.Windows.Forms.Label();
            this.userGPA = new System.Windows.Forms.Label();
            this.gpaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpaChart)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mainTableLayoutPanel.Controls.Add(this.fullName, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.userSchool, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.userGPA, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.gpaChart, 0, 3);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(318, 95);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.96F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.44F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.12F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1028, 625);
            this.mainTableLayoutPanel.TabIndex = 1;
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.Location = new System.Drawing.Point(3, 0);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(161, 35);
            this.fullName.TabIndex = 0;
            this.fullName.Text = "Your Name";
            // 
            // userSchool
            // 
            this.userSchool.AutoSize = true;
            this.userSchool.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSchool.Location = new System.Drawing.Point(3, 56);
            this.userSchool.Name = "userSchool";
            this.userSchool.Size = new System.Drawing.Size(132, 26);
            this.userSchool.TabIndex = 1;
            this.userSchool.Text = "Your School";
            // 
            // userGPA
            // 
            this.userGPA.AutoSize = true;
            this.userGPA.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGPA.Location = new System.Drawing.Point(3, 108);
            this.userGPA.Name = "userGPA";
            this.userGPA.Size = new System.Drawing.Size(191, 26);
            this.userGPA.TabIndex = 2;
            this.userGPA.Text = "Your Current GPA";
            this.userGPA.Click += new System.EventHandler(this.userGPA_Click);
            // 
            // gpaChart
            // 
            chartArea1.Name = "ChartArea1";
            this.gpaChart.ChartAreas.Add(chartArea1);
            this.mainTableLayoutPanel.SetColumnSpan(this.gpaChart, 2);
            legend1.Name = "Legend1";
            this.gpaChart.Legends.Add(legend1);
            this.gpaChart.Location = new System.Drawing.Point(3, 195);
            this.gpaChart.Name = "gpaChart";
            this.gpaChart.Size = new System.Drawing.Size(678, 300);
            this.gpaChart.TabIndex = 3;
            this.gpaChart.Text = "chart1";
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            this.Controls.SetChildIndex(this.nav1, 0);
            this.Controls.SetChildIndex(this.mainTableLayoutPanel, 0);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpaChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label userSchool;
        private System.Windows.Forms.Label userGPA;
        private System.Windows.Forms.DataVisualization.Charting.Chart gpaChart;
    }
}