
namespace PBL_Puwsheee
{
    partial class Charts
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
            this.resultsButton = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.scoreHistoryCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.moodEntriesPointChart = new LiveCharts.WinForms.CartesianChart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.activityCountCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.activityCountPieChart = new LiveCharts.WinForms.PieChart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.moodCountCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.moodCountPieChart = new LiveCharts.WinForms.PieChart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.startDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.endDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultsButton
            // 
            this.resultsButton.BorderRadius = 16;
            this.resultsButton.CheckedState.Parent = this.resultsButton;
            this.resultsButton.CustomImages.Parent = this.resultsButton;
            this.resultsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.resultsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resultsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.resultsButton.HoverState.Parent = this.resultsButton;
            this.resultsButton.Location = new System.Drawing.Point(779, 27);
            this.resultsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.ShadowDecoration.Parent = this.resultsButton;
            this.resultsButton.Size = new System.Drawing.Size(108, 46);
            this.resultsButton.TabIndex = 12;
            this.resultsButton.Text = "See Results";
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.tabPage4.Controls.Add(this.scoreHistoryCartesianChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(867, 436);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Score History Line Chart";
            // 
            // scoreHistoryCartesianChart
            // 
            this.scoreHistoryCartesianChart.Location = new System.Drawing.Point(13, 15);
            this.scoreHistoryCartesianChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreHistoryCartesianChart.Name = "scoreHistoryCartesianChart";
            this.scoreHistoryCartesianChart.Size = new System.Drawing.Size(839, 401);
            this.scoreHistoryCartesianChart.TabIndex = 6;
            this.scoreHistoryCartesianChart.Text = "cartesianChart1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.tabPage3.Controls.Add(this.moodEntriesPointChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(867, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mood Entries Point Chart";
            // 
            // moodEntriesPointChart
            // 
            this.moodEntriesPointChart.Location = new System.Drawing.Point(13, 15);
            this.moodEntriesPointChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moodEntriesPointChart.Name = "moodEntriesPointChart";
            this.moodEntriesPointChart.Size = new System.Drawing.Size(839, 401);
            this.moodEntriesPointChart.TabIndex = 0;
            this.moodEntriesPointChart.Text = "cartesianChart1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.tabPage2.Controls.Add(this.activityCountCartesianChart);
            this.tabPage2.Controls.Add(this.activityCountPieChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(867, 436);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Activity Count Charts";
            // 
            // activityCountCartesianChart
            // 
            this.activityCountCartesianChart.Location = new System.Drawing.Point(411, 27);
            this.activityCountCartesianChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityCountCartesianChart.Name = "activityCountCartesianChart";
            this.activityCountCartesianChart.Size = new System.Drawing.Size(439, 388);
            this.activityCountCartesianChart.TabIndex = 1;
            this.activityCountCartesianChart.Text = "cartesianChart1";
            // 
            // activityCountPieChart
            // 
            this.activityCountPieChart.Location = new System.Drawing.Point(21, 27);
            this.activityCountPieChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityCountPieChart.Name = "activityCountPieChart";
            this.activityCountPieChart.Size = new System.Drawing.Size(381, 388);
            this.activityCountPieChart.TabIndex = 0;
            this.activityCountPieChart.Text = "pieChart1";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.tabPage1.Controls.Add(this.moodCountCartesianChart);
            this.tabPage1.Controls.Add(this.moodCountPieChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(867, 436);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Mood Count Charts";
            // 
            // moodCountCartesianChart
            // 
            this.moodCountCartesianChart.Location = new System.Drawing.Point(411, 27);
            this.moodCountCartesianChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moodCountCartesianChart.Name = "moodCountCartesianChart";
            this.moodCountCartesianChart.Size = new System.Drawing.Size(439, 388);
            this.moodCountCartesianChart.TabIndex = 7;
            this.moodCountCartesianChart.Text = "cartesianChart1";
            this.moodCountCartesianChart.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.moodCountCartesianChart_ChildChanged);
            // 
            // moodCountPieChart
            // 
            this.moodCountPieChart.Location = new System.Drawing.Point(21, 27);
            this.moodCountPieChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moodCountPieChart.Name = "moodCountPieChart";
            this.moodCountPieChart.Size = new System.Drawing.Size(381, 388);
            this.moodCountPieChart.TabIndex = 6;
            this.moodCountPieChart.Text = "pieChart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(144, 103);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 465);
            this.tabControl1.TabIndex = 15;
            // 
            // resetButton
            // 
            this.resetButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.resetButton.BorderRadius = 16;
            this.resetButton.BorderThickness = 2;
            this.resetButton.CheckedState.Parent = this.resetButton;
            this.resetButton.CustomImages.Parent = this.resetButton;
            this.resetButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.resetButton.HoverState.Parent = this.resetButton;
            this.resetButton.Location = new System.Drawing.Point(907, 28);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.ShadowDecoration.Parent = this.resetButton;
            this.resetButton.Size = new System.Drawing.Size(108, 46);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.BorderRadius = 10;
            this.startDateTimePicker.CheckedState.Parent = this.startDateTimePicker;
            this.startDateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.startDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startDateTimePicker.HoverState.Parent = this.startDateTimePicker;
            this.startDateTimePicker.Location = new System.Drawing.Point(148, 43);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.ShadowDecoration.Parent = this.startDateTimePicker;
            this.startDateTimePicker.Size = new System.Drawing.Size(292, 30);
            this.startDateTimePicker.TabIndex = 16;
            this.startDateTimePicker.Value = new System.DateTime(2020, 12, 8, 21, 9, 13, 614);
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.BorderRadius = 10;
            this.endDateTimePicker.CheckedState.Parent = this.endDateTimePicker;
            this.endDateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.endDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.endDateTimePicker.HoverState.Parent = this.endDateTimePicker;
            this.endDateTimePicker.Location = new System.Drawing.Point(468, 43);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.ShadowDecoration.Parent = this.endDateTimePicker;
            this.endDateTimePicker.Size = new System.Drawing.Size(292, 30);
            this.endDateTimePicker.TabIndex = 17;
            this.endDateTimePicker.Value = new System.DateTime(2020, 12, 8, 21, 9, 13, 614);
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(115, 79);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(932, 522);
            this.guna2ShadowPanel1.TabIndex = 18;
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1163, 613);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Charts";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button resultsButton;
        private System.Windows.Forms.TabPage tabPage4;
        private LiveCharts.WinForms.CartesianChart scoreHistoryCartesianChart;
        private System.Windows.Forms.TabPage tabPage3;
        private LiveCharts.WinForms.CartesianChart moodEntriesPointChart;
        private System.Windows.Forms.TabPage tabPage2;
        private LiveCharts.WinForms.CartesianChart activityCountCartesianChart;
        private LiveCharts.WinForms.PieChart activityCountPieChart;
        private System.Windows.Forms.TabPage tabPage1;
        private LiveCharts.WinForms.CartesianChart moodCountCartesianChart;
        private LiveCharts.WinForms.PieChart moodCountPieChart;
        private System.Windows.Forms.TabControl tabControl1;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker startDateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker endDateTimePicker;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}