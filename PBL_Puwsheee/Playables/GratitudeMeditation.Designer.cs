
namespace PBL_Puwsheee.Playables
{
    partial class GratitudeMeditation
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.playButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pauseButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1021, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 50;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 50;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.CheckedState.Parent = this.playButton;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.CustomImages.Parent = this.playButton;
            this.playButton.FillColor = System.Drawing.Color.Transparent;
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.HoverState.Parent = this.playButton;
            this.playButton.ImageOffset = new System.Drawing.Point(1, 0);
            this.playButton.ImageSize = new System.Drawing.Size(95, 95);
            this.playButton.Location = new System.Drawing.Point(456, 234);
            this.playButton.Name = "playButton";
            this.playButton.PressedColor = System.Drawing.Color.DarkGray;
            this.playButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.playButton.ShadowDecoration.Parent = this.playButton;
            this.playButton.Size = new System.Drawing.Size(96, 95);
            this.playButton.TabIndex = 45;
            this.playButton.UseTransparentBackground = true;
            this.playButton.Click += new System.EventHandler(this.play_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.Transparent;
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.CheckedState.Parent = this.pauseButton;
            this.pauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseButton.CustomImages.Parent = this.pauseButton;
            this.pauseButton.FillColor = System.Drawing.Color.Transparent;
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pauseButton.ForeColor = System.Drawing.Color.White;
            this.pauseButton.HoverState.Parent = this.pauseButton;
            this.pauseButton.ImageOffset = new System.Drawing.Point(1, 0);
            this.pauseButton.ImageSize = new System.Drawing.Size(95, 95);
            this.pauseButton.Location = new System.Drawing.Point(456, 234);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.PressedColor = System.Drawing.Color.DarkGray;
            this.pauseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pauseButton.ShadowDecoration.Parent = this.pauseButton;
            this.pauseButton.Size = new System.Drawing.Size(96, 95);
            this.pauseButton.TabIndex = 44;
            this.pauseButton.UseTransparentBackground = true;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pause_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.BorderRadius = 5;
            this.backButton.CheckedState.Parent = this.backButton;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.CustomImages.Parent = this.backButton;
            this.backButton.FillColor = System.Drawing.Color.Transparent;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.HoverState.Parent = this.backButton;
            this.backButton.ImageOffset = new System.Drawing.Point(1, 0);
            this.backButton.ImageSize = new System.Drawing.Size(65, 65);
            this.backButton.Location = new System.Drawing.Point(972, 12);
            this.backButton.Name = "backButton";
            this.backButton.ShadowDecoration.Parent = this.backButton;
            this.backButton.Size = new System.Drawing.Size(36, 35);
            this.backButton.TabIndex = 43;
            this.backButton.UseTransparentBackground = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GratitudeMeditation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GratitudeMeditation";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GratitudeMeditation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.Timer fadeIn;
        private Guna.UI2.WinForms.Guna2CircleButton playButton;
        private Guna.UI2.WinForms.Guna2CircleButton pauseButton;
        private Guna.UI2.WinForms.Guna2Button backButton;
    }
}