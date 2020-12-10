namespace PBL_Puwsheee
{
    partial class Log_In
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
            this.passwordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.welcomeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.usernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.textLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.signupButton = new System.Windows.Forms.LinkLabel();
            this.requiredUsername = new System.Windows.Forms.Label();
            this.requiredPassword = new System.Windows.Forms.Label();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.usernamePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.passwordPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showPasswordIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            this.loginPic = new System.Windows.Forms.PictureBox();
            this.textBubble = new Guna.UI2.WinForms.Guna2PictureBox();
            this.successLabel1 = new System.Windows.Forms.Label();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.messgaeBubbleYEY = new Guna.UI2.WinForms.Guna2PictureBox();
            this.messageBubbleOHNO = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBubble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messgaeBubbleYEY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBubbleOHNO)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BorderColor = System.Drawing.Color.Black;
            this.passwordTextbox.BorderRadius = 20;
            this.passwordTextbox.BorderThickness = 0;
            this.passwordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextbox.DefaultText = "";
            this.passwordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextbox.DisabledState.Parent = this.passwordTextbox;
            this.passwordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.passwordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.FocusedState.Parent = this.passwordTextbox;
            this.passwordTextbox.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.passwordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.HoverState.Parent = this.passwordTextbox;
            this.passwordTextbox.Location = new System.Drawing.Point(92, 167);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.passwordTextbox.PlaceholderText = "Password";
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.ShadowDecoration.Parent = this.passwordTextbox;
            this.passwordTextbox.Size = new System.Drawing.Size(379, 40);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged_1);
            this.passwordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeyLogIn);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Robaga Rounded Black", 25F);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.welcomeLabel.Location = new System.Drawing.Point(308, 10);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(294, 42);
            this.welcomeLabel.TabIndex = 10;
            this.welcomeLabel.Text = "WELCOME BACK~";
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 16;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(165, 278);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(196, 33);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Log In";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BorderColor = System.Drawing.Color.Black;
            this.usernameTextbox.BorderRadius = 20;
            this.usernameTextbox.BorderThickness = 0;
            this.usernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextbox.DefaultText = "";
            this.usernameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextbox.DisabledState.Parent = this.usernameTextbox;
            this.usernameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.usernameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextbox.FocusedState.Parent = this.usernameTextbox;
            this.usernameTextbox.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.usernameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextbox.HoverState.Parent = this.usernameTextbox;
            this.usernameTextbox.Location = new System.Drawing.Point(92, 65);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PasswordChar = '\0';
            this.usernameTextbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.usernameTextbox.PlaceholderText = "Username";
            this.usernameTextbox.SelectedText = "";
            this.usernameTextbox.ShadowDecoration.Parent = this.usernameTextbox;
            this.usernameTextbox.Size = new System.Drawing.Size(381, 40);
            this.usernameTextbox.TabIndex = 0;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            this.usernameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeyLogIn);
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.textLabel.Location = new System.Drawing.Point(111, 521);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(118, 15);
            this.textLabel.TabIndex = 15;
            this.textLabel.Text = "Don\'t have an account?";
            // 
            // signupButton
            // 
            this.signupButton.AutoSize = true;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.signupButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.signupButton.Location = new System.Drawing.Point(240, 523);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(45, 13);
            this.signupButton.TabIndex = 18;
            this.signupButton.TabStop = true;
            this.signupButton.Text = "Sign Up";
            this.signupButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupButton_LinkClicked);
            // 
            // requiredUsername
            // 
            this.requiredUsername.AutoSize = true;
            this.requiredUsername.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F);
            this.requiredUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.requiredUsername.Location = new System.Drawing.Point(326, 109);
            this.requiredUsername.Name = "requiredUsername";
            this.requiredUsername.Size = new System.Drawing.Size(138, 14);
            this.requiredUsername.TabIndex = 8;
            this.requiredUsername.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredUsername.Visible = false;
            // 
            // requiredPassword
            // 
            this.requiredPassword.AutoSize = true;
            this.requiredPassword.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F);
            this.requiredPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.requiredPassword.Location = new System.Drawing.Point(326, 211);
            this.requiredPassword.Name = "requiredPassword";
            this.requiredPassword.Size = new System.Drawing.Size(138, 14);
            this.requiredPassword.TabIndex = 5;
            this.requiredPassword.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredPassword.Visible = false;
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 50;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(175, 315);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(123, 16);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Don\'t have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Typo Round Bold Demo", 8.25F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.linkLabel1.Location = new System.Drawing.Point(298, 317);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 14);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupButton_LinkClicked);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.usernamePanel);
            this.guna2ShadowPanel1.Controls.Add(this.passwordPanel);
            this.guna2ShadowPanel1.Controls.Add(this.usernameTextbox);
            this.guna2ShadowPanel1.Controls.Add(this.showPasswordIcon);
            this.guna2ShadowPanel1.Controls.Add(this.loginButton);
            this.guna2ShadowPanel1.Controls.Add(this.requiredPassword);
            this.guna2ShadowPanel1.Controls.Add(this.passwordTextbox);
            this.guna2ShadowPanel1.Controls.Add(this.requiredUsername);
            this.guna2ShadowPanel1.Controls.Add(this.linkLabel1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(87, 64);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(612, 450);
            this.guna2ShadowPanel1.TabIndex = 19;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // usernamePanel
            // 
            this.usernamePanel.BorderRadius = 3;
            this.usernamePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.usernamePanel.Location = new System.Drawing.Point(96, 99);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.ShadowDecoration.Parent = this.usernamePanel;
            this.usernamePanel.Size = new System.Drawing.Size(368, 5);
            this.usernamePanel.TabIndex = 10;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BorderRadius = 3;
            this.passwordPanel.Controls.Add(this.pictureBox1);
            this.passwordPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.passwordPanel.Location = new System.Drawing.Point(96, 199);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.ShadowDecoration.Parent = this.passwordPanel;
            this.passwordPanel.Size = new System.Drawing.Size(368, 5);
            this.passwordPanel.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, -176);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // showPasswordIcon
            // 
            this.showPasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordIcon.CheckedState.Parent = this.showPasswordIcon;
            this.showPasswordIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordIcon.CustomImages.Parent = this.showPasswordIcon;
            this.showPasswordIcon.FillColor = System.Drawing.Color.Transparent;
            this.showPasswordIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showPasswordIcon.ForeColor = System.Drawing.Color.White;
            this.showPasswordIcon.HoverState.Parent = this.showPasswordIcon;
            this.showPasswordIcon.ImageOffset = new System.Drawing.Point(1, 0);
            this.showPasswordIcon.ImageSize = new System.Drawing.Size(24, 24);
            this.showPasswordIcon.Location = new System.Drawing.Point(429, 172);
            this.showPasswordIcon.Margin = new System.Windows.Forms.Padding(2);
            this.showPasswordIcon.Name = "showPasswordIcon";
            this.showPasswordIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.showPasswordIcon.ShadowDecoration.Parent = this.showPasswordIcon;
            this.showPasswordIcon.Size = new System.Drawing.Size(35, 22);
            this.showPasswordIcon.TabIndex = 6;
            this.showPasswordIcon.UseTransparentBackground = true;
            this.showPasswordIcon.Click += new System.EventHandler(this.showPasswordIcon_Click);
            // 
            // loginPic
            // 
            this.loginPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPic.Location = new System.Drawing.Point(-33, 72);
            this.loginPic.Margin = new System.Windows.Forms.Padding(2);
            this.loginPic.Name = "loginPic";
            this.loginPic.Size = new System.Drawing.Size(121, 110);
            this.loginPic.TabIndex = 10;
            this.loginPic.TabStop = false;
            // 
            // textBubble
            // 
            this.textBubble.BackColor = System.Drawing.Color.Transparent;
            this.textBubble.Location = new System.Drawing.Point(-43, -39);
            this.textBubble.Margin = new System.Windows.Forms.Padding(2);
            this.textBubble.Name = "textBubble";
            this.textBubble.ShadowDecoration.Parent = this.textBubble;
            this.textBubble.Size = new System.Drawing.Size(454, 197);
            this.textBubble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.textBubble.TabIndex = 11;
            this.textBubble.TabStop = false;
            this.textBubble.UseTransparentBackground = true;
            this.textBubble.Visible = false;
            // 
            // successLabel1
            // 
            this.successLabel1.AutoSize = true;
            this.successLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.successLabel1.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.successLabel1.Location = new System.Drawing.Point(96, 45);
            this.successLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.successLabel1.Name = "successLabel1";
            this.successLabel1.Size = new System.Drawing.Size(182, 15);
            this.successLabel1.TabIndex = 11;
            this.successLabel1.Text = "Yey, your login was a success!";
            this.successLabel1.Visible = false;
            // 
            // errorLabel1
            // 
            this.errorLabel1.Location = new System.Drawing.Point(0, 0);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(100, 23);
            this.errorLabel1.TabIndex = 0;
            // 
            // errorLabel2
            // 
            this.errorLabel2.Location = new System.Drawing.Point(0, 0);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(100, 23);
            this.errorLabel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.label1.Font = new System.Drawing.Font("Typo Round Bold Demo", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(218, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "with that email and username";
            this.label1.Visible = false;
            // 
            // messgaeBubbleYEY
            // 
            this.messgaeBubbleYEY.BackColor = System.Drawing.Color.Transparent;
            this.messgaeBubbleYEY.Location = new System.Drawing.Point(89, -2);
            this.messgaeBubbleYEY.Name = "messgaeBubbleYEY";
            this.messgaeBubbleYEY.ShadowDecoration.Parent = this.messgaeBubbleYEY;
            this.messgaeBubbleYEY.Size = new System.Drawing.Size(149, 149);
            this.messgaeBubbleYEY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.messgaeBubbleYEY.TabIndex = 11;
            this.messgaeBubbleYEY.TabStop = false;
            this.messgaeBubbleYEY.UseTransparentBackground = true;
            this.messgaeBubbleYEY.Visible = false;
            // 
            // messageBubbleOHNO
            // 
            this.messageBubbleOHNO.BackColor = System.Drawing.Color.Transparent;
            this.messageBubbleOHNO.Location = new System.Drawing.Point(89, 1);
            this.messageBubbleOHNO.Name = "messageBubbleOHNO";
            this.messageBubbleOHNO.ShadowDecoration.Parent = this.messageBubbleOHNO;
            this.messageBubbleOHNO.Size = new System.Drawing.Size(149, 149);
            this.messageBubbleOHNO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.messageBubbleOHNO.TabIndex = 11;
            this.messageBubbleOHNO.TabStop = false;
            this.messageBubbleOHNO.UseTransparentBackground = true;
            this.messageBubbleOHNO.Visible = false;
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(614, 454);
            this.Controls.Add(this.messageBubbleOHNO);
            this.Controls.Add(this.messgaeBubbleYEY);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.loginPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log_In";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_In";
            this.Load += new System.EventHandler(this.Log_In_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBubble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messgaeBubbleYEY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBubbleOHNO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox passwordTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel welcomeLabel;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel textLabel;
        private System.Windows.Forms.LinkLabel signupButton;
        private System.Windows.Forms.Label requiredUsername;
        private System.Windows.Forms.Label requiredPassword;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton showPasswordIcon;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.PictureBox loginPic;
        private Guna.UI2.WinForms.Guna2Panel usernamePanel;
        private Guna.UI2.WinForms.Guna2Panel passwordPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox textBubble;
        private System.Windows.Forms.Label successLabel1;
        private System.Windows.Forms.Label errorLabel1;
        private System.Windows.Forms.Label errorLabel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox messgaeBubbleYEY;
        private Guna.UI2.WinForms.Guna2PictureBox messageBubbleOHNO;
    }
}