namespace PBL_Puwsheee
{
    partial class Sign_Up
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
            this.firstNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstnameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lastNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTexbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmPasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastnameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.emailLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passwordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.confirmpasswordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uploadimageButton = new Guna.UI2.WinForms.Guna2Button();
            this.signupButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.firstNameCondition = new System.Windows.Forms.Label();
            this.lastNameCondition = new System.Windows.Forms.Label();
            this.emailCondition = new System.Windows.Forms.Label();
            this.usernameCondition = new System.Windows.Forms.Label();
            this.requiredFirstName = new System.Windows.Forms.Label();
            this.requiredUsername = new System.Windows.Forms.Label();
            this.requiredLastName = new System.Windows.Forms.Label();
            this.requiredEmail = new System.Windows.Forms.Label();
            this.requiredPassword = new System.Windows.Forms.Label();
            this.requiredConfirmPassword = new System.Windows.Forms.Label();
            this.passAndConfirm = new System.Windows.Forms.Label();
            this.passwordCondition3 = new System.Windows.Forms.Label();
            this.passwordCondition2 = new System.Windows.Forms.Label();
            this.passwordCondition1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.submitCodeButton = new Guna.UI2.WinForms.Guna2Button();
            this.enterCodeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.showPasswordIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            this.showConfirmPasswordButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.BorderColor = System.Drawing.Color.Black;
            this.firstNameTextbox.BorderRadius = 20;
            this.firstNameTextbox.BorderThickness = 0;
            this.firstNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextbox.DefaultText = "";
            this.firstNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextbox.DisabledState.Parent = this.firstNameTextbox;
            this.firstNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.firstNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextbox.FocusedState.Parent = this.firstNameTextbox;
            this.firstNameTextbox.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F);
            this.firstNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.firstNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextbox.HoverState.Parent = this.firstNameTextbox;
            this.firstNameTextbox.Location = new System.Drawing.Point(135, 214);
            this.firstNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.PasswordChar = '\0';
            this.firstNameTextbox.PlaceholderText = "";
            this.firstNameTextbox.SelectedText = "";
            this.firstNameTextbox.ShadowDecoration.Parent = this.firstNameTextbox;
            this.firstNameTextbox.Size = new System.Drawing.Size(265, 39);
            this.firstNameTextbox.TabIndex = 1;
            this.firstNameTextbox.TextChanged += new System.EventHandler(this.firstNameTextbox_TextChanged);
            this.firstNameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeySignUp);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstnameLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.firstnameLabel.Location = new System.Drawing.Point(49, 225);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(64, 17);
            this.firstnameLabel.TabIndex = 12;
            this.firstnameLabel.Text = "First Name:";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.BorderColor = System.Drawing.Color.Black;
            this.lastNameTextbox.BorderRadius = 20;
            this.lastNameTextbox.BorderThickness = 0;
            this.lastNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextbox.DefaultText = "";
            this.lastNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextbox.DisabledState.Parent = this.lastNameTextbox;
            this.lastNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.lastNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextbox.FocusedState.Parent = this.lastNameTextbox;
            this.lastNameTextbox.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F);
            this.lastNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.lastNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextbox.HoverState.Parent = this.lastNameTextbox;
            this.lastNameTextbox.Location = new System.Drawing.Point(590, 214);
            this.lastNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.PasswordChar = '\0';
            this.lastNameTextbox.PlaceholderText = "";
            this.lastNameTextbox.SelectedText = "";
            this.lastNameTextbox.ShadowDecoration.Parent = this.lastNameTextbox;
            this.lastNameTextbox.Size = new System.Drawing.Size(265, 39);
            this.lastNameTextbox.TabIndex = 2;
            this.lastNameTextbox.TextChanged += new System.EventHandler(this.lastNameTextbox_TextChanged);
            this.lastNameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeySignUp);
            // 
            // emailTextbox
            // 
            this.emailTextbox.BorderColor = System.Drawing.Color.Black;
            this.emailTextbox.BorderRadius = 20;
            this.emailTextbox.BorderThickness = 0;
            this.emailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextbox.DefaultText = "";
            this.emailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextbox.DisabledState.Parent = this.emailTextbox;
            this.emailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.emailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextbox.FocusedState.Parent = this.emailTextbox;
            this.emailTextbox.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F);
            this.emailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.emailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextbox.HoverState.Parent = this.emailTextbox;
            this.emailTextbox.Location = new System.Drawing.Point(135, 297);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.PasswordChar = '\0';
            this.emailTextbox.PlaceholderText = "";
            this.emailTextbox.SelectedText = "";
            this.emailTextbox.ShadowDecoration.Parent = this.emailTextbox;
            this.emailTextbox.Size = new System.Drawing.Size(265, 39);
            this.emailTextbox.TabIndex = 3;
            this.emailTextbox.TextChanged += new System.EventHandler(this.emailTextbox_TextChanged);
            this.emailTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeySignUp);
            // 
            // usernameTexbox
            // 
            this.usernameTexbox.BorderColor = System.Drawing.Color.Black;
            this.usernameTexbox.BorderRadius = 20;
            this.usernameTexbox.BorderThickness = 0;
            this.usernameTexbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTexbox.DefaultText = "";
            this.usernameTexbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTexbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTexbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTexbox.DisabledState.Parent = this.usernameTexbox;
            this.usernameTexbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTexbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.usernameTexbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTexbox.FocusedState.Parent = this.usernameTexbox;
            this.usernameTexbox.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F);
            this.usernameTexbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.usernameTexbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTexbox.HoverState.Parent = this.usernameTexbox;
            this.usernameTexbox.Location = new System.Drawing.Point(590, 297);
            this.usernameTexbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTexbox.Name = "usernameTexbox";
            this.usernameTexbox.PasswordChar = '\0';
            this.usernameTexbox.PlaceholderText = "";
            this.usernameTexbox.SelectedText = "";
            this.usernameTexbox.ShadowDecoration.Parent = this.usernameTexbox;
            this.usernameTexbox.Size = new System.Drawing.Size(265, 39);
            this.usernameTexbox.TabIndex = 4;
            this.usernameTexbox.TextChanged += new System.EventHandler(this.usernameTexbox_TextChanged);
            this.usernameTexbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeySignUp);
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
            this.passwordTextbox.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.passwordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.HoverState.Parent = this.passwordTextbox;
            this.passwordTextbox.Location = new System.Drawing.Point(135, 379);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.PlaceholderText = "";
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.ShadowDecoration.Parent = this.passwordTextbox;
            this.passwordTextbox.Size = new System.Drawing.Size(265, 39);
            this.passwordTextbox.TabIndex = 5;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            this.passwordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeySignUp);
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.BorderColor = System.Drawing.Color.Black;
            this.confirmPasswordTextbox.BorderRadius = 20;
            this.confirmPasswordTextbox.BorderThickness = 0;
            this.confirmPasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordTextbox.DefaultText = "";
            this.confirmPasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextbox.DisabledState.Parent = this.confirmPasswordTextbox;
            this.confirmPasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.confirmPasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextbox.FocusedState.Parent = this.confirmPasswordTextbox;
            this.confirmPasswordTextbox.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F);
            this.confirmPasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.confirmPasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextbox.HoverState.Parent = this.confirmPasswordTextbox;
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(590, 378);
            this.confirmPasswordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.PasswordChar = '*';
            this.confirmPasswordTextbox.PlaceholderText = "";
            this.confirmPasswordTextbox.SelectedText = "";
            this.confirmPasswordTextbox.ShadowDecoration.Parent = this.confirmPasswordTextbox;
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(265, 39);
            this.confirmPasswordTextbox.TabIndex = 6;
            this.confirmPasswordTextbox.TextChanged += new System.EventHandler(this.confirmPasswordTextbox_TextChanged);
            this.confirmPasswordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeySignUp);
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastnameLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.lastnameLabel.Location = new System.Drawing.Point(504, 225);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(65, 17);
            this.lastnameLabel.TabIndex = 18;
            this.lastnameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.emailLabel.Location = new System.Drawing.Point(28, 308);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(85, 17);
            this.emailLabel.TabIndex = 19;
            this.emailLabel.Text = "Email Address:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.usernameLabel.Location = new System.Drawing.Point(507, 308);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(62, 17);
            this.usernameLabel.TabIndex = 20;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.passwordLabel.Location = new System.Drawing.Point(51, 391);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(62, 17);
            this.passwordLabel.TabIndex = 21;
            this.passwordLabel.Text = "Password:";
            // 
            // confirmpasswordLabel
            // 
            this.confirmpasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmpasswordLabel.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.confirmpasswordLabel.Location = new System.Drawing.Point(459, 391);
            this.confirmpasswordLabel.Margin = new System.Windows.Forms.Padding(4);
            this.confirmpasswordLabel.Name = "confirmpasswordLabel";
            this.confirmpasswordLabel.Size = new System.Drawing.Size(110, 17);
            this.confirmpasswordLabel.TabIndex = 0;
            this.confirmpasswordLabel.Text = "Confirm Password:";
            // 
            // uploadimageButton
            // 
            this.uploadimageButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.uploadimageButton.BorderRadius = 16;
            this.uploadimageButton.BorderThickness = 2;
            this.uploadimageButton.CheckedState.Parent = this.uploadimageButton;
            this.uploadimageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadimageButton.CustomImages.Parent = this.uploadimageButton;
            this.uploadimageButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.uploadimageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.uploadimageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.uploadimageButton.HoverState.Parent = this.uploadimageButton;
            this.uploadimageButton.Location = new System.Drawing.Point(716, 88);
            this.uploadimageButton.Margin = new System.Windows.Forms.Padding(4);
            this.uploadimageButton.Name = "uploadimageButton";
            this.uploadimageButton.ShadowDecoration.Parent = this.uploadimageButton;
            this.uploadimageButton.Size = new System.Drawing.Size(120, 38);
            this.uploadimageButton.TabIndex = 24;
            this.uploadimageButton.Text = "Upload Image";
            this.uploadimageButton.Click += new System.EventHandler(this.uploadimageButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.BorderRadius = 16;
            this.signupButton.CheckedState.Parent = this.signupButton;
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.CustomImages.Parent = this.signupButton;
            this.signupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.signupButton.Font = new System.Drawing.Font("Typo Round Bold Demo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.signupButton.HoverState.Parent = this.signupButton;
            this.signupButton.Location = new System.Drawing.Point(314, 505);
            this.signupButton.Margin = new System.Windows.Forms.Padding(4);
            this.signupButton.Name = "signupButton";
            this.signupButton.ShadowDecoration.Parent = this.signupButton;
            this.signupButton.Size = new System.Drawing.Size(265, 38);
            this.signupButton.TabIndex = 25;
            this.signupButton.Text = "Sign Up";
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.Back;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userPicture
            // 
            this.userPicture.Image = global::PBL_Puwsheee.Properties.Resources.SamplePhoto;
            this.userPicture.Location = new System.Drawing.Point(569, 47);
            this.userPicture.Margin = new System.Windows.Forms.Padding(4);
            this.userPicture.Name = "userPicture";
            this.userPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userPicture.ShadowDecoration.Parent = this.userPicture;
            this.userPicture.Size = new System.Drawing.Size(139, 123);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 23;
            this.userPicture.TabStop = false;
            // 
            // firstNameCondition
            // 
            this.firstNameCondition.AutoSize = true;
            this.firstNameCondition.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.firstNameCondition.Location = new System.Drawing.Point(187, 256);
            this.firstNameCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameCondition.Name = "firstNameCondition";
            this.firstNameCondition.Size = new System.Drawing.Size(131, 11);
            this.firstNameCondition.TabIndex = 27;
            this.firstNameCondition.Text = "MUST ONLY CONTAIN LETTERS";
            this.firstNameCondition.Visible = false;
            // 
            // lastNameCondition
            // 
            this.lastNameCondition.AutoSize = true;
            this.lastNameCondition.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.lastNameCondition.Location = new System.Drawing.Point(644, 257);
            this.lastNameCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameCondition.Name = "lastNameCondition";
            this.lastNameCondition.Size = new System.Drawing.Size(131, 11);
            this.lastNameCondition.TabIndex = 28;
            this.lastNameCondition.Text = "MUST ONLY CONTAIN LETTERS";
            this.lastNameCondition.Visible = false;
            // 
            // emailCondition
            // 
            this.emailCondition.AutoSize = true;
            this.emailCondition.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.emailCondition.Location = new System.Drawing.Point(223, 342);
            this.emailCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailCondition.Name = "emailCondition";
            this.emailCondition.Size = new System.Drawing.Size(68, 11);
            this.emailCondition.TabIndex = 29;
            this.emailCondition.Text = "EMAIL IS TAKEN";
            this.emailCondition.Visible = false;
            // 
            // usernameCondition
            // 
            this.usernameCondition.AutoSize = true;
            this.usernameCondition.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.usernameCondition.Location = new System.Drawing.Point(669, 341);
            this.usernameCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameCondition.Name = "usernameCondition";
            this.usernameCondition.Size = new System.Drawing.Size(88, 11);
            this.usernameCondition.TabIndex = 30;
            this.usernameCondition.Text = "USERNAME IS TAKEN";
            this.usernameCondition.Visible = false;
            // 
            // requiredFirstName
            // 
            this.requiredFirstName.AutoSize = true;
            this.requiredFirstName.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.requiredFirstName.Location = new System.Drawing.Point(187, 257);
            this.requiredFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredFirstName.Name = "requiredFirstName";
            this.requiredFirstName.Size = new System.Drawing.Size(115, 11);
            this.requiredFirstName.TabIndex = 32;
            this.requiredFirstName.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredFirstName.Visible = false;
            // 
            // requiredUsername
            // 
            this.requiredUsername.AutoSize = true;
            this.requiredUsername.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.requiredUsername.Location = new System.Drawing.Point(655, 341);
            this.requiredUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredUsername.Name = "requiredUsername";
            this.requiredUsername.Size = new System.Drawing.Size(115, 11);
            this.requiredUsername.TabIndex = 33;
            this.requiredUsername.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredUsername.Visible = false;
            // 
            // requiredLastName
            // 
            this.requiredLastName.AutoSize = true;
            this.requiredLastName.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.requiredLastName.Location = new System.Drawing.Point(655, 257);
            this.requiredLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredLastName.Name = "requiredLastName";
            this.requiredLastName.Size = new System.Drawing.Size(115, 11);
            this.requiredLastName.TabIndex = 34;
            this.requiredLastName.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredLastName.Visible = false;
            // 
            // requiredEmail
            // 
            this.requiredEmail.AutoSize = true;
            this.requiredEmail.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.requiredEmail.Location = new System.Drawing.Point(187, 342);
            this.requiredEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredEmail.Name = "requiredEmail";
            this.requiredEmail.Size = new System.Drawing.Size(115, 11);
            this.requiredEmail.TabIndex = 35;
            this.requiredEmail.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredEmail.Visible = false;
            // 
            // requiredPassword
            // 
            this.requiredPassword.AutoSize = true;
            this.requiredPassword.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.requiredPassword.Location = new System.Drawing.Point(187, 421);
            this.requiredPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredPassword.Name = "requiredPassword";
            this.requiredPassword.Size = new System.Drawing.Size(115, 11);
            this.requiredPassword.TabIndex = 36;
            this.requiredPassword.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredPassword.Visible = false;
            // 
            // requiredConfirmPassword
            // 
            this.requiredConfirmPassword.AutoSize = true;
            this.requiredConfirmPassword.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.requiredConfirmPassword.Location = new System.Drawing.Point(663, 421);
            this.requiredConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredConfirmPassword.Name = "requiredConfirmPassword";
            this.requiredConfirmPassword.Size = new System.Drawing.Size(115, 11);
            this.requiredConfirmPassword.TabIndex = 37;
            this.requiredConfirmPassword.Text = "* THIS IS A REQUIRED FIELD";
            this.requiredConfirmPassword.Visible = false;
            // 
            // passAndConfirm
            // 
            this.passAndConfirm.AutoSize = true;
            this.passAndConfirm.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAndConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.passAndConfirm.Location = new System.Drawing.Point(604, 422);
            this.passAndConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passAndConfirm.Name = "passAndConfirm";
            this.passAndConfirm.Size = new System.Drawing.Size(247, 11);
            this.passAndConfirm.TabIndex = 38;
            this.passAndConfirm.Text = "PASSWORD AND CONFIRM PASSWORD DOES NOT MATCH";
            this.passAndConfirm.Visible = false;
            // 
            // passwordCondition3
            // 
            this.passwordCondition3.AutoSize = true;
            this.passwordCondition3.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCondition3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.passwordCondition3.Location = new System.Drawing.Point(143, 478);
            this.passwordCondition3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordCondition3.Name = "passwordCondition3";
            this.passwordCondition3.Size = new System.Drawing.Size(140, 11);
            this.passwordCondition3.TabIndex = 39;
            this.passwordCondition3.Text = "Must have numbers and letters";
            this.passwordCondition3.Visible = false;
            // 
            // passwordCondition2
            // 
            this.passwordCondition2.AutoSize = true;
            this.passwordCondition2.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCondition2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.passwordCondition2.Location = new System.Drawing.Point(143, 461);
            this.passwordCondition2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordCondition2.Name = "passwordCondition2";
            this.passwordCondition2.Size = new System.Drawing.Size(176, 11);
            this.passwordCondition2.TabIndex = 40;
            this.passwordCondition2.Text = "Must contain uppercase and lowercase";
            this.passwordCondition2.Visible = false;
            // 
            // passwordCondition1
            // 
            this.passwordCondition1.AutoSize = true;
            this.passwordCondition1.Font = new System.Drawing.Font("Typo Round Bold Demo", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCondition1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.passwordCondition1.Location = new System.Drawing.Point(143, 447);
            this.passwordCondition1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordCondition1.Name = "passwordCondition1";
            this.passwordCondition1.Size = new System.Drawing.Size(179, 11);
            this.passwordCondition1.TabIndex = 41;
            this.passwordCondition1.Text = "Password must be 8 or more characters";
            this.passwordCondition1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 516);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 14);
            this.label11.TabIndex = 42;
            this.label11.Text = "ENTER VERIFICATION CODE";
            this.label11.Visible = false;
            // 
            // submitCodeButton
            // 
            this.submitCodeButton.BorderRadius = 20;
            this.submitCodeButton.CheckedState.Parent = this.submitCodeButton;
            this.submitCodeButton.CustomImages.Parent = this.submitCodeButton;
            this.submitCodeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.submitCodeButton.Font = new System.Drawing.Font("Typo Round Bold Demo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCodeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.submitCodeButton.HoverState.Parent = this.submitCodeButton;
            this.submitCodeButton.Location = new System.Drawing.Point(305, 507);
            this.submitCodeButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitCodeButton.Name = "submitCodeButton";
            this.submitCodeButton.ShadowDecoration.Parent = this.submitCodeButton;
            this.submitCodeButton.Size = new System.Drawing.Size(95, 38);
            this.submitCodeButton.TabIndex = 43;
            this.submitCodeButton.Text = "Submit Code";
            this.submitCodeButton.Visible = false;
            this.submitCodeButton.Click += new System.EventHandler(this.submitCodeButton_Click);
            // 
            // enterCodeTextBox
            // 
            this.enterCodeTextBox.BorderRadius = 20;
            this.enterCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enterCodeTextBox.DefaultText = "";
            this.enterCodeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.enterCodeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.enterCodeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.enterCodeTextBox.DisabledState.Parent = this.enterCodeTextBox;
            this.enterCodeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.enterCodeTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.enterCodeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enterCodeTextBox.FocusedState.Parent = this.enterCodeTextBox;
            this.enterCodeTextBox.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F);
            this.enterCodeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.enterCodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enterCodeTextBox.HoverState.Parent = this.enterCodeTextBox;
            this.enterCodeTextBox.Location = new System.Drawing.Point(135, 505);
            this.enterCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.enterCodeTextBox.Name = "enterCodeTextBox";
            this.enterCodeTextBox.PasswordChar = '\0';
            this.enterCodeTextBox.PlaceholderText = "Enter Verification Code";
            this.enterCodeTextBox.SelectedText = "";
            this.enterCodeTextBox.ShadowDecoration.Parent = this.enterCodeTextBox;
            this.enterCodeTextBox.Size = new System.Drawing.Size(171, 38);
            this.enterCodeTextBox.TabIndex = 7;
            this.enterCodeTextBox.Visible = false;
            this.enterCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeySignUp);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Robaga Rounded Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(190, 88);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 31);
            this.guna2HtmlLabel1.TabIndex = 46;
            this.guna2HtmlLabel1.Text = "SIGN UP";
            // 
            // showPasswordIcon
            // 
            this.showPasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordIcon.CheckedState.Parent = this.showPasswordIcon;
            this.showPasswordIcon.CustomImages.Parent = this.showPasswordIcon;
            this.showPasswordIcon.FillColor = System.Drawing.Color.Transparent;
            this.showPasswordIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showPasswordIcon.ForeColor = System.Drawing.Color.White;
            this.showPasswordIcon.HoverState.Parent = this.showPasswordIcon;
            this.showPasswordIcon.Image = global::PBL_Puwsheee.Properties.Resources.show_password;
            this.showPasswordIcon.ImageOffset = new System.Drawing.Point(1, 0);
            this.showPasswordIcon.Location = new System.Drawing.Point(365, 385);
            this.showPasswordIcon.Name = "showPasswordIcon";
            this.showPasswordIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.showPasswordIcon.ShadowDecoration.Parent = this.showPasswordIcon;
            this.showPasswordIcon.Size = new System.Drawing.Size(26, 26);
            this.showPasswordIcon.TabIndex = 47;
            this.showPasswordIcon.UseTransparentBackground = true;
            this.showPasswordIcon.Click += new System.EventHandler(this.showPasswordButton_Click);
            // 
            // showConfirmPasswordButton
            // 
            this.showConfirmPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.showConfirmPasswordButton.CheckedState.Parent = this.showConfirmPasswordButton;
            this.showConfirmPasswordButton.CustomImages.Parent = this.showConfirmPasswordButton;
            this.showConfirmPasswordButton.FillColor = System.Drawing.Color.Transparent;
            this.showConfirmPasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showConfirmPasswordButton.ForeColor = System.Drawing.Color.White;
            this.showConfirmPasswordButton.HoverState.Parent = this.showConfirmPasswordButton;
            this.showConfirmPasswordButton.Image = global::PBL_Puwsheee.Properties.Resources.show_password;
            this.showConfirmPasswordButton.ImageOffset = new System.Drawing.Point(1, 0);
            this.showConfirmPasswordButton.Location = new System.Drawing.Point(820, 385);
            this.showConfirmPasswordButton.Name = "showConfirmPasswordButton";
            this.showConfirmPasswordButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.showConfirmPasswordButton.ShadowDecoration.Parent = this.showConfirmPasswordButton;
            this.showConfirmPasswordButton.Size = new System.Drawing.Size(26, 26);
            this.showConfirmPasswordButton.TabIndex = 48;
            this.showConfirmPasswordButton.UseTransparentBackground = true;
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
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.showConfirmPasswordButton);
            this.Controls.Add(this.showPasswordIcon);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.enterCodeTextBox);
            this.Controls.Add(this.submitCodeButton);
            this.Controls.Add(this.passwordCondition1);
            this.Controls.Add(this.passwordCondition2);
            this.Controls.Add(this.passwordCondition3);
            this.Controls.Add(this.passAndConfirm);
            this.Controls.Add(this.requiredConfirmPassword);
            this.Controls.Add(this.requiredPassword);
            this.Controls.Add(this.requiredEmail);
            this.Controls.Add(this.requiredLastName);
            this.Controls.Add(this.requiredUsername);
            this.Controls.Add(this.requiredFirstName);
            this.Controls.Add(this.usernameCondition);
            this.Controls.Add(this.emailCondition);
            this.Controls.Add(this.lastNameCondition);
            this.Controls.Add(this.firstNameCondition);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.uploadimageButton);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.confirmpasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.confirmPasswordTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTexbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Typo Round Bold Demo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sign_Up";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sign_Up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox firstNameTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel firstnameLabel;
        private Guna.UI2.WinForms.Guna2TextBox emailTextbox;
        private Guna.UI2.WinForms.Guna2TextBox usernameTexbox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextbox;
        private Guna.UI2.WinForms.Guna2TextBox confirmPasswordTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel lastnameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel emailLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel usernameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel passwordLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel confirmpasswordLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPicture;
        private Guna.UI2.WinForms.Guna2Button uploadimageButton;
        private Guna.UI2.WinForms.Guna2Button signupButton;
        protected internal Guna.UI2.WinForms.Guna2TextBox lastNameTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label firstNameCondition;
        private System.Windows.Forms.Label lastNameCondition;
        private System.Windows.Forms.Label emailCondition;
        private System.Windows.Forms.Label usernameCondition;
        private System.Windows.Forms.Label requiredFirstName;
        private System.Windows.Forms.Label requiredUsername;
        private System.Windows.Forms.Label requiredLastName;
        private System.Windows.Forms.Label requiredEmail;
        private System.Windows.Forms.Label requiredPassword;
        private System.Windows.Forms.Label requiredConfirmPassword;
        private System.Windows.Forms.Label passAndConfirm;
        private System.Windows.Forms.Label passwordCondition3;
        private System.Windows.Forms.Label passwordCondition2;
        private System.Windows.Forms.Label passwordCondition1;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button submitCodeButton;
        private Guna.UI2.WinForms.Guna2TextBox enterCodeTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton showPasswordIcon;
        private Guna.UI2.WinForms.Guna2CircleButton showConfirmPasswordButton;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
    }
}