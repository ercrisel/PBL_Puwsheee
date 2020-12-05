namespace PBL_Puwsheee
{
    partial class Calendar_Main
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
            this.fadeInBg = new System.Windows.Forms.Timer(this.components);
            this.fadeInCard = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar = new Pabo.Calendar.MonthCalendar();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.ActiveMonth.Month = 12;
            this.monthCalendar.ActiveMonth.Year = 2020;
            this.monthCalendar.Culture = new System.Globalization.CultureInfo("en-PH");
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.monthCalendar.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar.ImageList = null;
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.MaxDate = new System.DateTime(2030, 12, 5, 4, 53, 3, 410);
            this.monthCalendar.MinDate = new System.DateTime(2010, 12, 5, 4, 53, 3, 410);
            this.monthCalendar.Month.BackgroundImage = null;
            this.monthCalendar.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.SelectionMode = Pabo.Calendar.mcSelectionMode.One;
            this.monthCalendar.Size = new System.Drawing.Size(1049, 622);
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar.MonthChanged += new Pabo.Calendar.MonthChangedEventHandler(this.monthCalendar_MonthChanged);
            this.monthCalendar.DayClick += new Pabo.Calendar.DayClickEventHandler(this.monthCalendar_DayClick);
            // 
            // Calendar_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1247, 622);
            this.Controls.Add(this.monthCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Calendar_Main";
            this.Text = "Calendar ";
            this.Load += new System.EventHandler(this.Calendar_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer fadeInBg;
        private System.Windows.Forms.Timer fadeInCard;
        private Pabo.Calendar.MonthCalendar monthCalendar;
    }
}