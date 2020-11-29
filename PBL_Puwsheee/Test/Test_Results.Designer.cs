namespace PBL_Puwsheee.Test
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
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(46, 67);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(56, 15);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Your Score";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(46, 211);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(74, 15);
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
            this.currentscoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentscoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentscoreLabel.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.currentscoreLabel.HoverState.Parent = this.currentscoreLabel;
            this.currentscoreLabel.IconLeftSize = new System.Drawing.Size(0, 0);
            this.currentscoreLabel.IconRightSize = new System.Drawing.Size(0, 0);
            this.currentscoreLabel.Location = new System.Drawing.Point(32, 33);
            this.currentscoreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.currentscoreLabel.Multiline = true;
            this.currentscoreLabel.Name = "currentscoreLabel";
            this.currentscoreLabel.PasswordChar = '\0';
            this.currentscoreLabel.PlaceholderText = "";
            this.currentscoreLabel.SelectedText = "";
            this.currentscoreLabel.SelectionStart = 2;
            this.currentscoreLabel.ShadowDecoration.Parent = this.currentscoreLabel;
            this.currentscoreLabel.Size = new System.Drawing.Size(42, 36);
            this.currentscoreLabel.TabIndex = 11;
            this.currentscoreLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // averagescoreProgressBar
            // 
            this.averagescoreProgressBar.Controls.Add(this.averageProgressBarLabel);
            this.averagescoreProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.averagescoreProgressBar.Location = new System.Drawing.Point(51, 232);
            this.averagescoreProgressBar.Name = "averagescoreProgressBar";
            this.averagescoreProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.averagescoreProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.averagescoreProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.averagescoreProgressBar.ShadowDecoration.Parent = this.averagescoreProgressBar;
            this.averagescoreProgressBar.Size = new System.Drawing.Size(109, 105);
            this.averagescoreProgressBar.TabIndex = 4;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "60";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.IconLeftSize = new System.Drawing.Size(0, 0);
            this.guna2TextBox2.IconRightSize = new System.Drawing.Size(0, 0);
            this.guna2TextBox2.Location = new System.Drawing.Point(32, 33);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2TextBox2.Multiline = true;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.SelectionStart = 2;
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(42, 37);
            this.guna2TextBox2.TabIndex = 12;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.guna2Button1.BorderRadius = 16;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.DescriptionLabel.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.HoverState.Parent = this.DescriptionLabel;
            this.DescriptionLabel.Location = new System.Drawing.Point(200, 101);
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
            this.testresultLabel.DefaultText = "asassad\r\nsasasdddddddddddddddddddddddddddda\r\nadsdads\r\ndasda";
            this.testresultLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.testresultLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.testresultLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.testresultLabel.DisabledState.Parent = this.testresultLabel;
            this.testresultLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.testresultLabel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.testresultLabel.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.testresultLabel.FocusedState.Parent = this.testresultLabel;
            this.testresultLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.testresultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.testresultLabel.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.testresultLabel.HoverState.Parent = this.testresultLabel;
            this.testresultLabel.Location = new System.Drawing.Point(249, 44);
            this.testresultLabel.Name = "testresultLabel";
            this.testresultLabel.PasswordChar = '\0';
            this.testresultLabel.PlaceholderText = "";
            this.testresultLabel.ReadOnly = true;
            this.testresultLabel.SelectedText = "";
            this.testresultLabel.SelectionStart = 59;
            this.testresultLabel.ShadowDecoration.Parent = this.testresultLabel;
            this.testresultLabel.Size = new System.Drawing.Size(277, 38);
            this.testresultLabel.TabIndex = 11;
            this.testresultLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // averageScoreTimer
            // 
            this.averageScoreTimer.Enabled = true;
            this.averageScoreTimer.Interval = 30;
            this.averageScoreTimer.Tick += new System.EventHandler(this.animateAverageScore);
            // 
            // Test_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(640, 370);
            this.Controls.Add(this.testresultLabel);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.averagescoreProgressBar);
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
        private Guna.UI2.WinForms.Guna2TextBox averageProgressBarLabel;
        private Guna.UI2.WinForms.Guna2TextBox testresultLabel;
        private System.Windows.Forms.Timer averageScoreTimer;
    }
}