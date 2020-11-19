namespace PBL_Puwsheee.Calendar
{
    partial class Remove_Entry
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.removeButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Robaga Rounded Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(271, 174);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(310, 18);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Are you sure you want to remove your entry?";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Typo Round Bold Demo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(308, 214);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(221, 18);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "All entry for this day will be cleared";
            // 
            // cancelButton
            // 
            this.cancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.cancelButton.BorderRadius = 16;
            this.cancelButton.BorderThickness = 2;
            this.cancelButton.CheckedState.Parent = this.cancelButton;
            this.cancelButton.CustomImages.Parent = this.cancelButton;
            this.cancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.cancelButton.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.cancelButton.HoverState.Parent = this.cancelButton;
            this.cancelButton.Location = new System.Drawing.Point(223, 287);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
            this.cancelButton.Size = new System.Drawing.Size(151, 43);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            // 
            // removeButton
            // 
            this.removeButton.BorderRadius = 16;
            this.removeButton.CheckedState.Parent = this.removeButton;
            this.removeButton.CustomImages.Parent = this.removeButton;
            this.removeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(48)))), ((int)(((byte)(27)))));
            this.removeButton.Font = new System.Drawing.Font("Typo Round Bold Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.removeButton.HoverState.Parent = this.removeButton;
            this.removeButton.Location = new System.Drawing.Point(463, 287);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeButton.Name = "removeButton";
            this.removeButton.ShadowDecoration.Parent = this.removeButton;
            this.removeButton.Size = new System.Drawing.Size(151, 43);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove Entry";
            // 
            // Remove_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(853, 455);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Remove_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove_Entry";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Remove_Entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button removeButton;
    }
}