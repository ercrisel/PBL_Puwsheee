
namespace PBL_Puwsheee.Playables
{
    partial class NewMusic
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
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pauseButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 50;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 30;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(43)))));
            this.label3.Font = new System.Drawing.Font("Robaga Rounded Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(196)))), ((int)(((byte)(194)))));
            this.label3.Location = new System.Drawing.Point(164, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Now Playing:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(43)))));
            this.label2.Font = new System.Drawing.Font("Typo Round Bold Demo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(196)))), ((int)(((byte)(194)))));
            this.label2.Location = new System.Drawing.Point(269, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "by Artifical Music";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(43)))));
            this.label1.Font = new System.Drawing.Font("Typo Round Bold Demo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(196)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(268, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "And So It Begins ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.pauseButton);
            this.panel1.Location = new System.Drawing.Point(509, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 90);
            this.panel1.TabIndex = 32;
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
            this.playButton.Image = global::PBL_Puwsheee.Properties.Resources.musicPlay;
            this.playButton.ImageOffset = new System.Drawing.Point(1, 0);
            this.playButton.ImageSize = new System.Drawing.Size(65, 65);
            this.playButton.Location = new System.Drawing.Point(19, 12);
            this.playButton.Name = "playButton";
            this.playButton.PressedColor = System.Drawing.Color.DarkGray;
            this.playButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.playButton.ShadowDecoration.Parent = this.playButton;
            this.playButton.Size = new System.Drawing.Size(66, 65);
            this.playButton.TabIndex = 29;
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
            this.pauseButton.Image = global::PBL_Puwsheee.Properties.Resources.musicPause;
            this.pauseButton.ImageOffset = new System.Drawing.Point(1, 0);
            this.pauseButton.ImageSize = new System.Drawing.Size(65, 65);
            this.pauseButton.Location = new System.Drawing.Point(19, 12);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.PressedColor = System.Drawing.Color.DarkGray;
            this.pauseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pauseButton.ShadowDecoration.Parent = this.pauseButton;
            this.pauseButton.Size = new System.Drawing.Size(66, 65);
            this.pauseButton.TabIndex = 28;
            this.pauseButton.UseTransparentBackground = true;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pause_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.BorderRadius = 15;
            this.backButton.CheckedState.Parent = this.backButton;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.CustomImages.Parent = this.backButton;
            this.backButton.FillColor = System.Drawing.Color.Transparent;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.HoverState.Parent = this.backButton;
            this.backButton.Image = global::PBL_Puwsheee.Properties.Resources.musicClose;
            this.backButton.ImageSize = new System.Drawing.Size(50, 50);
            this.backButton.Location = new System.Drawing.Point(975, 9);
            this.backButton.Name = "backButton";
            this.backButton.ShadowDecoration.Parent = this.backButton;
            this.backButton.Size = new System.Drawing.Size(35, 35);
            this.backButton.TabIndex = 26;
            this.backButton.UseTransparentBackground = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PBL_Puwsheee.Properties.Resources.musicBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 610);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // NewMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewMusic";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMusic";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button backButton;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton pauseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton playButton;
    }
}