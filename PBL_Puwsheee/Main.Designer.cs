namespace PBL_Puwsheee
{
    partial class Main
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
            this.usernameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MaxBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MinBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.windowsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.navBarPanel = new System.Windows.Forms.Panel();
            this.bgPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.displayPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.animateTimer = new System.Windows.Forms.Timer(this.components);
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.usericonPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.playablesButton = new Guna.UI2.WinForms.Guna2Button();
            this.analysisButton = new Guna.UI2.WinForms.Guna2Button();
            this.testButton = new Guna.UI2.WinForms.Guna2Button();
            this.moodtrackerButton = new Guna.UI2.WinForms.Guna2Button();
            this.calendarButton = new Guna.UI2.WinForms.Guna2Button();
            this.visualizationButton = new Guna.UI2.WinForms.Guna2Button();
            this.indicator = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.windowsPanel.SuspendLayout();
            this.navBarPanel.SuspendLayout();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usericonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Robaga Rounded Black", 11F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.usernameLabel.Location = new System.Drawing.Point(80, 19);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(82, 20);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            // 
            // MaxBtn
            // 
            this.MaxBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaxBtn.CheckedState.Parent = this.MaxBtn;
            this.MaxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxBtn.CustomImages.Parent = this.MaxBtn;
            this.MaxBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.MaxBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaxBtn.ForeColor = System.Drawing.Color.White;
            this.MaxBtn.HoverState.Parent = this.MaxBtn;
            this.MaxBtn.Location = new System.Drawing.Point(969, 21);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MaxBtn.ShadowDecoration.Parent = this.MaxBtn;
            this.MaxBtn.Size = new System.Drawing.Size(17, 17);
            this.MaxBtn.TabIndex = 0;
            this.MaxBtn.Click += new System.EventHandler(this.maximizePuwshee);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Location = new System.Drawing.Point(995, 21);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(17, 17);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Click += new System.EventHandler(this.exitPuwshee);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinBtn.CheckedState.Parent = this.MinBtn;
            this.MinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinBtn.CustomImages.Parent = this.MinBtn;
            this.MinBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.MinBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.HoverState.Parent = this.MinBtn;
            this.MinBtn.Location = new System.Drawing.Point(943, 21);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MinBtn.ShadowDecoration.Parent = this.MinBtn;
            this.MinBtn.Size = new System.Drawing.Size(17, 17);
            this.MinBtn.TabIndex = 0;
            this.MinBtn.Click += new System.EventHandler(this.minimizePuwshee);
            // 
            // windowsPanel
            // 
            this.windowsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.windowsPanel.Controls.Add(this.MinBtn);
            this.windowsPanel.Controls.Add(this.ExitBtn);
            this.windowsPanel.Controls.Add(this.MaxBtn);
            this.windowsPanel.Location = new System.Drawing.Point(0, -3);
            this.windowsPanel.Name = "windowsPanel";
            this.windowsPanel.ShadowDecoration.Parent = this.windowsPanel;
            this.windowsPanel.Size = new System.Drawing.Size(1060, 53);
            this.windowsPanel.TabIndex = 11;
            // 
            // navBarPanel
            // 
            this.navBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.navBarPanel.Controls.Add(this.visualizationButton);
            this.navBarPanel.Controls.Add(this.settingsButton);
            this.navBarPanel.Controls.Add(this.playablesButton);
            this.navBarPanel.Controls.Add(this.analysisButton);
            this.navBarPanel.Controls.Add(this.testButton);
            this.navBarPanel.Controls.Add(this.moodtrackerButton);
            this.navBarPanel.Controls.Add(this.calendarButton);
            this.navBarPanel.Controls.Add(this.indicator);
            this.navBarPanel.Location = new System.Drawing.Point(0, 47);
            this.navBarPanel.Name = "navBarPanel";
            this.navBarPanel.Size = new System.Drawing.Size(75, 564);
            this.navBarPanel.TabIndex = 12;
            this.navBarPanel.MouseEnter += new System.EventHandler(this.Main_Load);
            this.navBarPanel.MouseLeave += new System.EventHandler(this.Main_Load);
            // 
            // bgPanel
            // 
            this.bgPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bgPanel.BackColor = System.Drawing.Color.Transparent;
            this.bgPanel.Controls.Add(this.displayPanel);
            this.bgPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.bgPanel.Location = new System.Drawing.Point(76, 55);
            this.bgPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Radius = 10;
            this.bgPanel.ShadowColor = System.Drawing.Color.Black;
            this.bgPanel.ShadowShift = 1;
            this.bgPanel.Size = new System.Drawing.Size(963, 569);
            this.bgPanel.TabIndex = 13;
            // 
            // displayPanel
            // 
            this.displayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.displayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.displayPanel.BorderRadius = 20;
            this.displayPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayPanel.Location = new System.Drawing.Point(4, 11);
            this.displayPanel.Margin = new System.Windows.Forms.Padding(2);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.ShadowDecoration.Parent = this.displayPanel;
            this.displayPanel.Size = new System.Drawing.Size(936, 543);
            this.displayPanel.TabIndex = 0;
            this.displayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.displayPanel_Paint);
            // 
            // animateTimer
            // 
            this.animateTimer.Interval = 1;
            this.animateTimer.Tick += new System.EventHandler(this.animateTimer_Tick);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 30;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 50;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // tm
            // 
            this.tm.Interval = 1;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // usericonPicture
            // 
            this.usericonPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.usericonPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.usericonPicture.Location = new System.Drawing.Point(11, 11);
            this.usericonPicture.Margin = new System.Windows.Forms.Padding(2);
            this.usericonPicture.Name = "usericonPicture";
            this.usericonPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.usericonPicture.ShadowDecoration.Parent = this.usericonPicture;
            this.usericonPicture.Size = new System.Drawing.Size(55, 55);
            this.usericonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usericonPicture.TabIndex = 5;
            this.usericonPicture.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.sett;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.BorderRadius = 10;
            this.settingsButton.CheckedState.Parent = this.settingsButton;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.CustomImages.Parent = this.settingsButton;
            this.settingsButton.FillColor = System.Drawing.Color.Transparent;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.HoverState.Parent = this.settingsButton;
            this.settingsButton.Location = new System.Drawing.Point(27, 531);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.ShadowDecoration.Parent = this.settingsButton;
            this.settingsButton.Size = new System.Drawing.Size(22, 22);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = " ";
            this.settingsButton.Click += new System.EventHandler(this.clickOptions);
            // 
            // playablesButton
            // 
            this.playablesButton.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.Playables;
            this.playablesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playablesButton.BorderRadius = 10;
            this.playablesButton.CheckedState.Parent = this.playablesButton;
            this.playablesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playablesButton.CustomImages.Parent = this.playablesButton;
            this.playablesButton.FillColor = System.Drawing.Color.Transparent;
            this.playablesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playablesButton.ForeColor = System.Drawing.Color.White;
            this.playablesButton.HoverState.Parent = this.playablesButton;
            this.playablesButton.Location = new System.Drawing.Point(27, 340);
            this.playablesButton.Margin = new System.Windows.Forms.Padding(4);
            this.playablesButton.Name = "playablesButton";
            this.playablesButton.ShadowDecoration.Parent = this.playablesButton;
            this.playablesButton.Size = new System.Drawing.Size(22, 22);
            this.playablesButton.TabIndex = 7;
            this.playablesButton.Text = " ";
            this.playablesButton.Click += new System.EventHandler(this.clickPlayables);
            // 
            // analysisButton
            // 
            this.analysisButton.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.Analysis;
            this.analysisButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.analysisButton.BorderRadius = 10;
            this.analysisButton.CheckedState.Parent = this.analysisButton;
            this.analysisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.analysisButton.CustomImages.Parent = this.analysisButton;
            this.analysisButton.FillColor = System.Drawing.Color.Transparent;
            this.analysisButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.analysisButton.ForeColor = System.Drawing.Color.White;
            this.analysisButton.HoverState.Parent = this.analysisButton;
            this.analysisButton.Location = new System.Drawing.Point(27, 208);
            this.analysisButton.Margin = new System.Windows.Forms.Padding(4);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.ShadowDecoration.Parent = this.analysisButton;
            this.analysisButton.Size = new System.Drawing.Size(22, 22);
            this.analysisButton.TabIndex = 5;
            this.analysisButton.Text = " ";
            this.analysisButton.Click += new System.EventHandler(this.clickAnalysis);
            // 
            // testButton
            // 
            this.testButton.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.Test;
            this.testButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.testButton.BorderRadius = 10;
            this.testButton.CheckedState.Parent = this.testButton;
            this.testButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testButton.CustomImages.Parent = this.testButton;
            this.testButton.FillColor = System.Drawing.Color.Transparent;
            this.testButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.testButton.ForeColor = System.Drawing.Color.White;
            this.testButton.HoverState.Parent = this.testButton;
            this.testButton.Location = new System.Drawing.Point(27, 274);
            this.testButton.Margin = new System.Windows.Forms.Padding(4);
            this.testButton.Name = "testButton";
            this.testButton.ShadowDecoration.Parent = this.testButton;
            this.testButton.Size = new System.Drawing.Size(22, 22);
            this.testButton.TabIndex = 6;
            this.testButton.Text = " ";
            this.testButton.Click += new System.EventHandler(this.clickTest);
            // 
            // moodtrackerButton
            // 
            this.moodtrackerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(75)))), ((int)(((byte)(97)))));
            this.moodtrackerButton.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.Mood_Tracker;
            this.moodtrackerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moodtrackerButton.BorderRadius = 10;
            this.moodtrackerButton.CheckedState.Parent = this.moodtrackerButton;
            this.moodtrackerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moodtrackerButton.CustomImages.Parent = this.moodtrackerButton;
            this.moodtrackerButton.FillColor = System.Drawing.Color.Transparent;
            this.moodtrackerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.moodtrackerButton.ForeColor = System.Drawing.Color.White;
            this.moodtrackerButton.HoverState.Parent = this.moodtrackerButton;
            this.moodtrackerButton.Location = new System.Drawing.Point(27, 76);
            this.moodtrackerButton.Margin = new System.Windows.Forms.Padding(4);
            this.moodtrackerButton.Name = "moodtrackerButton";
            this.moodtrackerButton.ShadowDecoration.Parent = this.moodtrackerButton;
            this.moodtrackerButton.Size = new System.Drawing.Size(22, 22);
            this.moodtrackerButton.TabIndex = 3;
            this.moodtrackerButton.Text = " ";
            this.moodtrackerButton.Click += new System.EventHandler(this.clickMoodTracker);
            // 
            // calendarButton
            // 
            this.calendarButton.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.Calendar;
            this.calendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendarButton.BorderRadius = 10;
            this.calendarButton.CheckedState.Parent = this.calendarButton;
            this.calendarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarButton.CustomImages.Parent = this.calendarButton;
            this.calendarButton.FillColor = System.Drawing.Color.Transparent;
            this.calendarButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calendarButton.ForeColor = System.Drawing.Color.White;
            this.calendarButton.HoverState.Parent = this.calendarButton;
            this.calendarButton.Location = new System.Drawing.Point(27, 142);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(4);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.ShadowDecoration.Parent = this.calendarButton;
            this.calendarButton.Size = new System.Drawing.Size(22, 22);
            this.calendarButton.TabIndex = 4;
            this.calendarButton.Text = " ";
            this.calendarButton.Click += new System.EventHandler(this.clickCalendar);
            // 
            // visualizationButton
            // 
            this.visualizationButton.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.visualization;
            this.visualizationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visualizationButton.BorderRadius = 10;
            this.visualizationButton.CheckedState.Parent = this.visualizationButton;
            this.visualizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualizationButton.CustomImages.Parent = this.visualizationButton;
            this.visualizationButton.FillColor = System.Drawing.Color.Transparent;
            this.visualizationButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.visualizationButton.ForeColor = System.Drawing.Color.White;
            this.visualizationButton.HoverState.Parent = this.visualizationButton;
            this.visualizationButton.Location = new System.Drawing.Point(138, 217);
            this.visualizationButton.Margin = new System.Windows.Forms.Padding(4);
            this.visualizationButton.Name = "visualizationButton";
            this.visualizationButton.ShadowDecoration.Parent = this.visualizationButton;
            this.visualizationButton.Size = new System.Drawing.Size(22, 22);
            this.visualizationButton.TabIndex = 9;
            this.visualizationButton.Text = " ";
            this.visualizationButton.Visible = false;
            this.visualizationButton.Click += new System.EventHandler(this.clickVisualization);
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.Transparent;
            this.indicator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(75)))), ((int)(((byte)(97)))));
            this.indicator.Location = new System.Drawing.Point(8, 59);
            this.indicator.Name = "indicator";
            this.indicator.Radius = 10;
            this.indicator.ShadowColor = System.Drawing.Color.Black;
            this.indicator.ShadowDepth = 0;
            this.indicator.Size = new System.Drawing.Size(61, 55);
            this.indicator.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.bgPanel);
            this.Controls.Add(this.usericonPicture);
            this.Controls.Add(this.navBarPanel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.windowsPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.windowsPanel.ResumeLayout(false);
            this.navBarPanel.ResumeLayout(false);
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usericonPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel usernameLabel;
        private Guna.UI2.WinForms.Guna2CircleButton MaxBtn;
        private Guna.UI2.WinForms.Guna2CircleButton ExitBtn;
        private Guna.UI2.WinForms.Guna2CircleButton MinBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox usericonPicture;
        private System.Windows.Forms.Panel navBarPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel bgPanel;
        private Guna.UI2.WinForms.Guna2Panel displayPanel;
        private System.Windows.Forms.Timer animateTimer;
        private Guna.UI2.WinForms.Guna2Button playablesButton;
        private Guna.UI2.WinForms.Guna2Button analysisButton;
        private Guna.UI2.WinForms.Guna2Button testButton;
        private Guna.UI2.WinForms.Guna2Button visualizationButton;
        private Guna.UI2.WinForms.Guna2Button moodtrackerButton;
        private Guna.UI2.WinForms.Guna2Button calendarButton;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private Guna.UI2.WinForms.Guna2Panel windowsPanel;
        private System.Windows.Forms.Timer tm;
        private Guna.UI2.WinForms.Guna2Button settingsButton;
        private Guna.UI2.WinForms.Guna2ShadowPanel indicator;
    }
}

