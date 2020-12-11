namespace PBL_Puwsheee
{
    partial class SplashScreen
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
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.loadingbasisPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.loadingPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.loadingbasisPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // countdown
            // 
            this.countdown.Interval = 20;
            this.countdown.Tick += new System.EventHandler(this.countdownTick);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 3;
            this.fadeIn.Tick += new System.EventHandler(this.fadeInTick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 2;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOutTick);
            // 
            // loadingbasisPanel
            // 
            this.loadingbasisPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.loadingbasisPanel.BorderRadius = 4;
            this.loadingbasisPanel.Controls.Add(this.loadingPanel);
            this.loadingbasisPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.loadingbasisPanel.Location = new System.Drawing.Point(8, 562);
            this.loadingbasisPanel.Name = "loadingbasisPanel";
            this.loadingbasisPanel.ShadowDecoration.Parent = this.loadingbasisPanel;
            this.loadingbasisPanel.Size = new System.Drawing.Size(1004, 10);
            this.loadingbasisPanel.TabIndex = 0;
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.Color.Transparent;
            this.loadingPanel.BorderRadius = 4;
            this.loadingPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.loadingPanel.Location = new System.Drawing.Point(0, 0);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.ShadowDecoration.Parent = this.loadingPanel;
            this.loadingPanel.Size = new System.Drawing.Size(0, 10);
            this.loadingPanel.TabIndex = 1;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
//            this.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.SplashScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1020, 580);
            this.Controls.Add(this.loadingbasisPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.loadingbasisPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private Guna.UI2.WinForms.Guna2Panel loadingbasisPanel;
        private Guna.UI2.WinForms.Guna2Panel loadingPanel;
    }
}