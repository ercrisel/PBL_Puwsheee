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
            this.logoLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logoPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Location = new System.Drawing.Point(468, 481);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(86, 15);
            this.logoLabel.TabIndex = 3;
            this.logoLabel.Text = "guna2HtmlLabel1";
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::PBL_Puwsheee.Properties.Resources.SamplePhoto;
            this.logoPicture.Location = new System.Drawing.Point(320, 64);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logoPicture.ShadowDecoration.Parent = this.logoPicture;
            this.logoPicture.Size = new System.Drawing.Size(377, 379);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 2;
            this.logoPicture.TabStop = false;
            // 
            // countdown
            // 
            this.countdown.Enabled = true;
            this.countdown.Interval = 3000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1020, 580);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.logoPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel logoLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox logoPicture;
        private System.Windows.Forms.Timer countdown;
    }
}