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
            this.moodTrackerLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.calendarLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.analysisLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.testLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.playablesLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.visualizationLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.windowsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.navBarPanel = new System.Windows.Forms.Panel();
            this.usericonPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.navBarIconsPanel = new System.Windows.Forms.Panel();
            this.playablesButton = new Guna.UI2.WinForms.Guna2Button();
            this.analysisButton = new Guna.UI2.WinForms.Guna2Button();
            this.indicatorButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.testButton = new Guna.UI2.WinForms.Guna2Button();
            this.visualizationButton = new Guna.UI2.WinForms.Guna2Button();
            this.moodtrackerButton = new Guna.UI2.WinForms.Guna2Button();
            this.calendarButton = new Guna.UI2.WinForms.Guna2Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.bgPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.displayPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.animateTimer = new System.Windows.Forms.Timer(this.components);
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar1 = new Pabo.Calendar.MonthCalendar();
            this.windowsPanel.SuspendLayout();
            this.navBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usericonPicture)).BeginInit();
            this.navBarIconsPanel.SuspendLayout();
            this.bgPanel.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameLabel.Location = new System.Drawing.Point(88, 64);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(59, 15);
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
            this.MaxBtn.Location = new System.Drawing.Point(969, 10);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MaxBtn.ShadowDecoration.Parent = this.MaxBtn;
            this.MaxBtn.Size = new System.Drawing.Size(15, 15);
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
            this.ExitBtn.Location = new System.Drawing.Point(990, 10);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(15, 15);
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
            this.MinBtn.Location = new System.Drawing.Point(948, 10);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MinBtn.ShadowDecoration.Parent = this.MinBtn;
            this.MinBtn.Size = new System.Drawing.Size(15, 15);
            this.MinBtn.TabIndex = 0;
            this.MinBtn.Click += new System.EventHandler(this.minimizePuwshee);
            // 
            // moodTrackerLabel
            // 
            this.moodTrackerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moodTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moodTrackerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moodTrackerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moodTrackerLabel.Location = new System.Drawing.Point(88, 137);
            this.moodTrackerLabel.Margin = new System.Windows.Forms.Padding(4);
            this.moodTrackerLabel.Name = "moodTrackerLabel";
            this.moodTrackerLabel.Size = new System.Drawing.Size(82, 15);
            this.moodTrackerLabel.TabIndex = 9;
            this.moodTrackerLabel.Text = "Mood Tracker";
            // 
            // calendarLabel
            // 
            this.calendarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarLabel.BackColor = System.Drawing.Color.Transparent;
            this.calendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendarLabel.Location = new System.Drawing.Point(88, 193);
            this.calendarLabel.Margin = new System.Windows.Forms.Padding(4);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(53, 15);
            this.calendarLabel.TabIndex = 9;
            this.calendarLabel.Text = "Calendar";
            // 
            // analysisLabel
            // 
            this.analysisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.analysisLabel.BackColor = System.Drawing.Color.Transparent;
            this.analysisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.analysisLabel.Location = new System.Drawing.Point(88, 251);
            this.analysisLabel.Margin = new System.Windows.Forms.Padding(4);
            this.analysisLabel.Name = "analysisLabel";
            this.analysisLabel.Size = new System.Drawing.Size(49, 15);
            this.analysisLabel.TabIndex = 9;
            this.analysisLabel.Text = "Analysis";
            // 
            // testLabel
            // 
            this.testLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testLabel.BackColor = System.Drawing.Color.Transparent;
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.testLabel.Location = new System.Drawing.Point(88, 313);
            this.testLabel.Margin = new System.Windows.Forms.Padding(4);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(34, 15);
            this.testLabel.TabIndex = 9;
            this.testLabel.Text = "Tests";
            // 
            // playablesLabel
            // 
            this.playablesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playablesLabel.BackColor = System.Drawing.Color.Transparent;
            this.playablesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playablesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playablesLabel.Location = new System.Drawing.Point(88, 372);
            this.playablesLabel.Margin = new System.Windows.Forms.Padding(4);
            this.playablesLabel.Name = "playablesLabel";
            this.playablesLabel.Size = new System.Drawing.Size(57, 15);
            this.playablesLabel.TabIndex = 9;
            this.playablesLabel.Text = "Playables";
            // 
            // visualizationLabel
            // 
            this.visualizationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visualizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.visualizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visualizationLabel.Location = new System.Drawing.Point(88, 431);
            this.visualizationLabel.Margin = new System.Windows.Forms.Padding(4);
            this.visualizationLabel.Name = "visualizationLabel";
            this.visualizationLabel.Size = new System.Drawing.Size(74, 15);
            this.visualizationLabel.TabIndex = 9;
            this.visualizationLabel.Text = "Visualization";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsLabel.Location = new System.Drawing.Point(15, 581);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(53, 13);
            this.settingsLabel.TabIndex = 10;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.Click += new System.EventHandler(this.clickOptions);
            // 
            // windowsPanel
            // 
            this.windowsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.windowsPanel.Controls.Add(this.MinBtn);
            this.windowsPanel.Controls.Add(this.ExitBtn);
            this.windowsPanel.Controls.Add(this.MaxBtn);
            this.windowsPanel.Location = new System.Drawing.Point(0, 0);
            this.windowsPanel.Name = "windowsPanel";
            this.windowsPanel.ShadowDecoration.Parent = this.windowsPanel;
            this.windowsPanel.Size = new System.Drawing.Size(1020, 31);
            this.windowsPanel.TabIndex = 11;
            // 
            // navBarPanel
            // 
            this.navBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.navBarPanel.Controls.Add(this.calendarLabel);
            this.navBarPanel.Controls.Add(this.usericonPicture);
            this.navBarPanel.Controls.Add(this.visualizationLabel);
            this.navBarPanel.Controls.Add(this.navBarIconsPanel);
            this.navBarPanel.Controls.Add(this.playablesLabel);
            this.navBarPanel.Controls.Add(this.settingsLabel);
            this.navBarPanel.Controls.Add(this.analysisLabel);
            this.navBarPanel.Controls.Add(this.settingsPanel);
            this.navBarPanel.Controls.Add(this.testLabel);
            this.navBarPanel.Controls.Add(this.usernameLabel);
            this.navBarPanel.Controls.Add(this.moodTrackerLabel);
            this.navBarPanel.Location = new System.Drawing.Point(-1, -2);
            this.navBarPanel.Name = "navBarPanel";
            this.navBarPanel.Size = new System.Drawing.Size(82, 655);
            this.navBarPanel.TabIndex = 12;
            this.navBarPanel.MouseEnter += new System.EventHandler(this.navBarPanelHover);
            this.navBarPanel.MouseLeave += new System.EventHandler(this.navBarPanelHover);
            // 
            // usericonPicture
            // 
            this.usericonPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.usericonPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.usericonPicture.Location = new System.Drawing.Point(18, 49);
            this.usericonPicture.Margin = new System.Windows.Forms.Padding(2);
            this.usericonPicture.Name = "usericonPicture";
            this.usericonPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.usericonPicture.ShadowDecoration.Parent = this.usericonPicture;
            this.usericonPicture.Size = new System.Drawing.Size(50, 50);
            this.usericonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usericonPicture.TabIndex = 5;
            this.usericonPicture.TabStop = false;
            // 
            // navBarIconsPanel
            // 
            this.navBarIconsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.navBarIconsPanel.Controls.Add(this.playablesButton);
            this.navBarIconsPanel.Controls.Add(this.analysisButton);
            this.navBarIconsPanel.Controls.Add(this.indicatorButton);
            this.navBarIconsPanel.Controls.Add(this.testButton);
            this.navBarIconsPanel.Controls.Add(this.visualizationButton);
            this.navBarIconsPanel.Controls.Add(this.moodtrackerButton);
            this.navBarIconsPanel.Controls.Add(this.calendarButton);
            this.navBarIconsPanel.Location = new System.Drawing.Point(-8, 104);
            this.navBarIconsPanel.Name = "navBarIconsPanel";
            this.navBarIconsPanel.Size = new System.Drawing.Size(72, 363);
            this.navBarIconsPanel.TabIndex = 0;
            // 
            // playablesButton
            // 
            this.playablesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.playablesButton.Location = new System.Drawing.Point(38, 263);
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
            this.analysisButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.analysisButton.Location = new System.Drawing.Point(38, 138);
            this.analysisButton.Margin = new System.Windows.Forms.Padding(4);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.ShadowDecoration.Parent = this.analysisButton;
            this.analysisButton.Size = new System.Drawing.Size(22, 22);
            this.analysisButton.TabIndex = 5;
            this.analysisButton.Text = " ";
            this.analysisButton.Click += new System.EventHandler(this.clickAnalysis);
            // 
            // indicatorButton
            // 
            this.indicatorButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.indicatorButton.BackColor = System.Drawing.Color.Transparent;
            this.indicatorButton.CheckedState.Parent = this.indicatorButton;
            this.indicatorButton.CustomImages.Parent = this.indicatorButton;
            this.indicatorButton.Enabled = false;
            this.indicatorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.indicatorButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.indicatorButton.ForeColor = System.Drawing.Color.White;
            this.indicatorButton.HoverState.Parent = this.indicatorButton;
            this.indicatorButton.Location = new System.Drawing.Point(46, 346);
            this.indicatorButton.Margin = new System.Windows.Forms.Padding(2);
            this.indicatorButton.Name = "indicatorButton";
            this.indicatorButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.indicatorButton.ShadowDecoration.Parent = this.indicatorButton;
            this.indicatorButton.Size = new System.Drawing.Size(6, 6);
            this.indicatorButton.TabIndex = 0;
            this.indicatorButton.UseTransparentBackground = true;
            // 
            // testButton
            // 
            this.testButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.testButton.Location = new System.Drawing.Point(38, 203);
            this.testButton.Margin = new System.Windows.Forms.Padding(4);
            this.testButton.Name = "testButton";
            this.testButton.ShadowDecoration.Parent = this.testButton;
            this.testButton.Size = new System.Drawing.Size(22, 22);
            this.testButton.TabIndex = 6;
            this.testButton.Text = " ";
            this.testButton.Click += new System.EventHandler(this.clickTest);
            // 
            // visualizationButton
            // 
            this.visualizationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.visualizationButton.Location = new System.Drawing.Point(37, 322);
            this.visualizationButton.Margin = new System.Windows.Forms.Padding(4);
            this.visualizationButton.Name = "visualizationButton";
            this.visualizationButton.ShadowDecoration.Parent = this.visualizationButton;
            this.visualizationButton.Size = new System.Drawing.Size(22, 22);
            this.visualizationButton.TabIndex = 9;
            this.visualizationButton.Text = " ";
            this.visualizationButton.Click += new System.EventHandler(this.clickVisualization);
            // 
            // moodtrackerButton
            // 
            this.moodtrackerButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.moodtrackerButton.Location = new System.Drawing.Point(38, 24);
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
            this.calendarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.calendarButton.Location = new System.Drawing.Point(38, 80);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(4);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.ShadowDecoration.Parent = this.calendarButton;
            this.calendarButton.Size = new System.Drawing.Size(22, 22);
            this.calendarButton.TabIndex = 4;
            this.calendarButton.Text = " ";
            this.calendarButton.Click += new System.EventHandler(this.clickCalendar);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(-24, 571);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(222, 54);
            this.settingsPanel.TabIndex = 0;
            // 
            // bgPanel
            // 
            this.bgPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bgPanel.BackColor = System.Drawing.Color.Transparent;
            this.bgPanel.Controls.Add(this.displayPanel);
            this.bgPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.bgPanel.Location = new System.Drawing.Point(89, 40);
            this.bgPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Radius = 10;
            this.bgPanel.ShadowColor = System.Drawing.Color.Black;
            this.bgPanel.ShadowShift = 1;
            this.bgPanel.Size = new System.Drawing.Size(916, 557);
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
            this.displayPanel.Controls.Add(this.monthCalendar1);
            this.displayPanel.Location = new System.Drawing.Point(15, 11);
            this.displayPanel.Margin = new System.Windows.Forms.Padding(2);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.ShadowDecoration.Parent = this.displayPanel;
            this.displayPanel.Size = new System.Drawing.Size(883, 531);
            this.displayPanel.TabIndex = 0;
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
            // monthCalendar1
            // 
            this.monthCalendar1.ActiveMonth.Month = 12;
            this.monthCalendar1.ActiveMonth.Year = 2020;
            this.monthCalendar1.Culture = new System.Globalization.CultureInfo("en-PH");
            this.monthCalendar1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar1.ImageList = null;
            this.monthCalendar1.Location = new System.Drawing.Point(739, 183);
            this.monthCalendar1.MaxDate = new System.DateTime(2030, 12, 8, 0, 21, 51, 459);
            this.monthCalendar1.MinDate = new System.DateTime(2010, 12, 8, 0, 21, 51, 459);
            this.monthCalendar1.Month.BackgroundImage = null;
            this.monthCalendar1.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(176, 184);
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.navBarPanel);
            this.Controls.Add(this.windowsPanel);
            this.Controls.Add(this.bgPanel);
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
            this.navBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usericonPicture)).EndInit();
            this.navBarIconsPanel.ResumeLayout(false);
            this.bgPanel.ResumeLayout(false);
            this.displayPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel usernameLabel;
        private Guna.UI2.WinForms.Guna2CircleButton MaxBtn;
        private Guna.UI2.WinForms.Guna2CircleButton ExitBtn;
        private Guna.UI2.WinForms.Guna2CircleButton MinBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel moodTrackerLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel calendarLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel analysisLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel testLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel playablesLabel;
        private System.Windows.Forms.Label settingsLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel visualizationLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox usericonPicture;
        private System.Windows.Forms.Panel navBarPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel bgPanel;
        private Guna.UI2.WinForms.Guna2Panel displayPanel;
        private System.Windows.Forms.Timer animateTimer;
        private Guna.UI2.WinForms.Guna2Button playablesButton;
        private Guna.UI2.WinForms.Guna2Button analysisButton;
        private Guna.UI2.WinForms.Guna2CircleButton indicatorButton;
        private Guna.UI2.WinForms.Guna2Button testButton;
        private Guna.UI2.WinForms.Guna2Button visualizationButton;
        private Guna.UI2.WinForms.Guna2Button moodtrackerButton;
        private Guna.UI2.WinForms.Guna2Button calendarButton;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private Guna.UI2.WinForms.Guna2Panel windowsPanel;
        private System.Windows.Forms.Panel navBarIconsPanel;
        private System.Windows.Forms.Timer tm;
        private Pabo.Calendar.MonthCalendar monthCalendar1;
    }
}

