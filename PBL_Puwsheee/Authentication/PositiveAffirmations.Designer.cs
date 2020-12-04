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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositiveAffirmations));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.quotationsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.quotations = new System.Windows.Forms.Label();
            this.quotationsPanel.SuspendLayout();
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
            this.label1.Font = new System.Drawing.Font("Typo Round Bold Demo", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(71, 60);
            this.label1.MaximumSize = new System.Drawing.Size(630, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Good day USERNAME! :)";
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
            // quotationsPanel
            // 
            this.quotationsPanel.BackColor = System.Drawing.Color.Transparent;
            this.quotationsPanel.Controls.Add(this.quotations);
            this.quotationsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.quotationsPanel.Location = new System.Drawing.Point(80, 136);
            this.quotationsPanel.Name = "quotationsPanel";
            this.quotationsPanel.Radius = 20;
            this.quotationsPanel.ShadowColor = System.Drawing.Color.Black;
            this.quotationsPanel.Size = new System.Drawing.Size(865, 370);
            this.quotationsPanel.TabIndex = 2;
            // 
            // quotations
            // 
            this.quotations.AutoSize = true;
            this.quotations.Font = new System.Drawing.Font("Robaga Rounded Black", 15F);
            this.quotations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.quotations.Location = new System.Drawing.Point(143, 78);
            this.quotations.MaximumSize = new System.Drawing.Size(600, 0);
            this.quotations.Name = "quotations";
            this.quotations.Size = new System.Drawing.Size(588, 216);
            this.quotations.TabIndex = 0;
            this.quotations.Text = resources.GetString("quotations.Text");
            this.quotations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositiveAffirmations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.quotationsPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Typo Round Bold Demo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PositiveAffirmations";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PositiveAffirmations";
            this.quotationsPanel.ResumeLayout(false);
            this.quotationsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private Guna.UI2.WinForms.Guna2ShadowPanel quotationsPanel;
        private System.Windows.Forms.Label quotations;
    }
}