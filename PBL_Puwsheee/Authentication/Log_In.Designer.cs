﻿namespace PBL_Puwsheee
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
            this.passwordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.logoLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.passwordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.textLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.signupButton = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.requiredUsername = new System.Windows.Forms.Label();
            this.requiredPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.passwordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.HoverState.Parent = this.passwordTextbox;
            this.passwordTextbox.Location = new System.Drawing.Point(156, 389);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '\0';
            this.passwordTextbox.PlaceholderText = "";
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.ShadowDecoration.Parent = this.passwordTextbox;
            this.passwordTextbox.Size = new System.Drawing.Size(216, 42);
            this.passwordTextbox.TabIndex = 10;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.logoLabel.Location = new System.Drawing.Point(187, 252);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(82, 26);
            this.logoLabel.TabIndex = 8;
            this.logoLabel.Text = "Puwshee";
            this.logoLabel.Click += new System.EventHandler(this.logoLabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 16;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(222, 450);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(83, 33);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Log In";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.passwordLabel.Location = new System.Drawing.Point(88, 403);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(52, 15);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.usernameLabel.Location = new System.Drawing.Point(83, 330);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(54, 15);
            this.usernameLabel.TabIndex = 11;
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
            this.usernameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.usernameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextbox.HoverState.Parent = this.usernameTextbox;
            this.usernameTextbox.Location = new System.Drawing.Point(157, 317);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PasswordChar = '\0';
            this.usernameTextbox.PlaceholderText = "";
            this.usernameTextbox.SelectedText = "";
            this.usernameTextbox.ShadowDecoration.Parent = this.usernameTextbox;
            this.usernameTextbox.Size = new System.Drawing.Size(215, 42);
            this.usernameTextbox.TabIndex = 14;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.textLabel.Location = new System.Drawing.Point(126, 521);
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
            this.signupButton.Location = new System.Drawing.Point(255, 523);
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
            this.pictureBox2.Location = new System.Drawing.Point(136, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL_Puwsheee.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // requiredUsername
            // 
            this.requiredUsername.AutoSize = true;
            this.requiredUsername.ForeColor = System.Drawing.Color.Red;
            this.requiredUsername.Location = new System.Drawing.Point(8, 300);
            this.requiredUsername.Name = "requiredUsername";
            this.requiredUsername.Size = new System.Drawing.Size(155, 13);
            this.requiredUsername.TabIndex = 37;
            this.requiredUsername.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredUsername.Visible = false;
            // 
            // requiredPassword
            // 
            this.requiredPassword.AutoSize = true;
            this.requiredPassword.ForeColor = System.Drawing.Color.Red;
            this.requiredPassword.Location = new System.Drawing.Point(8, 372);
            this.requiredPassword.Name = "requiredPassword";
            this.requiredPassword.Size = new System.Drawing.Size(155, 13);
            this.requiredPassword.TabIndex = 38;
            this.requiredPassword.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredPassword.Visible = false;
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(450, 619);
            this.Controls.Add(this.requiredPassword);
            this.Controls.Add(this.requiredUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log_In";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_In";
            this.Load += new System.EventHandler(this.Log_In_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel signupButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label requiredUsername;
        private System.Windows.Forms.Label requiredPassword;
    }
}