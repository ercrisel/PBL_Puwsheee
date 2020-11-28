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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.playablesButton = new Guna.UI2.WinForms.Guna2Button();
            this.analysisButton = new Guna.UI2.WinForms.Guna2Button();
            this.indicatorButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.testButton = new Guna.UI2.WinForms.Guna2Button();
            this.visualizationButton = new Guna.UI2.WinForms.Guna2Button();
            this.moodtrackerButton = new Guna.UI2.WinForms.Guna2Button();
            this.calendarButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bgPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.displayPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.animateTimer = new System.Windows.Forms.Timer(this.components);
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.windowsPanel.SuspendLayout();
            this.navBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usericonPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameLabel.Location = new System.Drawing.Point(21, 11);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 19);
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
            this.MaxBtn.Location = new System.Drawing.Point(1292, 12);
            this.MaxBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MaxBtn.ShadowDecoration.Parent = this.MaxBtn;
            this.MaxBtn.Size = new System.Drawing.Size(20, 18);
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
            this.ExitBtn.Location = new System.Drawing.Point(1320, 12);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(20, 18);
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
            this.MinBtn.Location = new System.Drawing.Point(1264, 12);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MinBtn.ShadowDecoration.Parent = this.MinBtn;
            this.MinBtn.Size = new System.Drawing.Size(20, 18);
            this.MinBtn.TabIndex = 0;
            this.MinBtn.Click += new System.EventHandler(this.minimizePuwshee);
            // 
            // moodTrackerLabel
            // 
            this.moodTrackerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moodTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moodTrackerLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moodTrackerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moodTrackerLabel.Location = new System.Drawing.Point(16, 101);
            this.moodTrackerLabel.Margin = new System.Windows.Forms.Padding(5);
            this.moodTrackerLabel.Name = "moodTrackerLabel";
            this.moodTrackerLabel.Size = new System.Drawing.Size(96, 19);
            this.moodTrackerLabel.TabIndex = 9;
            this.moodTrackerLabel.Text = "Mood Tracker";
            // 
            // calendarLabel
            // 
            this.calendarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarLabel.BackColor = System.Drawing.Color.Transparent;
            this.calendarLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendarLabel.Location = new System.Drawing.Point(16, 170);
            this.calendarLabel.Margin = new System.Windows.Forms.Padding(5);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(64, 19);
            this.calendarLabel.TabIndex = 9;
            this.calendarLabel.Text = "Calendar";
            // 
            // analysisLabel
            // 
            this.analysisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.analysisLabel.BackColor = System.Drawing.Color.Transparent;
            this.analysisLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.analysisLabel.Location = new System.Drawing.Point(16, 241);
            this.analysisLabel.Margin = new System.Windows.Forms.Padding(5);
            this.analysisLabel.Name = "analysisLabel";
            this.analysisLabel.Size = new System.Drawing.Size(57, 19);
            this.analysisLabel.TabIndex = 9;
            this.analysisLabel.Text = "Analysis";
            // 
            // testLabel
            // 
            this.testLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testLabel.BackColor = System.Drawing.Color.Transparent;
            this.testLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.testLabel.Location = new System.Drawing.Point(16, 318);
            this.testLabel.Margin = new System.Windows.Forms.Padding(5);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 19);
            this.testLabel.TabIndex = 9;
            this.testLabel.Text = "Tests";
            // 
            // playablesLabel
            // 
            this.playablesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playablesLabel.BackColor = System.Drawing.Color.Transparent;
            this.playablesLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playablesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playablesLabel.Location = new System.Drawing.Point(16, 390);
            this.playablesLabel.Margin = new System.Windows.Forms.Padding(5);
            this.playablesLabel.Name = "playablesLabel";
            this.playablesLabel.Size = new System.Drawing.Size(69, 19);
            this.playablesLabel.TabIndex = 9;
            this.playablesLabel.Text = "Playables";
            // 
            // visualizationLabel
            // 
            this.visualizationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visualizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.visualizationLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visualizationLabel.Location = new System.Drawing.Point(16, 463);
            this.visualizationLabel.Margin = new System.Windows.Forms.Padding(5);
            this.visualizationLabel.Name = "visualizationLabel";
            this.visualizationLabel.Size = new System.Drawing.Size(87, 19);
            this.visualizationLabel.TabIndex = 9;
            this.visualizationLabel.Text = "Visualization";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsLabel.Location = new System.Drawing.Point(20, 715);
            this.settingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(59, 17);
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
            this.windowsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowsPanel.Location = new System.Drawing.Point(0, 0);
            this.windowsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.windowsPanel.Name = "windowsPanel";
            this.windowsPanel.ShadowDecoration.Parent = this.windowsPanel;
            this.windowsPanel.Size = new System.Drawing.Size(1360, 38);
            this.windowsPanel.TabIndex = 11;
            // 
            // navBarPanel
            // 
            this.navBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.navBarPanel.Controls.Add(this.usericonPicture);
            this.navBarPanel.Controls.Add(this.panel1);
            this.navBarPanel.Controls.Add(this.panel3);
            this.navBarPanel.Controls.Add(this.panel2);
            this.navBarPanel.Controls.Add(this.settingsLabel);
            this.navBarPanel.Controls.Add(this.panel4);
            this.navBarPanel.Location = new System.Drawing.Point(-1, -2);
            this.navBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.navBarPanel.Name = "navBarPanel";
            this.navBarPanel.Size = new System.Drawing.Size(113, 806);
            this.navBarPanel.TabIndex = 12;
            this.navBarPanel.MouseEnter += new System.EventHandler(this.navBarPanelHover);
            this.navBarPanel.MouseLeave += new System.EventHandler(this.navBarPanelHover);
            // 
            // usericonPicture
            // 
            this.usericonPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.usericonPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.usericonPicture.Location = new System.Drawing.Point(19, 49);
            this.usericonPicture.Margin = new System.Windows.Forms.Padding(4);
            this.usericonPicture.Name = "usericonPicture";
            this.usericonPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.usericonPicture.ShadowDecoration.Parent = this.usericonPicture;
            this.usericonPicture.Size = new System.Drawing.Size(73, 68);
            this.usericonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usericonPicture.TabIndex = 5;
            this.usericonPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.calendarLabel);
            this.panel1.Controls.Add(this.playablesLabel);
            this.panel1.Controls.Add(this.visualizationLabel);
            this.panel1.Controls.Add(this.moodTrackerLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.testLabel);
            this.panel1.Controls.Add(this.analysisLabel);
            this.panel1.Location = new System.Drawing.Point(101, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 500);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.playablesButton);
            this.panel3.Controls.Add(this.analysisButton);
            this.panel3.Controls.Add(this.indicatorButton);
            this.panel3.Controls.Add(this.testButton);
            this.panel3.Controls.Add(this.visualizationButton);
            this.panel3.Controls.Add(this.moodtrackerButton);
            this.panel3.Controls.Add(this.calendarButton);
            this.panel3.Location = new System.Drawing.Point(-11, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 540);
            this.panel3.TabIndex = 0;
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
            this.playablesButton.Location = new System.Drawing.Point(51, 417);
            this.playablesButton.Margin = new System.Windows.Forms.Padding(5);
            this.playablesButton.Name = "playablesButton";
            this.playablesButton.ShadowDecoration.Parent = this.playablesButton;
            this.playablesButton.Size = new System.Drawing.Size(29, 27);
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
            this.analysisButton.Location = new System.Drawing.Point(51, 263);
            this.analysisButton.Margin = new System.Windows.Forms.Padding(5);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.ShadowDecoration.Parent = this.analysisButton;
            this.analysisButton.Size = new System.Drawing.Size(29, 27);
            this.analysisButton.TabIndex = 5;
            this.analysisButton.Text = " ";
            this.analysisButton.Click += new System.EventHandler(this.clickAnalysis);
            // 
            // indicatorButton
            // 
            this.indicatorButton.BackColor = System.Drawing.Color.Transparent;
            this.indicatorButton.CheckedState.Parent = this.indicatorButton;
            this.indicatorButton.CustomImages.Parent = this.indicatorButton;
            this.indicatorButton.Enabled = false;
            this.indicatorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.indicatorButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.indicatorButton.ForeColor = System.Drawing.Color.White;
            this.indicatorButton.HoverState.Parent = this.indicatorButton;
            this.indicatorButton.Location = new System.Drawing.Point(63, 161);
            this.indicatorButton.Margin = new System.Windows.Forms.Padding(4);
            this.indicatorButton.Name = "indicatorButton";
            this.indicatorButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.indicatorButton.ShadowDecoration.Parent = this.indicatorButton;
            this.indicatorButton.Size = new System.Drawing.Size(11, 10);
            this.indicatorButton.TabIndex = 0;
            this.indicatorButton.UseTransparentBackground = true;
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
            this.testButton.Location = new System.Drawing.Point(51, 343);
            this.testButton.Margin = new System.Windows.Forms.Padding(5);
            this.testButton.Name = "testButton";
            this.testButton.ShadowDecoration.Parent = this.testButton;
            this.testButton.Size = new System.Drawing.Size(29, 27);
            this.testButton.TabIndex = 6;
            this.testButton.Text = " ";
            this.testButton.Click += new System.EventHandler(this.clickTest);
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
            this.visualizationButton.Location = new System.Drawing.Point(49, 490);
            this.visualizationButton.Margin = new System.Windows.Forms.Padding(5);
            this.visualizationButton.Name = "visualizationButton";
            this.visualizationButton.ShadowDecoration.Parent = this.visualizationButton;
            this.visualizationButton.Size = new System.Drawing.Size(29, 27);
            this.visualizationButton.TabIndex = 9;
            this.visualizationButton.Text = " ";
            this.visualizationButton.Click += new System.EventHandler(this.clickVisualization);
            // 
            // moodtrackerButton
            // 
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
            this.moodtrackerButton.Location = new System.Drawing.Point(51, 124);
            this.moodtrackerButton.Margin = new System.Windows.Forms.Padding(5);
            this.moodtrackerButton.Name = "moodtrackerButton";
            this.moodtrackerButton.ShadowDecoration.Parent = this.moodtrackerButton;
            this.moodtrackerButton.Size = new System.Drawing.Size(29, 27);
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
            this.calendarButton.Location = new System.Drawing.Point(51, 192);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(5);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.ShadowDecoration.Parent = this.calendarButton;
            this.calendarButton.Size = new System.Drawing.Size(29, 27);
            this.calendarButton.TabIndex = 4;
            this.calendarButton.Text = " ";
            this.calendarButton.Click += new System.EventHandler(this.clickCalendar);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(267, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 740);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(4, 698);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 82);
            this.panel4.TabIndex = 0;
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.Transparent;
            this.bgPanel.Controls.Add(this.displayPanel);
            this.bgPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.bgPanel.Location = new System.Drawing.Point(125, 42);
            this.bgPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Radius = 10;
            this.bgPanel.ShadowColor = System.Drawing.Color.Black;
            this.bgPanel.ShadowShift = 1;
            this.bgPanel.Size = new System.Drawing.Size(1223, 694);
            this.bgPanel.TabIndex = 13;
            // 
            // displayPanel
            // 
            this.displayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.displayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.displayPanel.BorderRadius = 20;
            this.displayPanel.Location = new System.Drawing.Point(21, 17);
            this.displayPanel.Margin = new System.Windows.Forms.Padding(4);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.ShadowDecoration.Parent = this.displayPanel;
            this.displayPanel.Size = new System.Drawing.Size(1180, 660);
            this.displayPanel.TabIndex = 0;
            // 
            // animateTimer
            // 
            this.animateTimer.Interval = 10;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1360, 751);
            this.Controls.Add(this.navBarPanel);
            this.Controls.Add(this.windowsPanel);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.windowsPanel.ResumeLayout(false);
            this.navBarPanel.ResumeLayout(false);
            this.navBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usericonPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.bgPanel.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Panel windowsPanel;
        private System.Windows.Forms.Panel navBarPanel;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel bgPanel;
        private Guna.UI2.WinForms.Guna2Panel displayPanel;
        private System.Windows.Forms.Timer animateTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button playablesButton;
        private Guna.UI2.WinForms.Guna2Button analysisButton;
        private Guna.UI2.WinForms.Guna2CircleButton indicatorButton;
        private Guna.UI2.WinForms.Guna2Button testButton;
        private Guna.UI2.WinForms.Guna2Button visualizationButton;
        private Guna.UI2.WinForms.Guna2Button moodtrackerButton;
        private Guna.UI2.WinForms.Guna2Button calendarButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
    }
}

