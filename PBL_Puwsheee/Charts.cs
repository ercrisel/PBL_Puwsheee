using LiveCharts;
using LiveCharts.Wpf;
using PBL_Puwsheee.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee
{
    /// <summary>
    /// 🌻💛🔆🧸💕 
    /// babe: minimize so it isn't overwhelming; i didn't create the form as a child form. the only thing i did in
    /// creating the form is change Size, ForeColor, and BackColor
    /// alsoooo, oh noes. i think mahihirapan tayo i-personalize yung chart, kailangan pag-aralan
    /// if ever may gusto kayo gawin na hindi niyo magawa, tanong kayo sa akin tas figure out natin ng sabay kung magagawa.
    /// focus on all Binds(): BindDataMoodCount(), BindDataActivityCount(), BindDataMoodEntries(), BindDataScoreHistory();
    /// 💕🧸🔆💛🌻
    /// </summary>
    public partial class Charts : Form
    {
        private readonly UserInfo user = new UserInfo();
        private List<Mood> moodsList = new List<Mood>();
        private List<Activity> activitiesList = new List<Activity>();
        private List<MoodEntry> moodEntriesList = new List<MoodEntry>();
        private List<TestScore> testScoresList = new List<TestScore>();
        private List<List<Activity>> activitiesByMoodList = new List<List<Activity>>();
        public struct ActivityCount
        {
            public int activityId;
            public int count;
        }
        public struct MoodCount
        {
            public int moodId;
            public int count;
        }

        public Charts()
        {
            InitializeComponent();
            user.Username = "hrvrldn";
        }

        public Charts(UserInfo userInfo)
        {
            InitializeComponent();
            user = userInfo;
        }

        //EVENTS
        private void Charts_Load(object sender, EventArgs e)
        {
            InitializeDates();
            CreateLists();
            LoadAnalysisCharts();
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            LoadAnalysisCharts();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            InitializeDates();
            LoadAnalysisCharts();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckValidDate();
        }

        //CUSTOM METHODS
        private void InitializeDates()
        {
            endDateTimePicker.Value = DateTime.Today;
            startDateTimePicker.Value = startDateTimePicker.Value.AddMonths(-1);
        }

        private void CheckValidDate()
        {
            if (endDateTimePicker.Value > DateTime.Today) endDateTimePicker.Value = DateTime.Today;
            if (startDateTimePicker.Value > DateTime.Today) startDateTimePicker.Value = DateTime.Today;
            if (startDateTimePicker.Value > endDateTimePicker.Value) startDateTimePicker.Value = endDateTimePicker.Value;
        }

        private void CreateLists()
        {
            for (int i = 0; i < 8; i++) //hard coded for the 8 different emotions
            {
                activitiesByMoodList.Add(new List<Activity>());
            }
        }

        private void LoadAnalysisCharts()
        {
            ClearData(); //clears any previous data
            PopulateLists();
            BindDataMoodCount();
            BindDataActivityCount();
            BindDataMoodEntries();
            BindDataScoreHistory();
        }

        private void ClearData()
        {
            moodsList.Clear();
            activitiesList.Clear();
            moodEntriesList.Clear();
            testScoresList.Clear();
            moodCountPieChart.Series.Clear();
            moodCountCartesianChart.Series.Clear();
            activityCountPieChart.Series.Clear();
            activityCountCartesianChart.Series.Clear();
            moodEntriesPointChart.Series.Clear();
            scoreHistoryCartesianChart.Series.Clear();
        }

        private void PopulateLists()
        {
            var startDate = startDateTimePicker.Value;
            var endDate = endDateTimePicker.Value;
            moodEntriesList = GetListOfSelectedMoodEntries(startDate, endDate);
            testScoresList = GetListOfSelectedTestScores(startDate, endDate);

            foreach (var moodEntry in moodEntriesList)
            {
                moodsList.Add(moodEntry.Mood);
                moodEntry.Activities.ForEach(x => activitiesList.Add(x));
                moodEntry.Activities.ForEach(x => SortActivityByMood(moodEntry.Mood, x));
            }
        }

        public IEnumerable<DateTime> EachDay(DateTime startDate, DateTime endDate)
        {
            for (var day = startDate.Date; day.Date <= endDate.Date; day = day.AddDays(1))
                yield return day;
        }

        private List<MoodEntry> GetListOfSelectedMoodEntries(DateTime startDate, DateTime endDate)
        {
            var moodEntryList = new List<MoodEntry>();

            foreach (var date in EachDay(startDate, endDate))
            {
                var moodEntry = new MoodEntry(user.Username, date);
                if (moodEntry.IsExistingRecord())
                {
                    moodEntry.SelectMoodEntry();
                    moodEntryList.Add(moodEntry);
                }
            }

            return moodEntryList;
        }

        private List<TestScore> GetListOfSelectedTestScores(DateTime startDate, DateTime endDate)
        {
            var testScoreList = new List<TestScore>();

            foreach (var date in EachDay(startDate, endDate))
            {
                var testScore = new TestScore(user.Username, date);
                if (testScore.IsExistingRecord())
                {
                    testScore.SelectTestScore();
                    testScoreList.Add(testScore);
                }
            }

            return testScoreList;
        }

        private void SortActivityByMood(Mood mood, Activity activity)
        {
            for (int i = 1; i <= activitiesByMoodList.Count; i++)
            {
                if (i == mood.Rank)
                    activitiesByMoodList.ElementAt(i - 1).Add(activity);
                else
                    continue;
            }
        }

        private List<MoodCount> GetSortedMoodCountList()
        {
            var tempList = new List<MoodCount>();

            for (int i = 1; i <= 8; i++) //again, this is sadly hard coded for the fixed 1-8 moods
            {
                int count = moodsList.Count(x => x.Rank == i);
                MoodCount moodCount;
                moodCount.moodId = i;
                moodCount.count = count;
                tempList.Add(moodCount);
            }

            return tempList;
        }

        private List<ActivityCount> GetSortedActivitiesCountList()
        {
            var tempList = new List<ActivityCount>();

            for (int i = 1; i <= 12; i++) //1-12 are the activities; hard coded, this is so sad
            {
                var count = activitiesList.Count(x => x.Id == i); //counts each activity
                ActivityCount tempActivityCount;
                tempActivityCount.activityId = i;
                tempActivityCount.count = count;
                tempList.Add(tempActivityCount);
            }

            return tempList;
        }

        /// <summary>
        /// 🌻💛🔆🧸💕 babe: binds collected data to moodCountPieChart and moodCountCartesianChart 💕🧸🔆💛🌻
        /// </summary>
        private void BindDataMoodCount()
        {
            var moodCountList = GetSortedMoodCountList().OrderBy(x => x.count);

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var moodCount in moodCountList)
            {
                var mood = new Mood(moodCount.moodId);

                moodCountPieChart.Series.Add(
                new PieSeries
                {
                    Title = mood.Category,
                    Values = new ChartValues<double>() { moodCount.count },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });

                moodCountCartesianChart.Series.Add(
                new ColumnSeries
                {
                    Title = mood.Category,
                    Values = new ChartValues<double>() { moodCount.count }
                });
            }
        }

        /// <summary>
        /// 💕🧸🔆💛🌻 babe: binds collected data to activityCountPieChart and activityCountCartesianChart 💕🧸🔆💛🌻
        /// </summary>
        private void BindDataActivityCount()
        {
            var activityCountList = GetSortedActivitiesCountList().OrderBy(x => x.count);

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y);

            foreach (var activityCount in activityCountList)
            {
                var activity = new Activity(activityCount.activityId);

                activityCountPieChart.Series.Add(
                new PieSeries
                {
                    Title = activity.Category,
                    Values = new ChartValues<double>() { activityCount.count },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });

                activityCountCartesianChart.Series.Add(
                new ColumnSeries
                {
                    Title = activity.Category,
                    Values = new ChartValues<double>() { activityCount.count }
                });
            }
        }

        /// <summary>
        /// 💕🧸🔆💛🌻 babe: binds collected data to moodEntriesPointChart 💕🧸🔆💛🌻
        /// </summary>
        private void BindDataMoodEntries()
        {
            var moodHistoryList = moodEntriesList;
            var tempMoodChartValues = new ChartValues<double>();

            foreach (var date in EachDay(startDateTimePicker.Value, endDateTimePicker.Value))
            {
                if (moodHistoryList.Any(x => x.Date == date))
                {
                    tempMoodChartValues.Add(moodHistoryList.Find(x => x.Date == date).Mood.Rank);
                }
                else
                    tempMoodChartValues.Add(double.NaN);
            }

            moodEntriesPointChart.Series.Add(
                new LineSeries
                {
                    Title = "Mood",
                    Values = tempMoodChartValues,
                    Stroke = System.Windows.Media.Brushes.Transparent,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    PointGeometrySize = 10,
                    PointForeground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
                });
        }

        /// <summary>
        /// 💕🧸🔆💛🌻 babe: binds collected data to scoreHistoryCartesianChart 💕🧸🔆💛🌻
        /// </summary>
        private void BindDataScoreHistory()
        {
            var scoreHistoryList = testScoresList;
            var tempTest1ChartValues = new ChartValues<double>();
            var tempTest2ChartValues = new ChartValues<double>();
            var tempTest3ChartValues = new ChartValues<double>();

            foreach (var date in EachDay(startDateTimePicker.Value, endDateTimePicker.Value))
            {
                if (scoreHistoryList.Any(x => x.DateTaken == date))
                {
                    var tempScore = scoreHistoryList.Find(el => el.DateTaken == date);
                    double tempTest1 = (tempScore.GoodSelfCareScore.HasValue) ? tempTest1 = (double)tempScore.GoodSelfCareScore : tempTest1 = double.NaN;
                    double tempTest2 = (tempScore.EmotionalIntelligenceScore.HasValue) ? tempTest2 = (double)tempScore.EmotionalIntelligenceScore : tempTest2 = double.NaN;
                    double tempTest3 = (tempScore.AnxietyAndDepressionScore.HasValue) ? tempTest3 = (double)tempScore.AnxietyAndDepressionScore : tempTest3 = double.NaN;
                    tempTest1ChartValues.Add(tempTest1);
                    tempTest2ChartValues.Add(tempTest2);
                    tempTest3ChartValues.Add(tempTest3);
                }
                else
                {
                    tempTest1ChartValues.Add(double.NaN);
                    tempTest2ChartValues.Add(double.NaN);
                    tempTest3ChartValues.Add(double.NaN);
                }

            }

            scoreHistoryCartesianChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Good Self Care",
                    Values = tempTest1ChartValues
                },
                new LineSeries
                {
                    Title = "Emotional Intelligence Score",
                    Values = tempTest2ChartValues
                },
                new LineSeries
                {
                    Title = "Anxiety and Depression Score",
                    Values = tempTest3ChartValues
                }
            };
        }
    }
}
