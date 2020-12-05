using Pabo.Calendar;
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
    public partial class Calendar_Main : Form
    {
        // 🌻💛🔆🧸💕 babe: check out FormatDates() 💕🧸🔆💛🌻

        private List<DateItem> dateItems = new List<DateItem>();
        private UserInfo user = new UserInfo();
        private MoodEntry moodEntry;

        public Calendar_Main()
        {
            InitializeComponent();

            moodEntry = new MoodEntry(user.Username);
            moodEntry.Username = "hrvrldn";
            user.Username = "hrvrldn";
        }

        public Calendar_Main(UserInfo userInfo)
        {
            InitializeComponent();

            var user = userInfo;
            moodEntry = new MoodEntry(user.Username);
        }

        private void Calendar_Main_Load(object sender, EventArgs e)
        {
            LoadDates();
        }

        private void monthCalendar_MonthChanged(object sender, MonthChangedEventArgs e)
        {
            LoadDates();
        }

        private void monthCalendar_DayClick(object sender, DayClickEventArgs e)
        {
            var date = DateTime.Parse(e.Date);
            CreateCalendarCard(date);
        }

        private void cardFormClosing(object sender, FormClosingEventArgs e)
        {
            LoadDates();
        }

        //CUSTOM METHODS
        /// <summary>
        /// compilation of methods that stores and formats dates accordingly
        /// </summary>
        private void LoadDates()
        {
            var startDate = new DateTime(monthCalendar.ActiveMonth.Year, monthCalendar.ActiveMonth.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            var moodEntryList = GetListOfSelectedRangeMoodEntries(startDate, endDate);

            ClearData(); //clears previous data
            StoreDatainDateItems(moodEntryList);
            FormatDates();
            monthCalendar.AddDateInfo(dateItems.OrderBy(x => x.Date).ToArray()); //orderby cuz debugging easier
        }

        /// <summary>
        /// generate datetime for each day in between start date and end date
        /// </summary>
        /// <param name="startDate">start date</param>
        /// <param name="endDate">end date</param>
        /// <returns>yield returns each day</returns>
        public IEnumerable<DateTime> EachDay(DateTime startDate, DateTime endDate)
        {
            for (var day = startDate.Date; day.Date <= endDate.Date; day = day.AddDays(1))
                yield return day;
        }

        /// <summary>
        /// fills a list of mood entries from start date to end date
        /// </summary>
        /// <param name="startDate">start date</param>
        /// <param name="endDate">end date</param>
        /// <returns>list of mood entries</returns>
        private List<MoodEntry> GetListOfSelectedRangeMoodEntries(DateTime startDate, DateTime endDate)
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

        /// <summary>
        /// clears previous data of date items and month calendar; prevents duplicating/cloning items when loading dates
        /// </summary>
        private void ClearData()
        {
            dateItems.Clear();
            monthCalendar.ResetDateInfo();
        }

        /// <summary>
        /// stores data from the list into date items
        /// </summary>
        /// <param name="moodEntries">list of mood entries in a date range</param>
        private void StoreDatainDateItems(List<MoodEntry> moodEntries)
        {
            foreach (var moodEntry in moodEntries)
            {
                var dateItem = new DateItem();
                dateItem.Date = moodEntry.Date;
                dateItem.Tag = moodEntry.Mood;
                dateItems.Add(dateItem);
            }
        }

        /// <summary>
        /// 🌻💛🔆🧸💕 babe: format date items depending on mood 💕🧸🔆💛🌻
        /// </summary>
        private void FormatDates()
        {
            foreach (var dateItem in dateItems)
            {
                var mood = (Mood)dateItem.Tag;
                switch (mood.Rank)
                {
                    case 1:
                        dateItem.BackColor1 = Color.Red;
                        break;
                    case 2:
                        dateItem.BackColor1 = Color.Orange;
                        break;
                    case 3:
                        dateItem.BackColor1 = Color.Yellow;
                        break;
                    case 4:
                        dateItem.BackColor1 = Color.Green;
                        break;
                    case 5:
                        dateItem.BackColor1 = Color.Blue;
                        break;
                    case 6:
                        dateItem.BackColor1 = Color.Purple;
                        break;
                    case 7:
                        dateItem.BackColor1 = Color.Violet;
                        break;
                    case 8:
                        dateItem.BackColor1 = Color.Pink;
                        break;
                    default:
                        dateItem.BackColor1 = Color.White;
                        break;
                }
            }
        }

        /// <summary>
        /// creates a Calendar_Card(form) depending on the date parameter passed
        /// </summary>
        /// <param name="date">corresponds to the day that clicked/picked</param>
        private void CreateCalendarCard(DateTime date)
        {
            if (date <= DateTime.Today) //if it is today or an earlier date, show a form; else, nothing happens
            {
                Form bg = new Form();
                Form card = new Calendar.Calendar_Card(date);
                card.FormClosing += new FormClosingEventHandler(this.cardFormClosing); //creates custom event
                bg.StartPosition = FormStartPosition.CenterScreen;
                bg.FormBorderStyle = FormBorderStyle.None;
                bg.Opacity = .50d;
                bg.BackColor = Color.Black;
                bg.WindowState = FormWindowState.Normal;
                bg.TopMost = true;
                bg.Location = this.Location;
                bg.ShowInTaskbar = false;
                bg.Size = new Size(1020, 610);
                bg.Show();

                card.Owner = bg;
                card.ShowDialog();
                bg.Dispose();
            }
        }
    }
}
