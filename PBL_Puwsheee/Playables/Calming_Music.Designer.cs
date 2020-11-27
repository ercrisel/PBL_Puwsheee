using System.IO;

namespace PBL_Puwsheee.Playables
{
    partial class Calming_Music
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
            Guna.UI2.WinForms.Guna2CircleButton play;
            this.pauseButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.rainAmbienceText = new System.Windows.Forms.PictureBox();
            this.rainGif = new System.Windows.Forms.PictureBox();
            play = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.rainAmbienceText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainGif)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            play.BackColor = System.Drawing.Color.Transparent;
            play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            play.CheckedState.Parent = play;
            play.Cursor = System.Windows.Forms.Cursors.Hand;
            play.CustomImages.Parent = play;
            play.FillColor = System.Drawing.Color.Transparent;
            play.Font = new System.Drawing.Font("Segoe UI", 9F);
            play.ForeColor = System.Drawing.Color.White;
            play.HoverState.Parent = play;
            play.Image = global::PBL_Puwsheee.Properties.Resources.play_button;
            play.ImageSize = new System.Drawing.Size(104, 105);
            play.Location = new System.Drawing.Point(314, 156);
            play.Name = "play";
            play.PressedColor = System.Drawing.Color.DarkGray;
            play.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            play.ShadowDecoration.Parent = play;
            play.Size = new System.Drawing.Size(117, 105);
            play.TabIndex = 1;
            play.UseTransparentBackground = true;
            play.Click += new System.EventHandler(this.play_Click);
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
            this.pauseButton.Image = global::PBL_Puwsheee.Properties.Resources.pause;
            this.pauseButton.ImageSize = new System.Drawing.Size(104, 105);
            this.pauseButton.Location = new System.Drawing.Point(314, 156);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.PressedColor = System.Drawing.Color.DarkGray;
            this.pauseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pauseButton.ShadowDecoration.Parent = this.pauseButton;
            this.pauseButton.Size = new System.Drawing.Size(117, 105);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.UseTransparentBackground = true;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pause_Click);
            // 
            // rainAmbienceText
            // 
            this.rainAmbienceText.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.Rain_Ambience_Text;
            this.rainAmbienceText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rainAmbienceText.Location = new System.Drawing.Point(187, 223);
            this.rainAmbienceText.Name = "rainAmbienceText";
            this.rainAmbienceText.Size = new System.Drawing.Size(391, 124);
            this.rainAmbienceText.TabIndex = 0;
            this.rainAmbienceText.TabStop = false;
            // 
            // rainGif
            // 
            this.rainGif.Image = global::PBL_Puwsheee.Properties.Resources.rain_gif;
            this.rainGif.Location = new System.Drawing.Point(40, -53);
            this.rainGif.Name = "rainGif";
            this.rainGif.Size = new System.Drawing.Size(638, 473);
            this.rainGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rainGif.TabIndex = 4;
            this.rainGif.TabStop = false;
            this.rainGif.Visible = false;
            this.rainGif.Click += new System.EventHandler(this.rainGif_Click);
            // 
            // Calming_Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(776, 442);
            this.Controls.Add(play);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.rainAmbienceText);
            this.Controls.Add(this.rainGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calming_Music";
            this.Tag = "music";
            this.Text = "Calming_Music";
            ((System.ComponentModel.ISupportInitialize)(this.rainAmbienceText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rainAmbienceText;
        private Guna.UI2.WinForms.Guna2CircleButton pauseButton;
        private System.Windows.Forms.PictureBox rainGif;
    }
}