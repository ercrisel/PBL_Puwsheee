namespace PBL_Puwsheee.Settings
{
    partial class Clear_Data
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
            this.yesClear = new Guna.UI2.WinForms.Guna2Button();
            this.noClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // yesClear
            // 
            this.yesClear.CheckedState.Parent = this.yesClear;
            this.yesClear.CustomImages.Parent = this.yesClear;
            this.yesClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yesClear.ForeColor = System.Drawing.Color.White;
            this.yesClear.HoverState.Parent = this.yesClear;
            this.yesClear.Location = new System.Drawing.Point(107, 286);
            this.yesClear.Name = "yesClear";
            this.yesClear.ShadowDecoration.Parent = this.yesClear;
            this.yesClear.Size = new System.Drawing.Size(180, 45);
            this.yesClear.TabIndex = 0;
            this.yesClear.Text = "YES";
            this.yesClear.Click += new System.EventHandler(this.clickCancel);
            // 
            // noClear
            // 
            this.noClear.CheckedState.Parent = this.noClear;
            this.noClear.CustomImages.Parent = this.noClear;
            this.noClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noClear.ForeColor = System.Drawing.Color.White;
            this.noClear.HoverState.Parent = this.noClear;
            this.noClear.Location = new System.Drawing.Point(326, 286);
            this.noClear.Name = "noClear";
            this.noClear.ShadowDecoration.Parent = this.noClear;
            this.noClear.Size = new System.Drawing.Size(180, 45);
            this.noClear.TabIndex = 1;
            this.noClear.Text = "NO";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(219, 107);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(187, 15);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "ALL YOUR DATA WILL BE CLEARED";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(139, 128);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(355, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "ARE U SURE U WANT TO DELETE ALL OF YOUR PROGRESS / DATA";
            // 
            // Clear_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 370);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.noClear);
            this.Controls.Add(this.yesClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clear_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clear_Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button yesClear;
        private Guna.UI2.WinForms.Guna2Button noClear;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}