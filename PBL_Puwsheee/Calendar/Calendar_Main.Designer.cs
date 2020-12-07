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
            this.monthCalendar2 = new Pabo.Calendar.MonthCalendar();
            this.SuspendLayout();
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.ActiveMonth.Month = 12;
            this.monthCalendar2.ActiveMonth.Year = 2020;
            this.monthCalendar2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.monthCalendar2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.monthCalendar2.Culture = new System.Globalization.CultureInfo("en-PH");
            this.monthCalendar2.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar2.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar2.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar2.ImageList = null;
            this.monthCalendar2.Location = new System.Drawing.Point(8, 13);
            this.monthCalendar2.MaxDate = new System.DateTime(2030, 12, 6, 21, 49, 39, 497);
            this.monthCalendar2.MinDate = new System.DateTime(2010, 12, 6, 21, 49, 39, 497);
            this.monthCalendar2.Month.BackgroundImage = null;
            this.monthCalendar2.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar2.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.Size = new System.Drawing.Size(862, 499);
            this.monthCalendar2.TabIndex = 0;
            this.monthCalendar2.TodayColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.monthCalendar2.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar2.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar2.MonthChanged += new Pabo.Calendar.MonthChangedEventHandler(this.monthCalendar_MonthChanged);
            this.monthCalendar2.DayClick += new Pabo.Calendar.DayClickEventHandler(this.monthCalendar_DayClick);
            // 
            // Calendar_Main
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(886, 536);
            this.Controls.Add(this.monthCalendar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calendar_Main";
            this.Load += new System.EventHandler(this.Calendar_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer fadeInBg;
        private System.Windows.Forms.Timer fadeInCard;
        private Pabo.Calendar.MonthCalendar monthCalendar;
        private Pabo.Calendar.MonthCalendar monthCalendar1;
        private Pabo.Calendar.MonthCalendar monthCalendar2;
    }
}