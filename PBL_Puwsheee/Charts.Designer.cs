
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
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resultsButton = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.scoreHistoryCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.moodEntriesPointChart = new LiveCharts.WinForms.CartesianChart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.activityCountPieChart = new LiveCharts.WinForms.PieChart();
            this.activityCountCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.moodCountPieChart = new LiveCharts.WinForms.PieChart();
            this.moodCountCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(525, 57);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endDateTimePicker.TabIndex = 13;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(272, 57);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDateTimePicker.TabIndex = 14;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // resultsButton
            // 
            this.resultsButton.CheckedState.Parent = this.resultsButton;
            this.resultsButton.CustomImages.Parent = this.resultsButton;
            this.resultsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resultsButton.ForeColor = System.Drawing.Color.White;
            this.resultsButton.HoverState.Parent = this.resultsButton;
            this.resultsButton.Location = new System.Drawing.Point(778, 43);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.ShadowDecoration.Parent = this.resultsButton;
            this.resultsButton.Size = new System.Drawing.Size(108, 45);
            this.resultsButton.TabIndex = 12;
            this.resultsButton.Text = "See Results";
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.scoreHistoryCartesianChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(866, 436);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Score History Line Chart";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // scoreHistoryCartesianChart
            // 
            this.scoreHistoryCartesianChart.Location = new System.Drawing.Point(13, 15);
            this.scoreHistoryCartesianChart.Name = "scoreHistoryCartesianChart";
            this.scoreHistoryCartesianChart.Size = new System.Drawing.Size(839, 401);
            this.scoreHistoryCartesianChart.TabIndex = 6;
            this.scoreHistoryCartesianChart.Text = "cartesianChart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.moodEntriesPointChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(866, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mood Entries Point Chart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // moodEntriesPointChart
            // 
            this.moodEntriesPointChart.Location = new System.Drawing.Point(13, 15);
            this.moodEntriesPointChart.Name = "moodEntriesPointChart";
            this.moodEntriesPointChart.Size = new System.Drawing.Size(839, 401);
            this.moodEntriesPointChart.TabIndex = 0;
            this.moodEntriesPointChart.Text = "cartesianChart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.activityCountCartesianChart);
            this.tabPage2.Controls.Add(this.activityCountPieChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(866, 436);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Activity Count Charts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // activityCountPieChart
            // 
            this.activityCountPieChart.Location = new System.Drawing.Point(22, 27);
            this.activityCountPieChart.Name = "activityCountPieChart";
            this.activityCountPieChart.Size = new System.Drawing.Size(382, 388);
            this.activityCountPieChart.TabIndex = 0;
            this.activityCountPieChart.Text = "pieChart1";
            // 
            // activityCountCartesianChart
            // 
            this.activityCountCartesianChart.Location = new System.Drawing.Point(410, 27);
            this.activityCountCartesianChart.Name = "activityCountCartesianChart";
            this.activityCountCartesianChart.Size = new System.Drawing.Size(439, 388);
            this.activityCountCartesianChart.TabIndex = 1;
            this.activityCountCartesianChart.Text = "cartesianChart1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.moodCountCartesianChart);
            this.tabPage1.Controls.Add(this.moodCountPieChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 436);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Mood Count Charts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // moodCountPieChart
            // 
            this.moodCountPieChart.Location = new System.Drawing.Point(22, 27);
            this.moodCountPieChart.Name = "moodCountPieChart";
            this.moodCountPieChart.Size = new System.Drawing.Size(382, 388);
            this.moodCountPieChart.TabIndex = 6;
            this.moodCountPieChart.Text = "pieChart1";
            // 
            // moodCountCartesianChart
            // 
            this.moodCountCartesianChart.Location = new System.Drawing.Point(410, 27);
            this.moodCountCartesianChart.Name = "moodCountCartesianChart";
            this.moodCountCartesianChart.Size = new System.Drawing.Size(439, 388);
            this.moodCountCartesianChart.TabIndex = 7;
            this.moodCountCartesianChart.Text = "cartesianChart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(144, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 465);
            this.tabControl1.TabIndex = 15;
            // 
            // resetButton
            // 
            this.resetButton.CheckedState.Parent = this.resetButton;
            this.resetButton.CustomImages.Parent = this.resetButton;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.HoverState.Parent = this.resetButton;
            this.resetButton.Location = new System.Drawing.Point(910, 43);
            this.resetButton.Name = "resetButton";
            this.resetButton.ShadowDecoration.Parent = this.resetButton;
            this.resetButton.Size = new System.Drawing.Size(108, 45);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(198)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1162, 613);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultsButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
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
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
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
    }
}