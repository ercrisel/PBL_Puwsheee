namespace PBL_Puwsheee
{
    partial class PositiveAffirmations
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.quotations = new Guna.UI2.WinForms.Guna2TextBox();
            this.PositiveAffirmationGIF = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PositiveAffirmationGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.CloseForm);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Typo Round Bold Demo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.MaximumSize = new System.Drawing.Size(630, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello, USERNAME :)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 4;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOutTick);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 3;
            this.fadeIn.Tick += new System.EventHandler(this.fadeInTick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Robaga Rounded Black", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.MaximumSize = new System.Drawing.Size(600, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "always remember that...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotations
            // 
            this.quotations.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.quotations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.quotations.CausesValidation = false;
            this.quotations.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.quotations.DefaultText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua. ";
            this.quotations.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.quotations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.quotations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.quotations.DisabledState.Parent = this.quotations;
            this.quotations.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.quotations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.quotations.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.quotations.FocusedState.Parent = this.quotations;
            this.quotations.Font = new System.Drawing.Font("Robaga Rounded Black", 17F);
            this.quotations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.quotations.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quotations.HoverState.Parent = this.quotations;
            this.quotations.Location = new System.Drawing.Point(95, 141);
            this.quotations.Multiline = true;
            this.quotations.Name = "quotations";
            this.quotations.PasswordChar = '\0';
            this.quotations.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.quotations.PlaceholderText = "";
            this.quotations.ReadOnly = true;
            this.quotations.SelectedText = "";
            this.quotations.ShadowDecoration.Parent = this.quotations;
            this.quotations.Size = new System.Drawing.Size(406, 171);
            this.quotations.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.quotations.TabIndex = 2;
            this.quotations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PositiveAffirmationGIF
            // 
            this.PositiveAffirmationGIF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.PositiveAffirmationGIF.Image = global::PBL_Puwsheee.Properties.Resources.positiveAffirmationsGIF;
            this.PositiveAffirmationGIF.Location = new System.Drawing.Point(178, 291);
            this.PositiveAffirmationGIF.Name = "PositiveAffirmationGIF";
            this.PositiveAffirmationGIF.ShadowDecoration.Parent = this.PositiveAffirmationGIF;
            this.PositiveAffirmationGIF.Size = new System.Drawing.Size(237, 151);
            this.PositiveAffirmationGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PositiveAffirmationGIF.TabIndex = 3;
            this.PositiveAffirmationGIF.TabStop = false;
            // 
            // PositiveAffirmations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(614, 454);
            this.Controls.Add(this.quotations);
            this.Controls.Add(this.PositiveAffirmationGIF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PositiveAffirmations";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PositiveAffirmations";
            this.Load += new System.EventHandler(this.PositiveAffirmations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PositiveAffirmationGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox quotations;
        private Guna.UI2.WinForms.Guna2PictureBox PositiveAffirmationGIF;
    }
}