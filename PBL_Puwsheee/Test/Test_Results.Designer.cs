﻿namespace PBL_Puwsheee.Test
{
    partial class Test_Results
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.currentscoreProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.currentscoreLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.averagescoreProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.averageLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.currentScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.DescriptionLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.testresultLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.averageScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.currentscoreProgressBar.SuspendLayout();
            this.averagescoreProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(46, 67);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(64, 17);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Your Score";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(46, 211);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(86, 17);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Average Score";
            // 
            // currentscoreProgressBar
            // 
            this.currentscoreProgressBar.Controls.Add(this.currentscoreLabel);
            this.currentscoreProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.currentscoreProgressBar.Location = new System.Drawing.Point(56, 88);
            this.currentscoreProgressBar.Maximum = 50;
            this.currentscoreProgressBar.Name = "currentscoreProgressBar";
            this.currentscoreProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.currentscoreProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.currentscoreProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.currentscoreProgressBar.ShadowDecoration.Parent = this.currentscoreProgressBar;
            this.currentscoreProgressBar.Size = new System.Drawing.Size(109, 105);
            this.currentscoreProgressBar.TabIndex = 3;
            // 
            // currentscoreLabel
            // 
            this.currentscoreLabel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.currentscoreLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentscoreLabel.DefaultText = "50";
            this.currentscoreLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentscoreLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentscoreLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentscoreLabel.DisabledState.Parent = this.currentscoreLabel;
            this.currentscoreLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentscoreLabel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.currentscoreLabel.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.currentscoreLabel.FocusedState.Parent = this.currentscoreLabel;
            this.currentscoreLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 10F);
            this.currentscoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentscoreLabel.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.currentscoreLabel.HoverState.Parent = this.currentscoreLabel;
            this.currentscoreLabel.IconLeftSize = new System.Drawing.Size(0, 0);
            this.currentscoreLabel.IconRightSize = new System.Drawing.Size(0, 0);
            this.currentscoreLabel.Location = new System.Drawing.Point(34, 35);
            this.currentscoreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.currentscoreLabel.Multiline = true;
            this.currentscoreLabel.Name = "currentscoreLabel";
            this.currentscoreLabel.PasswordChar = '\0';
            this.currentscoreLabel.PlaceholderText = "";
            this.currentscoreLabel.SelectedText = "";
            this.currentscoreLabel.SelectionStart = 2;
            this.currentscoreLabel.ShadowDecoration.Parent = this.currentscoreLabel;
            this.currentscoreLabel.Size = new System.Drawing.Size(37, 35);
            this.currentscoreLabel.TabIndex = 11;
            this.currentscoreLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // averagescoreProgressBar
            // 
            this.averagescoreProgressBar.Controls.Add(this.averageLabel);
            this.averagescoreProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.averagescoreProgressBar.Location = new System.Drawing.Point(51, 232);
            this.averagescoreProgressBar.Maximum = 50;
            this.averagescoreProgressBar.Name = "averagescoreProgressBar";
            this.averagescoreProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.averagescoreProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.averagescoreProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.averagescoreProgressBar.ShadowDecoration.Parent = this.averagescoreProgressBar;
            this.averagescoreProgressBar.Size = new System.Drawing.Size(109, 105);
            this.averagescoreProgressBar.TabIndex = 4;
            // 
            // averageLabel
            // 
            this.averageLabel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.averageLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.averageLabel.DefaultText = "50";
            this.averageLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.averageLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.averageLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.averageLabel.DisabledState.Parent = this.averageLabel;
            this.averageLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.averageLabel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.averageLabel.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.averageLabel.FocusedState.Parent = this.averageLabel;
            this.averageLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 10F);
            this.averageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.averageLabel.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.averageLabel.HoverState.Parent = this.averageLabel;
            this.averageLabel.IconLeftSize = new System.Drawing.Size(0, 0);
            this.averageLabel.IconRightSize = new System.Drawing.Size(0, 0);
            this.averageLabel.Location = new System.Drawing.Point(36, 35);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.averageLabel.Multiline = true;
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.PasswordChar = '\0';
            this.averageLabel.PlaceholderText = "";
            this.averageLabel.SelectedText = "";
            this.averageLabel.SelectionStart = 2;
            this.averageLabel.ShadowDecoration.Parent = this.averageLabel;
            this.averageLabel.Size = new System.Drawing.Size(37, 35);
            this.averageLabel.TabIndex = 12;
            this.averageLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.guna2Button1.BorderRadius = 16;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.guna2Button1.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(339, 301);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(118, 36);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Okay!";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // currentScoreTimer
            // 
            this.currentScoreTimer.Enabled = true;
            this.currentScoreTimer.Interval = 65;
            this.currentScoreTimer.Tick += new System.EventHandler(this.animateCurrentScore);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.DescriptionLabel.BorderRadius = 16;
            this.DescriptionLabel.BorderThickness = 2;
            this.DescriptionLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionLabel.DefaultText = "asassad\r\nsasasdddddddddddddddddddddddddddda\r\nadsdads\r\ndasda";
            this.DescriptionLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DescriptionLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DescriptionLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionLabel.DisabledState.Parent = this.DescriptionLabel;
            this.DescriptionLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionLabel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.DescriptionLabel.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.FocusedState.Parent = this.DescriptionLabel;
            this.DescriptionLabel.Font = new System.Drawing.Font("Robaga Rounded Black", 10F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.DescriptionLabel.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.HoverState.Parent = this.DescriptionLabel;
            this.DescriptionLabel.Location = new System.Drawing.Point(200, 101);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DescriptionLabel.Multiline = true;
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.PasswordChar = '\0';
            this.DescriptionLabel.PlaceholderText = "";
            this.DescriptionLabel.ReadOnly = true;
            this.DescriptionLabel.SelectedText = "";
            this.DescriptionLabel.SelectionStart = 59;
            this.DescriptionLabel.ShadowDecoration.Parent = this.DescriptionLabel;
            this.DescriptionLabel.Size = new System.Drawing.Size(384, 182);
            this.DescriptionLabel.TabIndex = 10;
            this.DescriptionLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // testresultLabel
            // 
            this.testresultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.testresultLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.testresultLabel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.testresultLabel.BorderRadius = 16;
            this.testresultLabel.BorderThickness = 2;
            this.testresultLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.testresultLabel.DefaultText = "Emotional Intelligence";
            this.testresultLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.testresultLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.testresultLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.testresultLabel.DisabledState.Parent = this.testresultLabel;
            this.testresultLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.testresultLabel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.testresultLabel.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.testresultLabel.FocusedState.Parent = this.testresultLabel;
            this.testresultLabel.Font = new System.Drawing.Font("Robaga Rounded Black", 15F);
            this.testresultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.testresultLabel.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.testresultLabel.HoverState.Parent = this.testresultLabel;
            this.testresultLabel.Location = new System.Drawing.Point(258, 44);
            this.testresultLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testresultLabel.Name = "testresultLabel";
            this.testresultLabel.PasswordChar = '\0';
            this.testresultLabel.PlaceholderText = "";
            this.testresultLabel.ReadOnly = true;
            this.testresultLabel.SelectedText = "";
            this.testresultLabel.SelectionStart = 22;
            this.testresultLabel.ShadowDecoration.Parent = this.testresultLabel;
            this.testresultLabel.Size = new System.Drawing.Size(266, 38);
            this.testresultLabel.TabIndex = 11;
            this.testresultLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // averageScoreTimer
            // 
            this.averageScoreTimer.Enabled = true;
            this.averageScoreTimer.Interval = 30;
            this.averageScoreTimer.Tick += new System.EventHandler(this.averageScoreTimer_Tick);
            // 
            // Test_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(640, 370);
            this.Controls.Add(this.averagescoreProgressBar);
            this.Controls.Add(this.testresultLabel);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.currentscoreProgressBar);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test_Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestResults";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Test_Results_Load);
            this.currentscoreProgressBar.ResumeLayout(false);
            this.averagescoreProgressBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar currentscoreProgressBar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar averagescoreProgressBar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Timer currentScoreTimer;
        private Guna.UI2.WinForms.Guna2TextBox DescriptionLabel;
        private Guna.UI2.WinForms.Guna2TextBox currentscoreLabel;
        private Guna.UI2.WinForms.Guna2TextBox testresultLabel;
        private System.Windows.Forms.Timer averageScoreTimer;
        private Guna.UI2.WinForms.Guna2TextBox averageLabel;
    }
}