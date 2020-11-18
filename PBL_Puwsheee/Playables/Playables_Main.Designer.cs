namespace PBL_Puwsheee.Playables
{
    partial class Playables_Main
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
            this.playPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // playPanel
            // 
            this.playPanel.Location = new System.Drawing.Point(12, 12);
            this.playPanel.Name = "playPanel";
            this.playPanel.ShadowDecoration.Parent = this.playPanel;
            this.playPanel.Size = new System.Drawing.Size(792, 481);
            this.playPanel.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.Down;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(824, 256);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(34, 31);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Click += new System.EventHandler(this.downButton_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackgroundImage = global::PBL_Puwsheee.Properties.Resources.Up;
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(824, 189);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(34, 31);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Click += new System.EventHandler(this.upButton_Click);
            // 
            // Playables_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(935, 505);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.playPanel);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playables_Main";
            this.Text = "Playables";
            this.Load += new System.EventHandler(this.upButton_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel playPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}