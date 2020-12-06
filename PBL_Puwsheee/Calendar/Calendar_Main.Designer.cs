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
            this.monthCalendar1 = new Pabo.Calendar.MonthCalendar();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ActiveMonth.Month = 12;
            this.monthCalendar1.ActiveMonth.Year = 2020;
            this.monthCalendar1.Culture = new System.Globalization.CultureInfo("en-PH");
            this.monthCalendar1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar1.ImageList = null;
            this.monthCalendar1.Location = new System.Drawing.Point(12, 12);
            this.monthCalendar1.MaxDate = new System.DateTime(2030, 12, 6, 21, 28, 49, 818);
            this.monthCalendar1.MinDate = new System.DateTime(2010, 12, 6, 21, 28, 49, 818);
            this.monthCalendar1.Month.BackgroundImage = null;
            this.monthCalendar1.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(848, 496);
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TodayColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.monthCalendar1.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.MonthChanged += new Pabo.Calendar.MonthChangedEventHandler(this.monthCalendar_MonthChanged);
            this.monthCalendar1.DayClick += new Pabo.Calendar.DayClickEventHandler(this.monthCalendar_DayClick);
            // 
            // Calendar_Main
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(886, 536);
            this.Controls.Add(this.monthCalendar1);
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
    }
}