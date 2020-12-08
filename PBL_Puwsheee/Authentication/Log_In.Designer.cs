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
            this.logoLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.passwordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.textLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.signupButton = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.requiredUsername = new System.Windows.Forms.Label();
            this.requiredPassword = new System.Windows.Forms.Label();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.showPasswordIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.passwordTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.passwordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.FocusedState.Parent = this.passwordTextbox;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.passwordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.HoverState.Parent = this.passwordTextbox;
            this.passwordTextbox.Location = new System.Drawing.Point(68, 259);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.PlaceholderText = "";
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.ShadowDecoration.Parent = this.passwordTextbox;
            this.passwordTextbox.Size = new System.Drawing.Size(214, 40);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeyLogIn);
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.logoLabel.Location = new System.Drawing.Point(258, 36);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(123, 44);
            this.logoLabel.TabIndex = 10;
            this.logoLabel.Text = "LOGIN";
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 16;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(66, 347);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(215, 33);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Log In";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.passwordLabel.Location = new System.Drawing.Point(76, 239);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 20);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.usernameLabel.Location = new System.Drawing.Point(76, 142);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(85, 20);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username:";
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
            this.usernameTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.usernameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextbox.FocusedState.Parent = this.usernameTextbox;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.usernameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextbox.HoverState.Parent = this.usernameTextbox;
            this.usernameTextbox.Location = new System.Drawing.Point(68, 166);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PasswordChar = '\0';
            this.usernameTextbox.PlaceholderText = "";
            this.usernameTextbox.SelectedText = "";
            this.usernameTextbox.ShadowDecoration.Parent = this.usernameTextbox;
            this.usernameTextbox.Size = new System.Drawing.Size(213, 40);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL_Puwsheee.Properties.Resources.Puwshee;
            this.pictureBox2.Location = new System.Drawing.Point(359, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // requiredUsername
            // 
            this.requiredUsername.AutoSize = true;
            this.requiredUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.requiredUsername.Location = new System.Drawing.Point(135, 210);
            this.requiredUsername.Name = "requiredUsername";
            this.requiredUsername.Size = new System.Drawing.Size(181, 13);
            this.requiredUsername.TabIndex = 8;
            this.requiredUsername.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredUsername.Visible = false;
            // 
            // requiredPassword
            // 
            this.requiredPassword.AutoSize = true;
            this.requiredPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.requiredPassword.Location = new System.Drawing.Point(135, 307);
            this.requiredPassword.Name = "requiredPassword";
            this.requiredPassword.Size = new System.Drawing.Size(181, 13);
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
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(74, 384);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(153, 17);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Don\'t have an account?";
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
            this.showPasswordIcon.Image = global::PBL_Puwsheee.Properties.Resources.show_password;
            this.showPasswordIcon.ImageOffset = new System.Drawing.Point(1, 0);
            this.showPasswordIcon.ImageSize = new System.Drawing.Size(24, 24);
            this.showPasswordIcon.Location = new System.Drawing.Point(248, 268);
            this.showPasswordIcon.Margin = new System.Windows.Forms.Padding(2);
            this.showPasswordIcon.Name = "showPasswordIcon";
            this.showPasswordIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.showPasswordIcon.ShadowDecoration.Parent = this.showPasswordIcon;
            this.showPasswordIcon.Size = new System.Drawing.Size(25, 25);
            this.showPasswordIcon.TabIndex = 6;
            this.showPasswordIcon.UseTransparentBackground = true;
            this.showPasswordIcon.Click += new System.EventHandler(this.showPasswordIcon_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.linkLabel1.Location = new System.Drawing.Point(217, 384);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupButton_LinkClicked);
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(675, 488);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.showPasswordIcon);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.requiredPassword);
            this.Controls.Add(this.requiredUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log_In";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox passwordTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel logoLabel;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel passwordLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel usernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel textLabel;
        private System.Windows.Forms.LinkLabel signupButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label requiredUsername;
        private System.Windows.Forms.Label requiredPassword;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton showPasswordIcon;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}